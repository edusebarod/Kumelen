Public Class visRepFacturacionvia2
    Public idFactura As Integer
    Public alumno As String
    Public sala As String
    Public objrep As New rptFacturacionvia2
    Public bd As New Boolean
    Public print As Boolean

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("select * from personas as p, alumnos as a, movimientos as m, movimientosdetalles as md where m.mov_id = {0} AND md.mov_id =  {1} AND m.per_id = p.per_id AND a.per_id = m.per_id", idFactura, idFactura)
        Dim SQL As String = String.Format("SELECT m.mov_encargado, CONVERT(m.mov_fecha, CHAR) as mov_fecha, m.mov_total, m.mov_pto_venta, m.mov_nro_factura, m.mov_obs, m.mov_id, m.per_id, m.mov_sala FROM movimientos as m WHERE m.mov_id = {0}; SELECT md.mde_monto, md.mde_concepto FROM movimientosdetalles as md WHERE md.mov_id = {1}", idFactura, idFactura)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        'Dim DS3 As DataSet = New DataSet()
        'Dim fechas As String
        bd = False
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            conexion.CerrarConexion()

            DS.Tables(0).TableName = "movimientos"
            DS.Tables(1).TableName = "movimientosdetalles"
            fecha = DS.Tables(0).Rows(0).ItemArray(1).ToString
            objrep.SetDataSource(DS)

            If alumno = "" Then
                SQL = String.Format("SELECT CONCAT(per_apellido, "", "", per_nombre) FROM personas as p WHERE p.per_id = {0}", DS.Tables(0).Rows(0).ItemArray(7).ToString)
                conexion.AbrirConexion(bd)
                DA.Dispose()
                DA = conexion.EjecutarConsulta(SQL)
                DA.Fill(DS2)
                alumno = DS2.Tables(0).Rows(0).Item(0).ToString
                conexion.CerrarConexion()
            End If

            objrep.SetParameterValue(0, alumno)
            objrep.SetParameterValue(1, fecha)
            If print Then
                objrep.PrintToPrinter(1, False, 1, 2)
            End If

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class