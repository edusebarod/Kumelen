Public Class frmAyuda

    Private Sub frmAyuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtayuda.Text = Ayuda.textoAyuda
        txtayuda.Select(0, 0)
    End Sub
End Class