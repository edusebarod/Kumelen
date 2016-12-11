Public Class frmFacturacionVia1old
    Public Alu As New Alumno
    Public Cta As New Cuenta
    Public repoFact As New RepoFacturacion
    Public DS As DataSet

    Private Sub frmFacturacionVia1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtDNI)
        ColorearBusqueda(True, txtApellido)
        EnableCmd(False, btnFacturar)
        CargarCuentas()
        CargarServicios()
    End Sub


    Private Sub btnBuscaApell_Click(sender As Object, e As EventArgs) Handles btnBuscaApell.Click
        If txtApellido.Text <> "" Then
            Alu.id() = 0
            Dim CuerpoSelect As String = "alu_legajo, per_nombre, per_dni, per_apellido, personas.per_id"
            FormatoBusqueda("alumnos INNER JOIN personas ON personas.per_id = alumnos.per_id", CuerpoSelect, "per_apellido", Trim(txtApellido.Text), False, "per_id", "per_apellido", Alu.id)
            frmBusqueda.ShowDialog()
            Alu.id = frmBusqueda.Codigo
            Alu.apellido = frmBusqueda.Nombre
            frmBusqueda.Dispose()
            If Alu.id <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_ID_activo(Alu.id, Alu) Then
                    AcomodoFactura()
                    AcomodoDespuesDeBusqueda()
                    txtMonto.Select()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtapellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If txtApellido.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscaApell.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AcomodoFactura()
        'TODO verificar que el alumno este activo
        txtNombre.Text = Alu.nombre
        txtApellido.Text = Alu.apellido
        txtDNI.Text = Alu.dni
        txtSala.Text = traersala(Alu.curso)
        seleccionarServicio(Alu)
        seleccionarcuenta()
        sugerirmonto()
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        EnableCmd(True, btnFacturar)
        btnFacturar.Select()
    End Sub

    Private Sub CargarCuentas()
        DS = repoFact.Cuentas
        ' asignar el DataSource al combobox
        cbxCuenta.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuenta.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub CargarServicios()
        DS = repoFact.Servicios
        ' asignar el DataSource al combobox
        cbxServicio.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxServicio.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        'Cargar el monto del servicio !!!!!!!!!!!!!!Esto no me sale!!!!!!!!!!!!!!!!!!!!!!
        txtMonto.Text = DS.Tables(0).Rows(2).ToString
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnBuscaDNI_Click(sender As Object, e As EventArgs) Handles btnBuscaDNI.Click
        Dim repo As New RepoAlumno
        If repo.Traer_X_DNI(Trim(txtDNI.Text), Alu) Then
            AcomodoFactura()
            AcomodoDespuesDeBusqueda()
            txtMonto.Select()
        Else
            Dim msg As String = String.Format(msgErrBuscaCod, "facturacion")
            MsgBox(msg, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, msgTitulo)
            txtDNI.SelectAll()
        End If
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If txtDNI.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscaDNI.PerformClick()
                e.Handled = True
            End If
        End If
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        If validar() Then
            EnableCmd(False, btnFacturar)
            Dim repo = New RepoFacturacion
            Dim factura As Integer

            'factura = repo.Facturar(Alu.id, txtEncargado.Text, Cta.saldo, txtMonto.Text, cbxServicio.SelectedItem(0), txtObservaciones.Text)
            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

            EnableCmd(True, btnFacturar)
            LimpiarControles(Me)
            txtApellido.Select()
            visRepFacturacion1.idFactura = factura
            visRepFacturacion1.MdiParent = frmMain
            visRepFacturacion1.Show()

        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Function validar() As Boolean
        Dim B As Boolean = True
        If txtApellido.Text = "" Then
            ColorearValidacion(True, lblApellido)
            B = False
        End If
        If txtNombre.Text = "" Then
            ColorearValidacion(True, lblNombre)
            B = False
        End If
        If txtEncargado.Text = "" Then
            ColorearValidacion(True, lblEncargado)
            B = False
        End If
        If txtMonto.Text = "" Then
            ColorearValidacion(True, lblMonto)
            B = False
        End If
        If txtEncargado.Text = "" Then
            ColorearValidacion(True, lblEncargado)
            B = False
        End If
        Return B
    End Function

    'Solo permite el ingreso de caracteres numéricos en el campo txtMonto
    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If InStr("0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        Else
            If e.KeyChar = Chr(46) Then
                If InStr(txtMonto.Text, ".") <> 0 Then
                    e.KeyChar = ""
                ElseIf txtMonto.Text = "0" Or txtMonto.Text = "" Then
                    txtMonto.Text = "0."
                    txtMonto.Select(2, 0)
                End If
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub seleccionarServicio(alu As Alumno)
        If alu.tipo = "Primario" Then
            cbxServicio.SelectedIndex = 1
        ElseIf alu.tipo = "Inicial" Then
            cbxServicio.SelectedIndex = 0
        End If
    End Sub

    Private Sub seleccionarCuenta()
        If cbxServicio.SelectedIndex() = 0 Or cbxServicio.SelectedIndex() = 1 Then
            cbxCuenta.SelectedIndex = 12
        End If
    End Sub

    Private Sub sugerirMonto()
        Dim monto As Double
        monto = repoFact.montoServicio(cbxServicio.SelectedIndex() + 1)

        If Alu.descuento <> 0 Then
            monto = monto / 100 * Convert.ToDouble(Alu.descuento)
        End If
        txtMonto.Text = monto
    End Sub
End Class