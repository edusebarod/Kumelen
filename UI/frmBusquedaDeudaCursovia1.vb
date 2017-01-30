Public Class frmBusquedaDeudaCursovia1
    Public sucursal As String

    Private Sub frmAlumnosInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        CargarCursos(cbxCurso)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        visRepDeudaCurso.curso = cbxCurso.SelectedValue
        visRepDeudaCurso.bd = True
        If sucursal = "ZOO" Then
            visRepDeudaCurso.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepDeudaCurso.MdiParent = frmMainKSC
        End If
        visRepDeudaCurso.Show()
    End Sub
End Class