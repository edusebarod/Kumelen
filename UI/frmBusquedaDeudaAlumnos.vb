Public Class frmBusquedaDeudaAlumnos
    Dim Editar As Boolean = False
    Public repoAlu As New RepoAlumno
    Public Alu As New Alumno
    Public DS As DataSet

    Private Sub frmAlumnosInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtLegajo)
        ColorearBusqueda(True, txtDNI)
        ColorearBusqueda(True, txtApellido)
        EnableCmd(False, cmdVer)
    End Sub

    Private Sub frmAlumnos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmAyuda.Dispose()
            Ayuda.LeerAyuda("frmAlumnos")
            frmAyuda.Show()
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnBuscaApell_Click(sender As Object, e As EventArgs) Handles btnBuscaApell.Click
        If txtApellido.Text <> "" Then
            Alu.id() = 0
            Dim CuerpoSelect As String = "alu_legajo, alumnos.per_id, per_nombre, CONCAT(per_apellido, "", "", per_nombre) as nombre, per_dni"
            FormatoBusqueda("alumnos, personas", CuerpoSelect, "alumnos.per_id = personas.per_id AND per_apellido", Trim(txtApellido.Text), True, "per_id", "nombre", Alu.id)
            frmBusqueda.ShowDialog()
            Alu.id = frmBusqueda.Codigo
            If Alu.id <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_ID(Alu.id, Alu) Then
                    AcomodoAlumno()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If txtApellido.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscaApell.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnBuscaLeg_Click(sender As Object, e As EventArgs) Handles btnBuscaLeg.Click
        If txtLegajo.Text <> "" Then
            Alu.id() = 0
            Dim CuerpoSelect As String = "alu_legajo, alumnos.per_id, per_nombre, per_apellido, per_dni"
            FormatoBusqueda("alumnos, personas", CuerpoSelect, "alumnos.per_id = personas.per_id AND alu_legajo", Trim(txtLegajo.Text), True, "alu_legajo", "per_apellido", Alu.id)
            frmBusqueda.ShowDialog()
            Alu.id = frmBusqueda.Codigo
            If Alu.id <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_Legajo(Alu.id, Alu) Then
                    AcomodoAlumno()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtLegajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLegajo.KeyPress
        If txtLegajo.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscaLeg.PerformClick()
                e.Handled = True
            End If
        End If
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscaDNI_Click(sender As Object, e As EventArgs) Handles btnBuscaDNI.Click
        If txtLegajo.Text <> "" Then
            Alu.id() = 0
            Dim CuerpoSelect As String = "alu_legajo, alumnos.per_id, per_nombre, per_apellido, per_dni"
            FormatoBusqueda("alumnos, personas", CuerpoSelect, "alumnos.per_id = personas.per_id AND per_dni", Trim(txtLegajo.Text), True, "alu_legajo", "per_apellido", Alu.id)
            frmBusqueda.ShowDialog()
            Alu.id = frmBusqueda.Codigo
            If Alu.id <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_DNI(Alu.dni, Alu) Then
                    AcomodoAlumno()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If txtDNI.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscaLeg.PerformClick()
                e.Handled = True
            End If
        End If
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub AcomodoAlumno()
        Dim edad As Integer
        txtLegajo.Text = Alu.legajo
        txtNombre.Text = Alu.nombre
        txtApellido.Text = Alu.apellido
        txtDNI.Text = Alu.dni
        edad = Calcular_Edad(Alu.fechanacimiento)
        CargarCursos(cbxCurso)
        cbxCurso.SelectedItem = cbxCurso.Items(buscaElemento(Alu.curso, cbxCurso))
        If Trim(txtDescuento.Text) = "" Then
            Alu.descuento = 0
        Else
            Alu.descuento = System.Convert.ToDecimal(Trim(txtDescuento.Text))
        End If
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        Editar = True
        ColorearBusqueda(False, txtLegajo)
        ColorearBusqueda(False, txtDNI)
        ColorearBusqueda(False, txtApellido)
        EnableCmd(True, cmdVer)
        cmdSalir.Select()
    End Sub

    Private Function Validar() As Boolean
        Dim B As Boolean = True
        If txtLegajo.Text = "" Then
            ColorearValidacion(True, lblLegajo)
            B = False
        Else
            If Not Editar Then
                Dim repo = New RepoAlumno
                If repo.Existe(Trim(txtLegajo.Text)) Then
                    ColorearValidacion(True, lblLegajo)
                    MsgBox(msgErrLegajoUsado, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
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

    Private Sub txtTiempo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub txtAnoLectivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub cmdVer_Click(sender As Object, e As EventArgs) Handles cmdVer.Click
        If Validar() Then
            frmDevengacionesD.idAlumno = Alu.id
            frmDevengacionesD.MdiParent = MdiParent
            frmDevengacionesD.Show()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub
End Class