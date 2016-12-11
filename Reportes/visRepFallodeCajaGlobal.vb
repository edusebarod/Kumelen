Public Class visRepFallodeCajaGlobal
    Public fecha As String
    Public objrep As New rptFallodeCajaGlobal
    Public sucursal As String


    Private Sub visRepFallodeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT fdcg_id as id, CONVERT(fdcg_fecha, CHAR) as fecha, fdcg_saldovia1 as saldovia1, fdcg_saldovia2 as saldovia2, fdcg_existencia as existencia, fdcg_existenciafisica as existenciafisica, fdcg_sobres as sobres, fdcg_sobresdetalle as sobresdetalle, fdcg_vales as vales, fdcg_valesdetalle as valesdetalle, fdcg_diferencia as diferencia, fdcg_observaciones as observaciones FROM fallodecajaglobal WHERE fdcg_fecha = '{0}'", fecha)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(False)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "fallodecajaglobal"

            objrep.SetDataSource(DS)
            If sucursal = "ZOO" Then
                objrep.SetParameterValue(0, "Zoológico")
            ElseIf sucursal = "KSC" Then
                objrep.SetParameterValue(0, "San Carlos")
            End If

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class