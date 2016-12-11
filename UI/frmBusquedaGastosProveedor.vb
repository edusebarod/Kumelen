Public Class frmBusquedaGastosProveedor
    Public db As Boolean
    Public sucursal As String
    Private repoDN As New RepoDatosNegocio

    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        cargar_proveedores()
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
        visRepGastos.fecha1 = txt_fecha.Value.ToString("yyyy-MM-dd")
        visRepGastos.fecha2 = txt_y.Value.ToString("yyyy-MM-dd")
        visRepGastos.db = db
        visRepGastos.proveedor = cbxProveedor.SelectedItem(0)
        If sucursal = "ZOO" Then
            visRepGastos.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepGastos.MdiParent = frmMainKSC
        End If
        visRepGastos.Show()
    End Sub

    Private Sub cargar_proveedores()
        DS = repoDN.Traer_todos(db)
        ' asignar el DataSource al combobox
        cbxProveedor.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxProveedor.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub
End Class