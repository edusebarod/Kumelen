Public Class frmBuscarAGastoVia2
    Public sucursal As String

    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txt_nroComprobante)
        'se define un punto de venta por defecto
    End Sub

    Private Sub txtNroComprobante_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nroComprobante.KeyPress
        If txt_nroComprobante.Text <> "" Then
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

    Private Sub txty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_y.KeyPress
        If txt_y.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btn_Fecha.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_NroComprobante_Click(sender As Object, e As EventArgs) Handles btn_NroFactura.Click
        If txt_nroComprobante.Text <> "" Then
            frmAnularGastos.bd = False
            frmAnularGastos.NroComprobante = txt_nroComprobante.Text
            If sucursal = "ZOO" Then
                frmAnularGastos.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                frmAnularGastos.MdiParent = frmMainKSC
            End If
            frmAnularGastos.Show()
        End If

    End Sub

    Private Sub btn_Fecha_Click(sender As Object, e As EventArgs) Handles btn_Fecha.Click
        frmAnularGastos.bd = False
        frmAnularGastos.fecha1 = txt_fecha.Value
        frmAnularGastos.fecha2 = txt_y.Value
        frmAnularGastos.fecha = True
        If sucursal = "ZOO" Then
            frmAnularGastos.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            frmAnularGastos.MdiParent = frmMainKSC
        End If
        frmAnularGastos.Show()
    End Sub

    Private Sub btnVerTodos_Click(sender As Object, e As EventArgs) Handles btnVerTodos.Click
        frmAnularGastos.bd = False
        frmAnularGastos.todas = True
        If sucursal = "ZOO" Then
            frmAnularGastos.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            frmAnularGastos.MdiParent = frmMainKSC
        End If
        frmAnularGastos.Show()
    End Sub
End Class