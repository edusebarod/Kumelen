Public Class visRepIngresosFecha
    Public fecha1 As String
    Public fecha2 As String
    Public total As Double
    Public objrep As New rptIngresosFecha
    Public bd As New Boolean

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT * FROM movimientos as m WHERE m.mov_fecha BETWEEN STR_TO_DATE('{0}', '%d/%m/%Y') AND STR_TO_DATE('{1}', '%d/%m/%Y') AND m.mov_tipo = 1 AND m.mov_anulada = 0; SELECT md.* FROM movimientosdetalles as md, movimientos as m WHERE md.mov_id = m.mov_id AND m.mov_fecha BETWEEN STR_TO_DATE('{2}', '%d/%m/%Y') AND STR_TO_DATE('{3}', '%d/%m/%Y') AND m.mov_tipo = 1 AND m.mov_anulada = 0;", fecha1, fecha2, fecha1, fecha2)
        'Dim SQL2 As String = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_fecha BETWEEN STR_TO_DATE('{0}', '%d/%m/%Y') AND STR_TO_DATE('{1}', '%d/%m/%Y') AND m.mov_tipo = 1 AND m.mov_anulada = 0;", fecha1, fecha2)
        Dim SQL As String = String.Format("SELECT CONVERT(m.mov_fecha, CHAR) as mov_fecha, m.mov_obs, md.mde_monto, md.mde_concepto, md.cue_nombre, CONCAT(p.per_apellido, ', ', p.per_nombre) as alumno, c.cur_nombre as sala FROM movimientos as m, movimientosdetalles as md, personas as p, alumnos as a, cursos as c WHERE m.mov_id = md.mov_id AND m.mov_fecha BETWEEN '{0}' AND '{1}' AND m.mov_tipo = 1 AND m.mov_anulada = 0 AND m.per_id = p.per_id AND p.per_id = a.per_id AND a.alu_curso = c.cur_id", fecha1, fecha2)
        Dim SQL2 As String = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_fecha BETWEEN '{0}' AND '{1}' AND m.mov_tipo = 1 AND m.mov_anulada = 0;", fecha1, fecha2)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            DA = conexion.EjecutarConsulta(SQL2)
            DA.Fill(DS2)
            conexion.CerrarConexion()
            If DS.Tables.Count = 0 Then
                MsgBox(Cts.msgErrSinResultados, MsgBoxStyle.OkOnly + vbDefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)
                Me.Dispose()
            Else
                total = Convert.ToDouble(DS2.Tables(0).Rows(0).ItemArray(0))
                DS.Tables(0).TableName = "movimientos"

                objrep.SetDataSource(DS)
                objrep.SetParameterValue(0, fecha1)
                objrep.SetParameterValue(1, fecha2)
                objrep.SetParameterValue(2, total)

                CrystalReportViewer1.ReportSource = objrep
                CrystalReportViewer1.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class