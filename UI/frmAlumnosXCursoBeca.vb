Public Class frmAlumnosXCursoBeca
    Public sucursal As String

    Private Sub frmAlumnosXCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        CargarCursos(cbxCurso)
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        visRepAlumnosXCursosBeca.idCurso = cbxCurso.SelectedItem(0)
        visRepAlumnosXCursosBeca.turno = cbxTurno.SelectedItem().ToString
        If sucursal = "ZOO" Then
            visRepAlumnosXCursosBeca.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepAlumnosXCursosBeca.MdiParent = frmMainKSC
        End If
        visRepAlumnosXCursosBeca.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class