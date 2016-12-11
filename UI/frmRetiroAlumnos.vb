Public Class frmRetiroAlumnos
    Public sucursal As String
    Private Editar As Boolean = False
    Private IDalumno As Integer = 0

    Private Sub frmRetiroAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtLegajo)
        ColorearBusqueda(True, txtNombre)
        ColorearBusqueda(True, txtApellido)
        EnableCmd(False, cmdAgregar)
        EnableCmd(False, cmdQuitar)
    End Sub

    Private Sub frmRetiroAlumnos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmAyuda.Dispose()
            Ayuda.LeerAyuda("frmRetiroAlumnos")
            frmAyuda.Show()
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        If cmdSalir.Text = "&CANCELAR" Then
            ColorearBusqueda(True, txtLegajo)
            ColorearBusqueda(True, txtNombre)
            ColorearBusqueda(True, txtApellido)
            EnableCmd(True, cmdBuscaNombre)
            EnableCmd(True, cmdBuscaLegajo)
            EnableCmd(True, cmdBuscaApellido)
            EnableCmd(False, cmdAgregar)
            EnableCmd(False, cmdQuitar)
            cmdSalir.Text = "&SALIR"
            LimpiarControles(Me)
            Editar = False
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Editar And txtNombre.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                cmdBuscaNombre.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtLegajo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLegajo.KeyPress
        If Not Editar And txtLegajo.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                cmdBuscaLegajo.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Not Editar And txtApellido.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                cmdBuscaApellido.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmdBuscaLegajo_Click(sender As Object, e As EventArgs) Handles cmdBuscaLegajo.Click
        'TODO cuando hagamos el repoalumno
        'Dim repo As New repoalumno
        'If Repo.Traer_X_codigo(Trim(txtLegajo.Text), Prod) Then
        '    AcomodoAlumno()
        '    AcomodoDespuesDeBusqueda()
        'Else
        '    Dim msg As String = String.Format(msgErrBuscaCod, "alumno")
        '    MsgBox(msg, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, msgTitulo)
        '    txtLegajo.SelectAll()
        'End If
    End Sub

    Private Sub cmdBuscaNombre_Click(sender As Object, e As EventArgs) Handles cmdBuscaNombre.Click
        'TODO cuando hagamos el repoalumno
    End Sub

    Private Sub cmdBuscaApellido_Click(sender As Object, e As EventArgs) Handles cmdBuscaApellido.Click
        'TODO cuando hagamos el repoalumno
    End Sub

    Private Sub AcomodoAlumno()
        'TODO acomodar los nombres cuadno definamos el repoalumno o algo de eso
        CargarRetiros()
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        Editar = True
        ColorearBusqueda(False, txtLegajo)
        ColorearBusqueda(False, txtNombre)
        ColorearBusqueda(False, txtApellido)
        EnableCmd(False, cmdBuscaNombre)
        EnableCmd(False, cmdBuscaLegajo)
        EnableCmd(False, cmdBuscaApellido)
        EnableCmd(True, cmdAgregar)
        EnableCmd(True, cmdQuitar)
        cmdSalir.Text = "&CANCELAR"
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If Validar() Then
            Dim repo As New RepoRetiroAlumno
            repo.Agregar(IDalumno, Trim(txtNewNombre.Text), Trim(txtNewApellido.Text), Trim(txtNewVinculo.Text))
            txtNewApellido.Text = ""
            txtNewNombre.Text = ""
            txtNewVinculo.Text = ""
            cmdSalir.Focus()
        End If
    End Sub

    Private Function Validar() As Boolean
        If Trim(txtNewApellido.Text) = "" Or Trim(txtNewNombre.Text) = "" Or Trim(txtNewVinculo.Text) = "" Then Return False
        Return True
    End Function

    Private Sub CargarRetiros()
        lstRetiros.Items.Clear()
        Dim repo As New RepoRetiroAlumno
        Dim DS As DataSet = repo.TraerRetiros(IDalumno)
        lstRetiros.DataSource = DS.Tables(0)
        lstRetiros.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString()
        lstRetiros.ValueMember = DS.Tables(0).Columns(0).Caption.ToString()
    End Sub

    Private Sub cmdQuitar_Click(sender As Object, e As EventArgs) Handles cmdQuitar.Click
        If lstRetiros.SelectedIndex <> -1 Then
            Dim repo As New RepoRetiroAlumno
            repo.QuitarRetiro(lstRetiros.SelectedValue)
        End If
    End Sub

End Class