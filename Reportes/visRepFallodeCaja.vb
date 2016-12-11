Public Class visRepFallodeCaja
    Public fecha As String
    Public objrep As New rptFallodeCaja
    

    Private Sub visRepFallodeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT fdc_id as id, CONVERT(fdc_fecha, CHAR) as fecha, fdc_saldo as saldo, fdc_existencia as existencia, fdc_diferencia as diferencia, fdc_observaciones as observaciones FROM fallodecaja WHERE fdc_fecha = '{0}'", fecha)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "fallodecaja"
            
            objrep.SetDataSource(DS)
            
            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class