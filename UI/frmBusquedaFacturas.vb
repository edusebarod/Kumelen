Public Class frmBuscarFacturas2
    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        'se define un punto de venta por defecto
        cbb_PtoVenta.SelectedItem = cbb_PtoVenta.Items(1)
    End Sub

    Private Sub txtNroFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nroFactura.KeyPress
        If txt_nroFactura.Text <> "" Then
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

    Private Sub txt_Alumno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NombreAlumno.KeyPress
        If txt_y.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btn_Alumno.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_NroFactura_Click(sender As Object, e As EventArgs) Handles btn_NroFactura.Click
        frmFacturas.PtoVenta = cbb_PtoVenta.SelectedItem
        frmFacturas.NroFactura = txt_nroFactura.Text
        frmFacturas.MdiParent = frmMain
        frmFacturas.Show()
    End Sub

    Private Sub btn_Fecha_Click(sender As Object, e As EventArgs) Handles btn_Fecha.Click
        frmFacturas.fecha1 = txt_fecha.Value
        frmFacturas.fecha2 = txt_y.Value
        frmFacturas.fecha = True
        frmFacturas.MdiParent = frmMain
        frmFacturas.Show()
    End Sub

    Private Sub btn_Alumno_Click(sender As Object, e As EventArgs) Handles btn_Alumno.Click
        frmFacturas.Alumno = txt_NombreAlumno.Text
        frmFacturas.MdiParent = frmMain
        frmFacturas.Show()
    End Sub
End Class