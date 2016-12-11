Public Class frmBusquedaPagoMisCuentas
    Public db As Boolean
    Public sucursal As String


    Private Sub frmBuscarPagoaMisCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
    End Sub

    Private Sub txty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_y.KeyPress
        If txt_y.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btn_Fecha.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_Fecha_Click(sender As Object, e As EventArgs) Handles btn_Fecha.Click
        visRepPagoMisCuentas2.fecha1 = txt_fecha.Value.ToString("yyyy-MM-dd")
        visRepPagoMisCuentas2.fecha2 = txt_y.Value.ToString("yyyy-MM-dd")
        visRepPagoMisCuentas2.db = db
        If sucursal = "ZOO" Then
            visRepPagoMisCuentas2.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepPagoMisCuentas2.MdiParent = frmMainKSC
        End If
        visRepPagoMisCuentas2.Show()
    End Sub
End Class