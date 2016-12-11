Imports System.Security.Cryptography

Public Class frmUsuarios
    Public User As New Usuario
    Dim Editar As Boolean = False

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtNombre)
        ColorearBusqueda(True, txtLogin)
        EnableCmd(False, cmdGrabar)
    End Sub

    Private Function Validar() As Boolean
        Dim B As Boolean = True
        If Trim(txtNombre.Text) = "" Then
            B = False
            ColorearValidacion(True, lblNombre)
        End If
        If Trim(txtLogin.Text) = "" Then
            B = False
            ColorearValidacion(True, lblLogin)
        Else
            If Not Editar Then
                Dim repo = New RepoUsuario
                If repo.Existe(Trim(txtLogin.Text)) Then
                    ColorearValidacion(True, lblLogin)
                    MsgBox(msgErrCodigoUsado, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
                    Return False
                End If
            End If
        End If
        If cboTipo.Text = "" Then
            B = False
            ColorearValidacion(True, lblTipo)
        End If
        If Trim(txtClave.Text) <> Trim(txtClaveRe.Text) Or Trim(txtClave.Text) = "" Then
            B = False
            ColorearValidacion(True, lblClave)
            ColorearValidacion(True, lblClaveRe)
        End If
        Return B
    End Function

    Private Sub frmProductos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmAyuda.Dispose()
            Ayuda.LeerAyuda("frmUsuarios")
            frmAyuda.Show()
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        If cmdSalir.Text = "&CANCELAR" Then
            ColorearBusqueda(True, txtLogin)
            ColorearBusqueda(True, txtNombre)
            cmdNuevo.Enabled = True
            cmdGrabar.Enabled = False
            EnableCmd(True, cmdNuevo)
            EnableCmd(False, cmdGrabar)
            EnableCmd(True, cmdBuscaNombre)
            EnableCmd(True, cmdBuscaLogin)
            cmdSalir.Text = "&SALIR"
            ColorearValidacion(False, lblLogin)
            ColorearValidacion(False, lblTipo)
            ColorearValidacion(False, lblClave)
            ColorearValidacion(False, lblNombre)
            ColorearValidacion(False, lblClaveRe)
            LimpiarControles(Me)
            Editar = False
            User.id = 0
        Else
            Me.Dispose()
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

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Editar = False
        LimpiarControles(Me)
        ColorearBusqueda(False, txtNombre)
        ColorearBusqueda(False, txtLogin)
        EnableCmd(False, cmdNuevo)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, cmdBuscaLogin)
        EnableCmd(False, cmdBuscaNombre)
        cmdSalir.Text = "&CANCELAR"
    End Sub

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        If Validar() Then
            EnableCmd(False, cmdGrabar)
            Dim repo = New RepoUsuario
            If chkActivo.Checked Then
                User.activo = Activo
            Else
                User.activo = Inactivo
            End If
            User.nombre = Trim(txtNombre.Text)
            User.obse = Trim(txtObse.Text)
            User.login = Trim(txtLogin.Text)
            'TODO ver el tema de la encriptacion
            'User.pass = MD5(Trim(txtlogin.Text) & Trim(txtClave.Text))
            'TODO como hacemos con esto? que guardamos? para que?
            User.tipo = cboTipo.Text
            If Editar Then
                repo.Editar(User)
            Else
                repo.Agregar(User)
            End If
            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
            EnableCmd(True, cmdGrabar)
            LimpiarControles(Me)
            cmdSalir.PerformClick()
            txtNombre.Select()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Sub cmdBuscaNombre_Click(sender As Object, e As EventArgs) Handles cmdBuscaNombre.Click
        User.id = 0
        Dim CuerpoSelect As String = "user_nombre, ' ', user_login"
        FormatoBusqueda("usuarios", CuerpoSelect, "user_nombre", Trim(txtNombre.Text), True, "user_id", "user_nombre", User.id)
        frmBusqueda.ShowDialog()
        If User.id <> 0 Then
            Dim repo As New RepoUsuario
            If repo.Traer_X_codigo(User.id, User) Then
                AcomodoUsuario()
                AcomodoDespuesDeBusqueda()
            End If
        Else
            txtNombre.Select()
        End If
    End Sub

    Private Sub cmdBuscaLogin_Click(sender As Object, e As EventArgs) Handles cmdBuscaLogin.Click
        User.id = 0
        Dim CuerpoSelect As String = "user_login, ' ', user_nombre"
        FormatoBusqueda("usuarios", CuerpoSelect, "user_login", Trim(txtNombre.Text), True, "user_id", "user_login", User.id)
        frmBusqueda.ShowDialog()
        If User.id <> 0 Then
            Dim repo As New RepoUsuario
            If repo.Traer_X_codigo(User.id, User) Then
                AcomodoUsuario()
                AcomodoDespuesDeBusqueda()
            End If
        Else
            txtNombre.Select()
        End If
    End Sub

    Private Sub txtLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLogin.KeyPress
        If cmdNuevo.Enabled And txtLogin.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                cmdBuscaLogin.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AcomodoUsuario()
        If User.activo = Activo Then Me.chkActivo.Checked = True
        txtNombre.Text = User.nombre
        txtObse.Text = User.obse
        txtLogin.Text = User.login
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        Editar = True
        ColorearBusqueda(False, txtLogin)
        ColorearBusqueda(False, txtNombre)
        EnableCmd(False, cmdNuevo)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, cmdBuscaNombre)
        EnableCmd(False, cmdBuscaLogin)
        cmdSalir.Text = "&CANCELAR"
        cmdSalir.Select()
    End Sub
End Class

