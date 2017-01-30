Public Class frmBuscarAFacturasvia1
    Public sucursal As String

    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txt_nroFactura)
        ColorearBusqueda(True, txt_NombreAlumno)
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
        If txt_nroFactura.Text <> "" Then
            frmAnularFacturas.bd = True
            frmAnularFacturas.PtoVenta = cbb_PtoVenta.SelectedItem
            frmAnularFacturas.NroFactura = txt_nroFactura.Text
            If sucursal = "ZOO" Then
                frmAnularFacturas.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                frmAnularFacturas.MdiParent = frmMainKSC
            End If
            frmAnularFacturas.Show()
        End If
    End Sub

    Private Sub btn_Fecha_Click(sender As Object, e As EventArgs) Handles btn_Fecha.Click
        frmAnularFacturas.bd = True
        frmAnularFacturas.fecha1 = txt_fecha.Value
        frmAnularFacturas.fecha2 = txt_y.Value
        frmAnularFacturas.fecha = True
        If sucursal = "ZOO" Then
            frmAnularFacturas.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            frmAnularFacturas.MdiParent = frmMainKSC
        End If
        frmAnularFacturas.Show()
    End Sub

    Private Sub btn_Alumno_Click(sender As Object, e As EventArgs) Handles btn_Alumno.Click
        Dim res As Integer = 0
        If txt_NombreAlumno.Text <> "" Then
            Dim CuerpoSelect As String = "alu_legajo, alumnos.per_id, per_nombre, CONCAT(per_apellido, "", "", per_nombre) as nombre, per_dni"
            FormatoBusqueda("alumnos, personas", CuerpoSelect, "alumnos.per_id = personas.per_id AND per_apellido", Trim(txt_NombreAlumno.Text), True, "per_id", "nombre", res)
            frmBusqueda.ShowDialog()
            res = frmBusqueda.Codigo
            If res <> 0 Then
                frmAnularFacturas.id = res
                If sucursal = "ZOO" Then
                    frmAnularFacturas.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    frmAnularFacturas.MdiParent = frmMainKSC
                End If
                frmAnularFacturas.bd = True
                frmAnularFacturas.Show()
            End If
        End If
    End Sub

    Private Sub btnVerTodos_Click(sender As Object, e As EventArgs) Handles btnVerTodos.Click
        frmAnularFacturas.bd = True
        frmAnularFacturas.todas = True
        If sucursal = "ZOO" Then
            frmAnularFacturas.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            frmAnularFacturas.MdiParent = frmMainKSC
        End If
        frmAnularFacturas.Show()
    End Sub
End Class