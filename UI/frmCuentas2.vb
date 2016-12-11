Public Class frmCuentas2
    Dim Editar As Boolean = False
    Public Cue As New Cuenta
    Public cueid As Integer

    Private Sub frmCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTipoCuenta(cboTipo)
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtNombre)
        EnableCmd(False, cmdGrabar)
    End Sub

    Private Sub frmLocalidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmAyuda.Dispose()
            Ayuda.LeerAyuda("frmcuentas")
            frmAyuda.Show()
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        If cmdSalir.Text = "&CANCELAR" Then
            ColorearBusqueda(True, txtNombre)
            cmdNuevo.Enabled = True
            cmdGrabar.Enabled = False
            EnableCmd(True, cmdNuevo)
            EnableCmd(False, cmdGrabar)
            EnableCmd(True, cmdBuscaNombre)
            cmdSalir.Text = "&SALIR"
            ColorearValidacion(False, lblNombre)
            ColorearValidacion(False, lblSaldo)
            ColorearValidacion(False, lblTipo)
            LimpiarControles(Me)
            Editar = False
            Cue.id = 0
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        LimpiarControles(Me)
        ColorearBusqueda(False, txtNombre)
        EnableCmd(False, cmdNuevo)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, cmdBuscaNombre)
        cmdSalir.Text = "&CANCELAR"
        txtNombre.Select()
        Editar = False
    End Sub

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        If Validar() Then
            EnableCmd(False, cmdGrabar)
            Dim repo = New RepoCuenta
            If chkActivo.Checked Then
                Cue.activo = Cts.Activo
            Else
                Cue.activo = Cts.Inactivo
            End If
            If chbxDevengaciones.Checked Then
                Cue.devengaciones = Cts.Activo
            Else
                Cue.devengaciones = Cts.Inactivo
            End If
            If chbxFacturaciones.Checked Then
                Cue.facturaciones = Cts.Activo
            Else
                Cue.facturaciones = Cts.Inactivo
            End If
            If chbxPagosDebe.Checked Then
                Cue.pagosDebe = Cts.Activo
            Else
                Cue.pagosDebe = Cts.Inactivo
            End If
            If chbxPagosHaber.Checked Then
                Cue.pagosHaber = Cts.Activo
            Else
                Cue.pagosHaber = Cts.Inactivo
            End If
            Cue.nombre = Trim(txtNombre.Text)
            Cue.saldo = Trim(txtSaldo.Text)
            Cue.codigo = Trim(txtCodigo.Text)
            Cue.grupo = Trim(cbxGrupo.SelectedIndex + 1)
            If Editar Then
                repo.Editar(Cue, False)
            Else
                repo.Agregar(Cue, False)
            End If
            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
            EnableCmd(True, cmdGrabar)
            LimpiarControles(Me)
            txtNombre.Select()
            cmdSalir.PerformClick()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim B As Boolean = True
        If txtNombre.Text = "" Then
            ColorearValidacion(True, lblNombre)
            B = False
        Else
            If Not Editar Then
                Dim repo = New RepoCuenta
                If repo.Existe(Trim(txtNombre.Text), False) Then
                    ColorearValidacion(True, lblNombre)
                    MsgBox(msgErrCodigoUsado, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
                    Return False
                End If
            End If
        End If
        If txtSaldo.Text = "" Then
            ColorearValidacion(True, lblSaldo)
            B = False
        End If
        If cboTipo.SelectedIndex = -1 Then
            ColorearValidacion(True, lblTipo)
            B = False
        End If
        Return B
    End Function

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If cmdNuevo.Enabled And txtNombre.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                cmdBuscaNombre.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmdBuscaNombre_Click(sender As Object, e As EventArgs) Handles cmdBuscaNombre.Click
        If txtNombre.Text <> "" Then
            cueid = 0
            Dim CuerpoSelect As String = "cue_id, cue_nombre, cue_nombre, cue_nombre"
            FormatoBusqueda("cuentas", CuerpoSelect, "cue_nombre", Trim(txtNombre.Text), False, "cue_id", "cue_nombre", cueid)
            frmBusqueda.ShowDialog()
            cueid = frmBusqueda.Codigo
            If cueid <> 0 Then
                Dim repo As New RepoCuenta
                If repo.Traer_X_codigo(cueid, Cue, False) Then
                    AcomodoCuenta()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldo.KeyPress
        If InStr("0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        Else
            If e.KeyChar = Chr(46) Then
                If InStr(txtSaldo.Text, ".") <> 0 Then
                    e.KeyChar = ""
                ElseIf txtSaldo.Text = "0" Or txtSaldo.Text = "" Then
                    txtSaldo.Text = "0."
                    txtSaldo.Select(2, 0)
                End If
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AcomodoCuenta()
        If Cue.activo = Activo Then Me.chkActivo.Checked = True
        If Cue.devengaciones = Cts.Activo Then Me.chbxDevengaciones.Checked = True
        If Cue.facturaciones = Cts.Activo Then Me.chbxFacturaciones.Checked = True
        If Cue.pagosDebe = Cts.Activo Then Me.chbxPagosDebe.Checked = True
        If Cue.pagosHaber = Cts.Activo Then Me.chbxPagosHaber.Checked = True
        txtCodigo.Text = Cue.codigo
        txtNombre.Text = Cue.nombre
        txtSaldo.Text = Cue.saldo
        cbxGrupo.Text = Cue.grupo
        'TODO
        'cboTipo.Text = Cue.tipo = Cue.tipo
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        Editar = True
        ColorearBusqueda(False, txtNombre)
        EnableCmd(False, cmdNuevo)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, cmdBuscaNombre)
        cmdSalir.Text = "&CANCELAR"
        cmdSalir.Select()
    End Sub

End Class