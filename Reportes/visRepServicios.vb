Public Class visRepServicios
    Public db As Boolean
    Public objrep As New rptServicios
    Public tipo As Integer
    Public sucursal As String

    Private Sub visRepServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT * FROM servicios where serv_tipo = {0}", tipo)
        Dim SQL As String = "SELECT * FROM servicios where serv_activo = 1"
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "servicios"

            objrep.SetDataSource(DS)

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class