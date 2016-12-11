Public Class frmLocalidades

    Dim Editar As Boolean = False
    Public Loc As New Localidad

    Private Sub frmLocalidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmAyuda.Dispose()
            Ayuda.LeerAyuda("frmLocalidades")
            frmAyuda.Show()
        End If
    End Sub

    Private Sub frmLocalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtCodigo)
        ColorearBusqueda(True, txtNombre)
        EnableCmd(False, cmdGrabar)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        If cmdSalir.Text = "&CANCELAR" Then
            ColorearBusqueda(True, txtCodigo)
            ColorearBusqueda(True, txtNombre)
            cmdNuevo.Enabled = True
            cmdGrabar.Enabled = False
            EnableCmd(True, cmdNuevo)
            EnableCmd(False, cmdGrabar)
            EnableCmd(True, cmdBuscaCod)
            EnableCmd(True, cmdBuscaNombre)
            cmdSalir.Text = "&SALIR"
            ColorearValidacion(False, lblCodigo)
            ColorearValidacion(False, lblNombre)
            LimpiarControles(Me)
            Editar = False
            Loc.id = 0
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        LimpiarControles(Me)
        ColorearBusqueda(False, txtCodigo)
        ColorearBusqueda(False, txtNombre)
        EnableCmd(False, cmdNuevo)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, cmdBuscaCod)
        EnableCmd(False, cmdBuscaNombre)
        cmdSalir.Text = "&CANCELAR"
        txtCodigo.Select()
        Editar = False
    End Sub

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        If Validar() Then
            EnableCmd(False, cmdGrabar)
            Dim repo = New RepoLocalidad
            Loc.codigo = Trim(txtCodigo.Text)
            If chkActivo.Checked Then
                Loc.activo = Cts.Activo
            Else
                Loc.activo = Cts.Inactivo
            End If
            Loc.nombre = Trim(txtNombre.Text)
            If Editar Then
                repo.Editar(Loc)
            Else
                repo.Agregar(Loc)
            End If
            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + vbDefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)
            EnableCmd(True, cmdGrabar)
            LimpiarControles(Me)
            txtCodigo.Select()
            cmdSalir.PerformClick()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim B As Boolean = True
        If txtCodigo.Text = "" Then
            ColorearValidacion(True, lblCodigo)
            B = False
        Else
            If Not Editar Then
                Dim repo = New RepoLocalidad
                If repo.Existe(Trim(txtCodigo.Text)) Then
                    ColorearValidacion(True, lblCodigo)
                    MsgBox(msgErrCodigoUsado, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
                    Return False
                End If
            End If
        End If
        If txtNombre.Text = "" Then
            ColorearValidacion(True, lblNombre)
            B = False
        End If
        Return B
    End Function

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If cmdNuevo.Enabled And txtCodigo.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                cmdBuscaCod.PerformClick()
                e.Handled = True
            End If
        End If
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If cmdNuevo.Enabled And txtNombre.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                cmdBuscaNombre.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmdBuscaCod_Click(sender As Object, e As EventArgs) Handles cmdBuscaCod.Click
        Dim repo As New RepoLocalidad
        If repo.Traer_X_codigo(Trim(txtCodigo.Text), Loc) Then
            AcomodoLocalidad()
            AcomodoDespuesDeBusqueda()
        Else
            Dim msg As String = String.Format(msgErrBuscaCod, "localidad")
            MsgBox(msg, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, msgTitulo)
            txtCodigo.SelectAll()
        End If
    End Sub

    Private Sub cmdBuscaNombre_Click(sender As Object, e As EventArgs) Handles cmdBuscaNombre.Click
        If txtNombre.Text <> "" Then
            Loc.id = 0
            Dim CuerpoSelect As String = "loc_id, loc_codigo, ' ', loc_nombre"
            FormatoBusqueda("localidades", CuerpoSelect, "loc_nombre", Trim(txtNombre.Text), True, "loc_id", "loc_nombre", Loc.id)
            frmBusqueda.ShowDialog()
            Loc.id = frmBusqueda.Codigo
            Loc.nombre = frmBusqueda.Nombre
            frmBusqueda.Dispose()
            If Loc.id <> 0 Then
                Dim repo As New RepoLocalidad
                If repo.Traer_X_id(Loc.id, Loc) Then
                    AcomodoLocalidad()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub AcomodoLocalidad()
        txtNombre.Text = Loc.nombre
        txtCodigo.Text = Loc.codigo
        'TODO cuando esta activa me trae -1 en vez de 1 ver el sql despues
        If Loc.activo = Activo Then chkActivo.Checked = True
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        Editar = True
        ColorearBusqueda(False, txtCodigo)
        ColorearBusqueda(False, txtNombre)
        EnableCmd(False, cmdNuevo)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, cmdBuscaCod)
        EnableCmd(False, cmdBuscaNombre)
        cmdSalir.Text = "&CANCELAR"
        cmdSalir.Select()
    End Sub

End Class