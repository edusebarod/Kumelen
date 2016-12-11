Public Class frmBuscarMovimientos
    Public repoFact As New RepoFacturacion
    Public bd As Boolean
    Public sucursal As String

    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        visRepBuscarMovimientos.bd = True
        visRepBuscarMovimientos.fechadesde = txt_fecha.Value
        visRepBuscarMovimientos.fechahasta = txt_y.Value
        visRepBuscarMovimientos.Show()
    End Sub

End Class