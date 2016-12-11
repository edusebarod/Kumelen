Public Class frmBuscarDevengacionesvia1

    Public sucursal As String
    Public cantidadVencimientos As Integer

    Private Sub frmBuscarDevengaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearBusqueda(True, txt_NombreAlumno)
        ColorearBusqueda(True, txt_NroDevengacion)
        ColorearFRM(Me)
        'se define un punto de venta por defecto
    End Sub

    Private Sub btn_Alumno_Click(sender As Object, e As EventArgs) Handles btn_Alumno.Click
        If txt_NombreAlumno.Text <> "" Then
            Dim id As Integer = 0
            Dim CuerpoSelect As String = "alu_legajo, per_nombre, per_dni, CONCAT(per_apellido, "", "", per_nombre) as nombre, personas.per_id"
            FormatoBusqueda("alumnos INNER JOIN personas ON personas.per_id = alumnos.per_id", CuerpoSelect, "per_apellido", Trim(txt_NombreAlumno.Text), True, "per_id", "nombre", id)
            frmBusqueda.ShowDialog()
            id = frmBusqueda.Codigo
            frmBusqueda.Dispose()
            If id <> 0 Then
                frmDevengacionesNoCanceladas.idAlumno = id
                frmDevengacionesNoCanceladas.bd = True
                frmDevengacionesNoCanceladas.cantVencimientos = cantidadVencimientos
                If sucursal = "ZOO" Then
                    frmDevengacionesNoCanceladas.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    frmDevengacionesNoCanceladas.MdiParent = frmMainKSC
                End If
                frmDevengacionesNoCanceladas.Show()
            Else
                txt_NombreAlumno.Select()
            End If
        End If
    End Sub

    Private Sub txt_Nombre_Alumno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NombreAlumno.KeyPress
        If txt_NombreAlumno.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btn_Alumno.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnVerTodos_Click(sender As Object, e As EventArgs) Handles btnVerTodos.Click
        frmDevengacionesNoCanceladas.todas = True
        frmDevengacionesNoCanceladas.bd = True
        frmDevengacionesNoCanceladas.cantVencimientos = cantidadVencimientos
        frmDevengacionesNoCanceladas.MdiParent = frmMain
        frmDevengacionesNoCanceladas.Show()
    End Sub

    Private Sub btn_Fecha_Click(sender As Object, e As EventArgs) Handles btn_Fecha.Click
        frmDevengacionesNoCanceladas.fecha1 = txt_fecha.Value
        frmDevengacionesNoCanceladas.fecha2 = txt_y.Value
        frmDevengacionesNoCanceladas.fecha = True
        frmDevengacionesNoCanceladas.bd = True
        frmDevengacionesNoCanceladas.cantVencimientos = cantidadVencimientos
        If sucursal = "ZOO" Then
            frmDevengacionesNoCanceladas.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            frmDevengacionesNoCanceladas.MdiParent = frmMainKSC
        End If
        frmDevengacionesNoCanceladas.Show()
    End Sub

    Private Sub btn_NroDeveng_Click(sender As Object, e As EventArgs) Handles btn_NroDeveng.Click
        If txt_NroDevengacion.Text <> "" Then
            frmDevengacionesNoCanceladas.NroDeveng = txt_NroDevengacion.Text
            If sucursal = "ZOO" Then
                frmDevengacionesNoCanceladas.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                frmDevengacionesNoCanceladas.MdiParent = frmMainKSC
            End If
            frmDevengacionesNoCanceladas.bd = True
            frmDevengacionesNoCanceladas.cantVencimientos = cantidadVencimientos
            frmDevengacionesNoCanceladas.Show()
        End If
    End Sub

    Private Sub txt_NroDevengacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroDevengacion.KeyPress
        If txt_NroDevengacion.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btn_NroDeveng.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub
End Class