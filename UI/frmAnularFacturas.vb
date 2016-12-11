Public Class frmAnularFacturas
    Public repofact As New RepoFacturacion
    Public alu As New Alumno
    Public repoAlumno As New RepoAlumno
    Public DS As DataSet
    Public NroFactura As String
    Public PtoVenta As String
    Public id As Integer
    Public fecha1 As Date
    Public fecha2 As Date
    Public fecha As Boolean 'true: se cargaron fecha1 y fecha2 False: estan vacias
    Public todas As Boolean

    Public idAlumno As Integer
    Public bd As Boolean



    Private Sub frmAnularFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearControles(Me)
        ColorearFRM(Me)
        'se carga la lista de facturas
        If (NroFactura <> "" And PtoVenta <> "") Then
            DS = repofact.Facturas_Nro_Factura(PtoVenta, NroFactura, bd)
        ElseIf (fecha) Then
            Dim fecha1_f As String
            fecha1_f = fecha1.ToString("yyyy-MM-dd hh:mm:ss")
            Dim fecha2_f As String
            fecha2_f = fecha2.ToString("yyyy-MM-dd hh:mm:ss")
            DS = repofact.Facturas_Fecha(fecha1_f, fecha2_f, bd)
        ElseIf (id <> 0) Then
            DS = repofact.Facturas_Alumno_id(id, bd)
        ElseIf todas Then
            DS = repofact.Facturas(bd)
        End If

        'se carga la lista de facturas
        'DS = repofact.Facturas_Alumno(idAlumno, bd)

        dgFacturas.DataSource = DS.Tables(0)

        'configuracion de la tabla que se muestra
        dgFacturas.Columns(0).HeaderText = "ID Factura"
        dgFacturas.Columns(1).HeaderText = "Pto Venta"
        dgFacturas.Columns(2).HeaderText = "Nro Factura"
        dgFacturas.Columns(3).HeaderText = "Fecha"
        dgFacturas.Columns(3).Width = 200
        dgFacturas.Columns(4).HeaderText = "Alumno"
        dgFacturas.Columns(5).HeaderText = "DNI"
        dgFacturas.Columns(6).HeaderText = "Total"

        'configuracion de los parametros del reporte, si se estan viendo todas las devengaciones no canceladas 
        'esta linea no tiene funcionalidad
        repoAlumno.Traer_X_ID_activo(idAlumno, alu, bd)
    End Sub

    Private Sub dgFacturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFacturas.CellDoubleClick
        'si idalumno = 0, entonces se estab viendo todas las devengaciones no canceladas y alu está vacío
        If idAlumno = 0 Then
            repoAlumno.Traer_X_DNI(dgFacturas.Rows(e.RowIndex).Cells(5).Value, alu, bd)
        End If
        repofact.Anula_Factura(dgFacturas.Rows(e.RowIndex).Cells(2).Value, dgFacturas.Rows(e.RowIndex).Cells(1).Value, bd)
        'repofact.Anular_Movimiento(Convert.ToInt32(dgFacturas.Rows(e.RowIndex).Cells(0).Value))
        MsgBox(Cts.msgFacturaAnulada)
        Me.Close()
    End Sub
End Class