Public Class VisRepFEAFIP

    Public fechaDesde As String
    Public fechaHasa As String
    'Public ds As DataSet
    Public objrep As New rptFEAFIP
    Public fecha1 As String
    Public fecha2 As String

    Private Sub VisRepFEAFIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT ""015"" as TipoComp, `mov_fecha` as FechaCom, ""0005"" as PtoVta, `mov_nro_factura` as NCompDesde, `mov_nro_factura` as NCompHasta, ""96"" as TipoDoc, `mov_encargado` as DNIPapa, `mov_total` as ImpTotalOp, ""0"" as ITCNING, ""0"" as ING, ""0"" as IL, ""0"" as ILRNI, `mov_total` as ImpOpExentas FROM `movimientos` WHERE `mov_pto_venta` = 2 AND `mov_fecha` BETWEEN '{0}' AND '{1}'", fecha1, fecha2)
        Dim SQL As String = String.Format("SELECT ""015"" as TipoComp, DATE_FORMAT(mov_fecha, '%Y-%m-%d') as FechaCom, ""0005"" as PtoVta, `mov_nro_factura` as NCompDesde, `mov_nro_factura` as NCompHasta, ""96"" as TipoDoc, `mov_encargado` as DNIPapa, `mov_total` as ImpTotalOp, ""0"" as ITCNING, ""0"" as ING, ""0"" as IL, ""0"" as ILRNI, `mov_total` as ImpOpExentas FROM `movimientos` WHERE `mov_pto_venta` = 2 AND `mov_fecha` BETWEEN '{0}' AND '{1}'", fecha1, fecha2)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "Facturas"

            objrep.SetDataSource(DS)

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class