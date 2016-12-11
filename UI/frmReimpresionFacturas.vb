Public Class frmReimpresionFacturas
    Public bd As Boolean
    Public sucursal As String

    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txt_inicio)
        'se define un punto de venta por defecto
        cbb_PtoVenta.SelectedItem = cbb_PtoVenta.Items(1)
    End Sub

    Private Sub txtNroFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_inicio.KeyPress
        If txt_inicio.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btn_NroFactura.PerformClick()
                e.Handled = True
            End If
        End If
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub btn_NroFactura_Click(sender As Object, e As EventArgs) Handles btn_NroFactura.Click
        If txt_inicio.Text <> "" Then
            frmReimpFacturas.PtoVenta = cbb_PtoVenta.SelectedItem
            frmReimpFacturas.NroFacturaInicial = txt_inicio.Text
            frmReimpFacturas.NroFacturaFinal = txt_final.Text
            frmReimpFacturas.bd = bd
            If sucursal = "ZOO" Then
                frmReimpFacturas.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                frmReimpFacturas.MdiParent = frmMainKSC
            End If
            frmReimpFacturas.Show()
        End If

    End Sub

    Private Sub btnVerTodos_Click(sender As Object, e As EventArgs) Handles btnVerTodos.Click
        'frmFacturas.todas = True
        'frmFacturas.MdiParent = frmMain
        'frmFacturas.Show()
    End Sub
End Class