Public Class frmBuscarCDevengacionesvia2
    Private repoDeveng As New RepoDevengación
    Public sucursal As String

    Private Sub frmBuscarDevengaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearBusqueda(True, txt_NombreAlumno)
        ColorearBusqueda(True, txt_NroDevengacion)
        ColorearFRM(Me)
        'se define un punto de venta por defecto
    End Sub

    Private Sub btn_Alumno_Click(sender As Object, e As EventArgs) Handles btnBuscarAlumno.Click
        If txt_NombreAlumno.Text <> "" Then
            Dim id As Integer = 0
            Dim CuerpoSelect As String = "alu_legajo, per_nombre, per_dni, CONCAT(per_apellido, "", "", per_nombre) as nombre, personas.per_id"
            FormatoBusqueda("alumnos INNER JOIN personas ON personas.per_id = alumnos.per_id", CuerpoSelect, "per_apellido", Trim(txt_NombreAlumno.Text), False, "per_id", "nombre", id)
            frmBusqueda.ShowDialog()
            id = frmBusqueda.Codigo
            frmBusqueda.Dispose()
            If id <> 0 Then
                frmCambiarDevengaciones.idAlumno = id
                frmCambiarDevengaciones.bd = True
                If sucursal = "ZOO" Then
                    frmCambiarDevengaciones.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    frmCambiarDevengaciones.MdiParent = frmMainKSC
                End If
                frmCambiarDevengaciones.Show()
            Else
                txt_NombreAlumno.Select()
            End If
        End If
    End Sub

    Private Sub txt_Nombre_Alumno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NombreAlumno.KeyPress
        If txt_NombreAlumno.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscarAlumno.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnVerTodos_Click(sender As Object, e As EventArgs) Handles btnVerTodos.Click
        frmCambiarDevengaciones.idAlumno = 0
        frmCambiarDevengaciones.bd = True
        If sucursal = "ZOO" Then
            frmCambiarDevengaciones.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            frmCambiarDevengaciones.MdiParent = frmMainKSC
        End If
        frmCambiarDevengaciones.Show()
    End Sub

    Private Sub btnBuscarNroDevengacion_Click(sender As Object, e As EventArgs) Handles btnBuscarNroDevengacion.Click
        Dim id As Integer = 0
        If txt_NroDevengacion.Text <> "" Then
            id = repoDeveng.Id_persona(txt_NroDevengacion.Text)
            If id <> 0 Then
                frmAnularDevengacionesNoCanceladas.idAlumno = id
                frmAnularDevengacionesNoCanceladas.bd = True
                If sucursal = "ZOO" Then
                    frmAnularDevengacionesNoCanceladas.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    frmAnularDevengacionesNoCanceladas.MdiParent = frmMainKSC
                End If
                frmAnularDevengacionesNoCanceladas.Show()
            Else
                txt_NombreAlumno.Select()
            End If
        End If
    End Sub

    Private Sub txt_NroDevengacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroDevengacion.KeyPress
        If txt_NroDevengacion.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscarNroDevengacion.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

End Class