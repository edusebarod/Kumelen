Public Class frmReimpFacturas
    Public repoFact As New RepoFacturacion
    Public DS As New DataSet
    Public NroFacturaInicial As String
    Public NroFacturaFinal As String
    Public PtoVenta As String
    Public bd As Boolean



    Private Sub frmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n As Integer
        Dim nroFact As String

        ColorearControles(Me)
        ColorearFRM(Me)

        'se carga la lista de facturas
        If validar() Then
            n = NroFacturaFinal - NroFacturaInicial + 1
            For i As Integer = 0 To n - 1
                nroFact = (Convert.ToInt16(NroFacturaInicial) + i).ToString
                nroFact = nroFact.PadLeft(8, "0")
                DS.Merge(repoFact.Facturas_Nro_Factura(PtoVenta, nroFact))
            Next
            'Else
            '   DS = repoFact.Facturas()
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
        visRepDuplicadovía1.MdiParent = frmMain
        visRepDuplicadovía1.Show()
    End Sub

    Private Function validar() As Boolean
        Dim res As Boolean = False
        If (NroFacturaInicial <> "" And NroFacturaFinal <> "" And PtoVenta <> "") Then
            If Convert.ToInt16(NroFacturaFinal) >= Convert.ToInt16(NroFacturaInicial) Then
                res = True
            End If
        End If
        Return res
    End Function

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Dim printername As String = ""
        Dim printDialog1 = New PrintDialog()
        Dim objrep As New rptDuplicadosvia1
        Dim conexion As New cBaseDatos
        Dim Sql As String = ""
        Dim DS1 As New DataSet
        Dim DA As New MySqlClient.MySqlDataAdapter

        'El usuario elige en que impresora imprimir
        result = printDialog1.ShowDialog()

        If result = DialogResult.OK Then
            printername = printDialog1.PrinterSettings.PrinterName
        End If
        For Each row As DataGridViewRow In dgFacturas.Rows
            Try
                conexion.AbrirConexion(bd)
                'Se busca la facturación realizada, se carga el reporte y se lo manda a imprimir directamente
                Sql = String.Format("SELECT * FROM movimientos as m WHERE m.mov_id = {0}; SELECT * FROM movimientosdetalles as md WHERE md.mov_id = {1}", row.Cells(0).Value, row.Cells(0).Value)
                DA.Dispose()
                DS1.Clear()
                DS1.Dispose()
                DA = conexion.EjecutarConsulta(Sql)
                DA.Fill(DS1)
                conexion.CerrarConexion()

                DS1.Tables(0).TableName = "movimientos"
                DS1.Tables(1).TableName = "movimientosdetalles"
                fecha = DS1.Tables(0).Rows(0).ItemArray(4).ToString
                objrep.SetDataSource(DS1)

                objrep.SetParameterValue(0, row.Cells(1).Value.ToString)
                objrep.SetParameterValue(1, "teste")
                objrep.SetParameterValue(2, "01/02/2016")

                objrep.PrintOptions.PrinterName = printername
                objrep.PrintToPrinter(1, False, 0, 0)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next
    End Sub
End Class