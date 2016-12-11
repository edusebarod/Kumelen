Public Class frmFacturacionold2
    Public Alu As New Alumno
    Public Cta As New Cuenta
    Public Dev As New Devengacion
    Public repoFact As New RepoFacturacion
    'Public repoDeveng As New RepoDevengación
    Public DS As DataSet

    Private Sub frmFacturacion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotal.Text = "0"
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtDNI)
        ColorearBusqueda(True, txtApellido)
        EnableCmd(False, btnAdd)
        EnableCmd(False, btnDel)
        EnableCmd(False, btnFacturar)
        CargarCuentas()
        CargarServicios()
    End Sub
    Private Sub CargarCuentas()
        DS = repoFact.Cuentas(False)
        ' asignar el DataSource al combobox
        cbxCuenta.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuenta.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub CargarServicios()
        DS = repoFact.Servicios(False)
        ' asignar el DataSource al combobox
        cbxServicio.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxServicio.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validar() Then
            EnableCmd(False, btnAdd)
            dgDetalle.Rows.Add(cbxServicio.Text, txtMonto.Text, cbxCuenta.Text)
            EnableCmd(True, btnAdd)
            txtTotal.Text = CDbl(txtTotal.Text) + CDbl(txtMonto.Text)
            txtMonto.Clear()
            EnableCmd(True, btnDel)
            EnableCmd(True, btnFacturar)
            txtMonto.Select()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dgDetalle.RowCount > 0 Then
            txtTotal.Text = CDbl(txtTotal.Text) - CDbl(dgDetalle.CurrentRow.Cells(1).Value)
            dgDetalle.Rows.Remove(dgDetalle.CurrentRow)
        End If
        'Si no hay mas filas, se dehabilita el boton borrar
        If dgDetalle.RowCount = 0 Then
            EnableCmd(False, btnDel)
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
        If txtSala.Text = "" Then
            ColorearValidacion(True, lblSala)
            B = False
        End If
        'If txtMonto.Text = "" Then
        'ColorearValidacion(True, lblMonto)
        'B = False
        'End If
        If txtEncargado.Text = "" Then
            ColorearValidacion(True, lblEncargado)
            B = False
        End If
        Return B
    End Function

    Private Function validarfact() As Boolean
        Dim B As Boolean = True
        If Not validar() Then
            MsgBox("Faltan datos requeridos para facturar")
            B = False
        ElseIf dgDetalle.Rows.Count < 1 Then
            MsgBox("No hay elementos en el detalle de la factura")
            B = False
        End If
        Return B
    End Function

    Private Sub btnBuscaDNI_Click(sender As Object, e As EventArgs) Handles btnBuscaDNI.Click
        Dim repo As New RepoAlumno
        If repo.Traer_X_DNI(Trim(txtDNI.Text), Alu, False) Then
            AcomodoFactura()
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

    Private Sub btnBuscaApell_Click(sender As Object, e As EventArgs) Handles btnBuscaApell.Click
        If txtApellido.Text <> "" Then
            Alu.id() = 0
            Dim CuerpoSelect As String = "alu_legajo, per_nombre, per_dni, CONCAT(per_apellido, "", "", per_nombre) as nombre, personas.per_id"
            FormatoBusqueda("alumnos INNER JOIN personas ON personas.per_id = alumnos.per_id", CuerpoSelect, "per_apellido", Trim(txtApellido.Text), False, "per_id", "nombre", Alu.id)
            frmBusqueda.ShowDialog()
            Alu.id = frmBusqueda.Codigo
            Alu.apellido = frmBusqueda.Nombre
            frmBusqueda.Dispose()
            If Alu.id <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_ID_activo(Alu.id, Alu, False) Then
                    AcomodoFactura()
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
        txtSala.Text = repoFact.Curso(Alu.curso)
        seleccionarServicio(Alu)
        seleccionarCuenta()
        sugerirMonto()
        EnableCmd(True, btnAdd)
        EnableCmd(True, btnFacturar)
    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If txtMonto.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnAdd.PerformClick()
                e.Handled = True
            End If
        End If
        If InStr("0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        ElseIf e.KeyChar = Chr(46) Then
            If InStr(txtMonto.Text, ".") <> 0 Then
                e.KeyChar = ""
            ElseIf txtMonto.Text = "" Then
                txtMonto.Text = "0."
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub limpiarControles()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDNI.Clear()
        txtSala.Clear()
        txtMonto.Clear()
        txtEncargado.Clear()
        txtTotal.Clear()
        txtObservaciones.Clear()
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        If validarfact() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnFacturar)
                Dim factura As Integer
                factura = repoFact.Facturar(Alu.id, txtEncargado.Text, Convert.ToDouble(txtTotal.Text), "2", txtObservaciones.Text, txtSala.Text, dgDetalle, False)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnFacturar)

                txtApellido.Select()
                visRepFacturacion1.idFactura = factura
                visRepFacturacion1.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepFacturacion1.bd = False
                For Each dr As DataGridViewRow In dgDetalle.Rows
                    dgDetalle.Rows.Remove(dr)
                Next
                limpiarControles()
                visRepFacturacion1.MdiParent = frmMain
                visRepFacturacion1.Show()
            End If
        End If
    End Sub

    Private Sub seleccionarServicio(alu As Alumno)
        If alu.tipo = "Maternal" Then
            cbxServicio.SelectedIndex = 1
        End If
    End Sub

    Private Sub seleccionarCuenta()
        If cbxServicio.SelectedIndex() = 0 Or cbxServicio.SelectedIndex() = 1 Then
            cbxCuenta.SelectedIndex = 12
        End If
    End Sub

    Private Sub sugerirMonto()
        Dim monto As Double
        monto = repoFact.montoServicio(cbxServicio.SelectedValue(0), False)

        If Alu.descuento <> 0 Then
            monto = monto / 100 * Convert.ToDouble(Alu.descuento)
        End If
        txtMonto.Text = monto
    End Sub

End Class