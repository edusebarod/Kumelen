Public Class frmDevengacionXCurso
    Public Dev As New Devengacion
    Public repoDeveng As New RepoDevengación
    Public repoAlu As New RepoAlumno
    Public alumnos As List(Of Integer)
    Public sucursal As String

    Private Sub frmAlumnosXCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        CargarCursos(cbxCurso)
        CargarCuentas()
        CargarServicios()
    End Sub


    Private Sub btnDevengar_Click(sender As Object, e As EventArgs) Handles btnDevengar.Click
        Dim alu As Integer
        Dim alumno As New Alumno
        Dim monto As Decimal
        Dim monto2 As Decimal
        'Dim detalle As New DataGridView
        Dim devengacion As Integer
        Dim printername As String = ""
        Dim printDialog1 = New PrintDialog()
        Dim result As Integer
        Dim nroDev As String = ""
        Dim codigo As String = ""
        Dim pagoElectronico As String = ""

        alumnos = repoAlu.Traer_X_Sala(cbxCurso.SelectedValue, cbxTurno.Text)

        monto = repoDeveng.montoServicio(cbxServicio.SelectedValue)

        result = printDialog1.ShowDialog()

        If result = DialogResult.OK Then
            printername = printDialog1.PrinterSettings.PrinterName
        End If

        For Each alu In alumnos
            repoAlu.Traer_X_ID_activo(alu, alumno)
            If Not alumno.descuento = 0 Then
                monto2 = monto / 100 * (100 - Convert.ToDecimal(alumno.descuento))
            Else
                monto2 = monto
            End If
            pagoElectronico = "0000" + alumno.legajo.ToString
            devengacion = repoDeveng.Devengar_sala(alu, txt_observaciones.Text, cbxCuenta.Text, cbxServicio.Text, monto2, cbxMes.SelectedText.ToString)
            nroDev = devengacion.ToString
            nroDev = nroDev.PadLeft(8, "0")

            codigo = generarCodBarra(alumno.dni, devengacion, repoDeveng.Vencimiento1(devengacion))
            Dim objrep = Nothing
            If cbxVencimiento.SelectedIndex + 1 = 1 Then
                objrep = New rptDevengacion
            ElseIf cbxVencimiento.SelectedIndex + 1 = 2 Then
                objrep = New rptDevengacion2v
            ElseIf cbxVencimiento.SelectedIndex + 1 = 3 Then
                objrep = New rptDevengacion1v
            ElseIf cbxVencimiento.SelectedIndex + 1 = 4 Then
                objrep = New rptDevengacionsv
            Else
                objrep = New rptDevengacion
            End If

            Dim conexion As New cBaseDatos
            Dim SQL As String = String.Format("SELECT * FROM devengaciones WHERE dev_id = {0}; SELECT * FROM devengacionesdetalles WHERE dev_id = {1}", devengacion, devengacion)
            Dim DA As New MySqlClient.MySqlDataAdapter
            Dim DS As DataSet = New DataSet()
            Dim fecha As String
            Try
                conexion.AbrirConexion()
                DA = conexion.EjecutarConsulta(SQL)
                DA.Fill(DS)
                conexion.CerrarConexion()

                DS.Tables(0).TableName = "devengaciones"
                DS.Tables(1).TableName = "devengacionesdetalles"
                fecha = DS.Tables(0).Rows(0).ItemArray(6).ToString
                objrep.SetDataSource(DS)

                objrep.SetParameterValue(0, String.Format("{0}, {1}", alumno.apellido, alumno.nombre))
                objrep.SetParameterValue(1, cbxCurso.Text)
                objrep.SetParameterValue(2, cbxTurno.Text)
                objrep.SetParameterValue(3, nroDev)
                objrep.SetParameterValue(4, codigo)
                objrep.SetParameterValue(5, alumno.descuento.ToString)
                objrep.SetParameterValue(6, pagoElectronico)
                objrep.SetParameterValue(7, fecha)

                objrep.PrintOptions.PrinterName = printername
                objrep.PrintToPrinter(1, False, 0, 0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub CargarCuentas()
        DS = repoDeveng.Cuentas
        ' asignar el DataSource al combobox
        cbxCuenta.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuenta.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub CargarServicios()
        DS = repoDeveng.Servicios
        ' asignar el DataSource al combobox
        cbxServicio.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxServicio.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        'Cargar el monto del servicio !!!!!!!!!!!!!!Esto no me sale!!!!!!!!!!!!!!!!!!!!!!
        'txtMonto.Text = DS.Tables(0).Rows(2).ToString
        cbxServicio.ValueMember = DS.Tables(0).Columns(0).Caption.ToString
    End Sub
End Class