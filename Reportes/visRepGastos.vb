Public Class visRepGastos
    Public fecha1 As String
    Public fecha2 As String
    Public total As Double
    Public proveedor As String
    Public objrep As New rptGastos
    Public db As New Boolean

    Private Sub visRepGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim SQL2 As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DA2 As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        If proveedor <> "" Then
            SQL = String.Format("SELECT CONVERT(m.mov_fecha, CHAR) AS mov_fecha, m.mov_obs, m.mov_cuentaDebe, m.mov_concepto, m.mov_total, m.mov_cuentaHaber, p.razon_social as proveedor FROM movimientos as m, datosnegocio as p WHERE m.per_id = p.id AND m.mov_fecha BETWEEN '{0}' AND '{1}' AND m.mov_tipo = 0 AND m.per_id = '{2}'", fecha1, fecha2, proveedor)
            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_fecha BETWEEN '{0}' AND '{1}' AND m.mov_tipo = 0 AND m.per_id = '{2}' AND mov_anulada = 0;", fecha1, fecha2, Convert.ToInt16(proveedor))
        Else
            SQL = String.Format("SELECT CONVERT(m.mov_fecha, CHAR) AS mov_fecha, m.mov_obs, m.mov_cuentaDebe, m.mov_concepto, m.mov_total, m.mov_cuentaHaber, p.razon_social as proveedor FROM movimientos as m, datosnegocio as p WHERE m.per_id = p.id AND m.mov_fecha BETWEEN '{0}' AND '{1}' AND m.mov_tipo = 0", fecha1, fecha2)
            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_fecha BETWEEN '{0}' AND '{1}' AND m.mov_tipo = 0 AND mov_anulada = 0;", fecha1, fecha2)
        End If
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            DA2 = conexion.EjecutarConsulta(SQL2)
            DA2.Fill(DS2)
            conexion.CerrarConexion()

            If Not IsDBNull(DS2.Tables(0).Rows(0).ItemArray(0)) Then
                total = Convert.ToDouble(DS2.Tables(0).Rows(0).ItemArray(0))
            Else
                MsgBox("No hay gastos registrados en ese intervalo de fechas", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)
            End If

            DS.Tables(0).TableName = "movimientos"

            objrep.SetDataSource(DS)
            objrep.SetParameterValue(0, fecha1)
            objrep.SetParameterValue(1, fecha2)
            objrep.SetParameterValue(2, total)

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class