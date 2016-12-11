Public Class frmFacturas2
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
            DS = repoFact.Facturas_Nro_Factura(PtoVenta, NroFactura, False)
        ElseIf (fecha) Then
            Dim fecha1_f As String
            fecha1_f = fecha1.ToString("yyyy-MM-dd hh:mm:ss")
            Dim fecha2_f As String
            fecha2_f = fecha2.ToString("yyyy-MM-dd hh:mm:ss")
            DS = repoFact.Facturas_Fecha(fecha1_f, fecha2_f, False)
        ElseIf (id <> 0) Then
            DS = repoFact.Facturas_Alumno_id(id, False)
        ElseIf todas Then
            DS = repoFact.Facturas(False)
        End If

        dgFacturas.DataSource = DS.Tables(0)

        'configuracion de la tabla que se muestra
        'dgFacturas.Columns(0).HeaderText = "ID Factura"
        'dgFacturas.Columns(1).HeaderText = "Nº de Factura"
        'dgFacturas.Columns(2).HeaderText = "Fecha"
        'dgFacturas.Columns(3).HeaderText = "Alumno"
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
        visRepFacturacionvia2.idFactura = dgFacturas.Rows(e.RowIndex).Cells(0).Value
        If sucursal = "ZOO" Then
            visRepDuplicadovía2.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepDuplicadovía2.MdiParent = frmMainKSC
        End If
        visRepFacturacionvia2.Show()
    End Sub
End Class