Public Class frmServicios
    Dim Editar As Boolean = False
    Public Serv As New Servicio
    Public sucursal As String

    Private Sub frmServicios_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmAyuda.Dispose()
            Ayuda.LeerAyuda("frmServicios")
            frmAyuda.Show()
        End If
    End Sub
    Private Sub frmServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            EnableCmd(True, cmdNuevo)
            EnableCmd(False, cmdGrabar)
            EnableCmd(True, cmdBuscaNombre)
            EnableCmd(True, cmdBuscaCod)
            cmdSalir.Text = "&SALIR"
            ColorearValidacion(False, lblCodigo)
            ColorearValidacion(False, lblNombre)
            ColorearValidacion(False, lblPrecio)
            LimpiarControles(Me)
            Editar = False
            Serv.id = 0
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        If InStr("0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        Else
            If e.KeyChar = Chr(46) Then
                If InStr(txtPrecio.Text, ".") <> 0 Then
                    e.KeyChar = ""
                ElseIf txtPrecio.Text = "0" Or txtPrecio.Text = "" Then
                    txtPrecio.Text = "0."
                    txtPrecio.Select(2, 0)
                End If
                e.Handled = True
            End If
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
        Editar = False
        txtCodigo.Select()
    End Sub

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        If Validar() Then
            EnableCmd(False, cmdGrabar)
            Dim repo = New RepoServicio
            Serv.codigo = Trim(txtCodigo.Text)
            If chkActivo.Checked Then
                Serv.activo = Cts.Activo
            Else
                Serv.activo = Cts.Inactivo
            End If
            Serv.nombre = Trim(txtNombre.Text)
            Serv.observaciones = Trim(txtObse.Text)
            Serv.precio = txtPrecio.Text
            If Editar Then
                repo.Editar(Serv)
            Else
                repo.Agregar(Serv)
            End If
            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
            EnableCmd(True, cmdGrabar)
            LimpiarControles(Me)
            cmdSalir.PerformClick()
            txtCodigo.Select()
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
                Dim repo = New RepoServicio
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
        If txtPrecio.Text = "" Then
            ColorearValidacion(True, lblPrecio)
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

    Private Sub cmdBuscaNombre_Click(sender As Object, e As EventArgs) Handles cmdBuscaNombre.Click
        Serv.id = 0
        Dim CuerpoSelect As String = "serv_id, serv_codigo, serv_precio, serv_nombre"
        FormatoBusqueda("servicios", CuerpoSelect, "serv_nombre", Trim(txtNombre.Text), True, "serv_id", "serv_nombre", Serv.id)
        frmBusqueda.ShowDialog()
        Serv.id = frmBusqueda.Codigo
        If Serv.id <> 0 Then
            Dim repo As New RepoServicio
            If repo.Traer_X_codigo(Serv.id, Serv) Then
                AcomodoProducto()
                AcomodoDespuesDeBusqueda()
            End If
        Else
            txtNombre.Select()
        End If
    End Sub

    Private Sub cmdBuscaCod_Click(sender As Object, e As EventArgs) Handles cmdBuscaCod.Click
        Dim repo As New RepoServicio
        If repo.Traer_X_codigo(Trim(txtCodigo.Text), Serv) Then
            AcomodoProducto()
            AcomodoDespuesDeBusqueda()
        Else
            Dim msg As String = String.Format(msgErrBuscaCod, "servicio")
            MsgBox(msg, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, msgTitulo)
            txtCodigo.SelectAll()
        End If
    End Sub

    Private Sub AcomodoProducto()
        txtCodigo.Text = Serv.codigo
        If Serv.activo = Activo Then Me.chkActivo.Checked = True
        txtNombre.Text = Serv.nombre
        txtObse.Text = Serv.observaciones
        txtPrecio.Text = Serv.precio
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        Editar = True
        ColorearBusqueda(False, txtCodigo)
        ColorearBusqueda(False, txtNombre)
        EnableCmd(False, cmdNuevo)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, cmdBuscaNombre)
        EnableCmd(False, cmdBuscaCod)
        cmdSalir.Text = "&CANCELAR"
        cmdSalir.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        visRepServicios.db = True
        visRepServicios.tipo = 0
        If sucursal = "ZOO" Then
            visRepServicios.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepServicios.MdiParent = frmMainKSC
        End If
        visRepServicios.Show()
    End Sub
End Class