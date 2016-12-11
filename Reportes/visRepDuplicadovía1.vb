Public Class visRepDuplicadovía1
    Public idFactura As Integer
    Public alumno As String
    Private objrep2 As New rptDuplicadosvia1
    Public bd As New Boolean

    Private Sub visRepDuplicado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT m.mov_encargado, CONVERT(m.mov_fecha, CHAR) as mov_fecha, m.mov_total, m.mov_pto_venta, m.mov_nro_factura, m.mov_obs, m.mov_id, m.per_id, m.mov_sala FROM movimientos as m WHERE m.mov_id = {0}; SELECT md.mde_monto, md.mde_concepto FROM movimientosdetalles as md WHERE md.mov_id = {1}", idFactura, idFactura)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Dim fecha As String
        bd = True
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            conexion.CerrarConexion()

            DS.Tables(0).TableName = "movimientos"
            DS.Tables(1).TableName = "movimientosdetalles"
            fecha = DS.Tables(0).Rows(0).ItemArray(1).ToString
            objrep2.SetDataSource(DS)

            If Alumno = "" Then
                SQL = String.Format("SELECT CONCAT(per_apellido, "", "", per_nombre) FROM personas as p WHERE p.per_id = {0}", DS.Tables(0).Rows(0).ItemArray(7).ToString)
                conexion.AbrirConexion(bd)
                DA.Dispose()
                DA = conexion.EjecutarConsulta(SQL)
                DA.Fill(DS2)
                Alumno = DS2.Tables(0).Rows(0).Item(0).ToString
                conexion.CerrarConexion()
            End If

            objrep2.SetParameterValue(0, alumno)
            objrep2.SetParameterValue(1, fecha)

            CrystalReportViewer1.ReportSource = objrep2
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class