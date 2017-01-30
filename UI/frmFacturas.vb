Public Class frmFacturas
    Public repoFact As New RepoFacturacion
    Public DS As DataSet
    Public NroFactura As String
    Public PtoVenta As String
    Public id As Integer
    Public fecha1 As Date
    Public fecha2 As Date
    Public fecha As Boolean 'true: se cargaron fecha1 y fecha2 False: estan vacias
    Public todas As Boolean
    Public sucursal As String


    Private Sub frmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        'se carga la lista de facturas
        If (NroFactura <> "" And PtoVenta <> "") Then
            DS = repoFact.Facturas_Nro_Factura(PtoVenta, NroFactura)
        ElseIf (fecha) Then
            Dim fecha1_f As String
            fecha1_f = fecha1.ToString("yyyy-MM-dd hh:mm:ss")
            Dim fecha2_f As String
            fecha2_f = fecha2.ToString("yyyy-MM-dd hh:mm:ss")
            DS = repoFact.Facturas_Fecha(fecha1_f, fecha2_f)
        ElseIf (id <> 0) Then
            DS = repoFact.Facturas_Alumno_id(id)
        ElseIf todas Then
            DS = repoFact.Facturas()
        End If

        dgFacturas.DataSource = DS.Tables(0)

        'configuracion de la tabla que se muestra
        dgFacturas.Columns(0).HeaderText = "ID Factura"
        dgFacturas.Columns(1).HeaderText = "Pto Venta"
        dgFacturas.Columns(2).HeaderText = "Nro Factura"
        dgFacturas.Columns(3).HeaderText = "Fecha"
        dgFacturas.Columns(4).Width = 200
        dgFacturas.Columns(4).HeaderText = "Alumno"
        dgFacturas.Columns(5).HeaderText = "DNI"
        dgFacturas.Columns(6).HeaderText = "Total"

        'se resetean los atributos internos
        NroFactura = ""
        PtoVenta = ""
        fecha1 = ""
        fecha2 = ""
        'ColorearBusqueda(True, txtDNI)
        'ColorearBusqueda(True, txtApellido)
        'EnableCmd(False, btnFacturar)
        'asignar el DataSource al combobox
        'txtCuenta.DataSource = DS.Tables(0)
        'Asignar el campo a la propiedad DisplayMember del combo   
        'txtCuenta.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        
    End Sub

    Private Sub dgFacturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFacturas.CellDoubleClick
        'visRepFacturacion1.idFactura = dgFacturas.Rows(e.RowIndex).Cells(0).Value
        'visRepFacturacion1.alumno = dgFacturas.Rows(e.RowIndex).Cells(4).Value.ToString
        'visRepFacturacion1.MdiParent = frmMain
        'visRepFacturacion1.Show()
        visRepDuplicadovía1.idFactura = dgFacturas.Rows(e.RowIndex).Cells(0).Value
        visRepDuplicadovía1.alumno = dgFacturas.Rows(e.RowIndex).Cells(4).Value.ToString
        If sucursal = "ZOO" Then
            visRepDuplicadovía1.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepDuplicadovía1.MdiParent = frmMainKSC
        End If
        visRepDuplicadovía1.print = False
        visRepDuplicadovía1.Show()
    End Sub
End Class