Public Class visRepDevengacionTriplicado
    Public iddevengacion As Integer
    Public alumno As String
    Public sala As String
    Public turno As String
    Public objrep As New rptDevengacionTriplicado

    Private Sub devengacion_Load(sender As Object, e As EventArgs) Handles devengacion.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM devengaciones WHERE dev_id = {0}; SELECT * FROM devengacionesdetalles WHERE dev_id = {1}", iddevengacion, iddevengacion)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            conexion.CerrarConexion()

            DS.Tables(0).TableName = "devengaciones"
            DS.Tables(1).TableName = "devengacionesdetalles"
            objrep.SetDataSource(DS)

            objrep.SetParameterValue(0, Alumno)
            objrep.SetParameterValue(1, Sala)
            objrep.SetParameterValue(2, turno)

            devengacion.ReportSource = objrep
            devengacion.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class