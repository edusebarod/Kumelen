Public Class frmMaterias
    Dim Editar As Boolean = False
    Public Mat As New Materia
    Public sucursal As String

    Private Sub frmMaterias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmAyuda.Dispose()
            Ayuda.LeerAyuda("frmMaterias")
            frmAyuda.Show()
        End If
    End Sub

    Private Sub frmMaterias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Mat.id = 0
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
            Dim repo = New RepoMateria
            Mat.codigo = Trim(txtCodigo.Text)
            If chkActivo.Checked Then
                Mat.activo = Cts.Activo
            Else
                Mat.activo = Cts.Inactivo
            End If
            Mat.nombre = Trim(txtNombre.Text)
            If Editar Then
                Repo.Editar(Mat)
            Else
                Repo.Agregar(Mat)
            End If
            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
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
                Dim repo = New RepoMateria
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
        Dim repo As New RepoMateria
        If Repo.Traer_X_codigo(Trim(txtCodigo.Text), Mat) Then
            AcomodoMateria()
            AcomodoDespuesDeBusqueda()
        Else
            Dim msg As String = String.Format(msgErrBuscaCod, "materia")
            MsgBox(msg, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, msgTitulo)
            txtCodigo.SelectAll()
        End If
    End Sub

    Private Sub cmdBuscaNombre_Click(sender As Object, e As EventArgs) Handles cmdBuscaNombre.Click
        If txtNombre.Text <> "" Then
            Mat.id = 0
            Dim CuerpoSelect As String = "mat_id, mat_codigo, ' ', mat_nombre"
            FormatoBusqueda("materias", CuerpoSelect, "mat_nombre", Trim(txtNombre.Text), True, "mat_id", "mat_nombre", Mat.id)
            frmBusqueda.ShowDialog()
            If Mat.id <> 0 Then
                Dim repo As New RepoMateria
                If Repo.Traer_X_codigo(Mat.id, Mat) Then
                    AcomodoMateria()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub AcomodoMateria()
        txtNombre.Text = Mat.nombre
        txtCodigo.Text = Mat.codigo
        If Mat.activo = Activo Then chkActivo.Checked = True
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