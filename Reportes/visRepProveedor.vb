Public Class visRepProveedor
    Public objrep As New rptProveedor
    Public db As Boolean

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT * FROM datosnegocio"
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            conexion.CerrarConexion()

            DS.Tables(0).TableName = "datosnegocio"
            objrep.SetDataSource(DS)

            'objrep.SetParameterValue(0, alumno)
            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class