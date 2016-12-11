Public Class frmCursosvia2
    Dim Editar As Boolean = False
    Public Cur As New Curso
    Public repoCur As New RepoCurso
    Public DS As DataSet
    Public sucursal As String

    Private Sub frmCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CargarTipoDocentes(cbxDocente)
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtNombre)
        EnableCmd(False, cmdGrabar)

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
            LimpiarControles(Me)
            Editar = False
            Cur.id = 0
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
        CargarDocentes()
        Editar = False
    End Sub

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        If Validar() Then
            EnableCmd(False, cmdGrabar)
            Dim repo = New RepoCurso
            Cur.docente = Trim(cbxDocente.SelectedItem(0))
            If chkActivo.Checked Then
                Cur.activo = Cts.Activo
            Else
                Cur.activo = Cts.Inactivo
            End If
            Cur.nombre = Trim(txtNombre.Text)
            Cur.anolectivo = Trim(txtAñoLectivo.Text)
            Cur.turno = Trim(txtTurno.Text)
            If Editar Then
                repo.Editar(Cur, False)
            Else
                repo.Agregar(Cur, False)
            End If
            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + vbDefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)
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
                Dim repo = New RepoCurso
                If repo.Existe(Trim(txtNombre.Text), False) Then
                    ColorearValidacion(True, lblNombre)
                    MsgBox(msgErrCodigoUsado, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
                    Return False
                End If
            End If
        End If
        Return B
    End Function

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If txtNombre.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                cmdBuscaNombre.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmdBuscaNombre_Click(sender As Object, e As EventArgs) Handles cmdBuscaNombre.Click
        If txtNombre.Text <> "" Then
            Cur.id = 0
            Dim CuerpoSelect As String = "cur_id, emp_id, cur_nombre, cur_anolectivo"
            FormatoBusqueda("cursos", CuerpoSelect, "cur_nombre", Trim(txtNombre.Text), False, "cur_id", "cur_nombre", Cur.id)
            frmBusqueda.ShowDialog()
            Cur.id = frmBusqueda.Codigo
            Cur.nombre = frmBusqueda.Nombre
            frmBusqueda.Dispose()
            If Cur.id <> 0 Then
                Dim repo As New RepoCurso
                If repo.Traer_X_id(Cur.id, Cur, False) Then
                    AcomodoCurso()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub AcomodoCurso()
        txtNombre.Text = Cur.nombre
        txtAñoLectivo.Text = Cur.anolectivo
        txtTurno.Text = Cur.turno
        CargarDocentes()
        cbxDocente.SelectedItem = cbxDocente.Items(buscaElemento(Cur.docente, cbxDocente))
        If Cur.activo = Activo Then chkActivo.Checked = True
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

    Private Sub CargarDocentes()
        DS = repoCur.Docentes(False)
        ' asignar el DataSource al combobox
        cbxDocente.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxDocente.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub cmdVerTodos_Click(sender As Object, e As EventArgs) Handles cmdVerTodos.Click
        visRepCursos.db = False
        If sucursal = "ZOO" Then
            visRepCursos.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepCursos.MdiParent = frmMainKSC
        End If
        visRepCursos.Show()
    End Sub
End Class