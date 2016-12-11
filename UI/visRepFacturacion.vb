Public Class visRepFacturacion
    Public idFactura As Integer
    Public objrep As New CrystalReport1

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("select * from personas as p, alumnos as a, movimientos as m, movimientosdetalles as md where m.mov_id = {0} AND md.mov_id =  {1} AND m.per_id = p.per_id AND a.per_id = m.per_id", idFactura, idFactura)
        Dim SQL As String = String.Format("select p.per_apellido, p.per_nombre, md.mde_concepto, m.mov_total, m.mov_nro_factura, m.mov_fecha, m.mov_encargado  from personas as p, alumnos as a, movimientos as m, movimientosdetalles as md where m.mov_id = {0} AND md.mov_id =  {1} AND m.per_id = p.per_id AND a.per_id = m.per_id", idFactura, idFactura)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)

            objrep.SetDataSource(DS.Tables(0))
            
            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class