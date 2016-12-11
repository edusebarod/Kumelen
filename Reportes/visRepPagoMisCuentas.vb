Public Class visRepPagoMisCuentas
    Public objrep As New rptPagoMisCuentas

    Private Sub visRepPagoMisCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT p.per_dni, d.dev_id, d.dev_vencimiento1, d.dev_total as total1, d.dev_vencimiento2, d.dev_total * 1.02 as total2, d.dev_vencimiento3, d.dev_total * 1.04 as total3, CONCAT(UPPER(p.per_apellido), ', ', UPPER(p.per_nombre)) as alumno, UPPER(p.per_apellido) as apellido FROM personas as p, devengaciones As d WHERE d.per_id = p.per_id AND d.dev_cancelada = 0 AND d.dev_anulada = 0"
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "Deudores"

            objrep.SetDataSource(DS)

            CrystalReportViewer.ReportSource = objrep
            CrystalReportViewer.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class