Public Class frmAnularGastos
    Public repofact As New RepoFacturacion
    Public DS As DataSet
    Public NroComprobante As String
    Public fecha1 As Date
    Public fecha2 As Date
    Public fecha As Boolean 'true: se cargaron fecha1 y fecha2 False: estan vacias
    Public todas As Boolean
    Public bd As Boolean



    Private Sub frmAnularFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearControles(Me)
        ColorearFRM(Me)

        'se carga la lista de gastos
        If (NroComprobante <> "") Then
            DS = repofact.Gastos_Nro_Comprobante(NroComprobante, bd)
        ElseIf (fecha) Then
            Dim fecha1_f As String
            fecha1_f = fecha1.ToString("yyyy-MM-dd hh:mm:ss")
            Dim fecha2_f As String
            fecha2_f = fecha2.ToString("yyyy-MM-dd hh:mm:ss")
            DS = repofact.Gastos_Fecha(fecha1_f, fecha2_f, bd)
        ElseIf todas Then
            DS = repofact.Gastos(bd)
        End If

        dgGastos.DataSource = DS.Tables(0)

        'configuracion de la tabla que se muestra
        dgGastos.Columns(0).HeaderText = "ID Factura"
        dgGastos.Columns(1).HeaderText = "Nro Factura"
        dgGastos.Columns(2).HeaderText = "Fecha"
        dgGastos.Columns(3).HeaderText = "Concepto"
        dgGastos.Columns(3).Width = 200
        dgGastos.Columns(4).HeaderText = "Proveedor"
        dgGastos.Columns(5).HeaderText = "Total"
    End Sub

    Private Sub dgFacturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGastos.CellDoubleClick
        repofact.Anula_GastoXid(dgGastos.Rows(e.RowIndex).Cells(0).Value, bd)
        'repofact.Anular_Movimiento(Convert.ToInt32(dgFacturas.Rows(e.RowIndex).Cells(0).Value))
        MsgBox(Cts.msgFacturaAnulada)
        Me.Close()
    End Sub
End Class