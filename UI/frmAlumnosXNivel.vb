Public Class frmAlumnosXNivel
    Public sucursal As String

    Private Sub frmAlumnosXCNivel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        CargarNiveles(cbxNivel, False)
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        visRepAlumnosXNivel.Nivel = cbxNivel.SelectedItem().ToString
        If sucursal = "ZOO" Then
            visRepAlumnosXNivel.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepAlumnosXNivel.MdiParent = frmMainKSC
        End If
        visRepAlumnosXNivel.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class