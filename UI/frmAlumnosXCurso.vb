Public Class frmAlumnosXCurso

    Public sucursal As String
    Public db As Boolean

    Private Sub frmAlumnosXCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        CargarCursos(cbxCurso, db)
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        visRepAlumnosXCursos.idCurso = cbxCurso.SelectedItem(0)
        visRepAlumnosXCursos.turno = cbxTurno.SelectedItem().ToString
        visRepAlumnosXCursos.db = db
        If sucursal = "ZOO" Then
            visRepAlumnosXCursos.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepAlumnosXCursos.MdiParent = frmMainKSC
        End If
        visRepAlumnosXCursos.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class