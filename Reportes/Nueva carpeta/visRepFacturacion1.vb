Public Class visRepFacturacion1
    Public idFactura As Integer
    Public alumno As String
    Public objrep As New rptFacturacion1
    Public bd As New Boolean

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("select * from personas as p, alumnos as a, movimientos as m, movimientosdetalles as md where m.mov_id = {0} AND md.mov_id =  {1} AND m.per_id = p.per_id AND a.per_id = m.per_id", idFactura, idFactura)
        Dim SQL As String = String.Format("SELECT * FROM movimientos as m WHERE m.mov_id = {0}; SELECT * FROM movimientosdetalles as md WHERE md.mov_id = {1};", idFactura, idFactura)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "movimientos"
            DS.Tables(1).TableName = "movimientosdetalles"
            objrep.SetDataSource(DS)

            If alumno = "" Then
                SQL = String.Format("SELECT CONCAT(per_apellido, "", "", per_ nombre) FROM personas as p WHERE dp.per_id = {0}", DS.Tables(0).Rows(0).ItemArray(1).ToString)
                conexion.AbrirConexion()
                DA.Dispose()
                DA = conexion.EjecutarConsulta(SQL)
                DS.Clear()
                DS.Dispose()
                DA.Fill(DS)
                conexion.CerrarConexion()

            End If

            objrep.SetParameterValue(0, alumno)

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class