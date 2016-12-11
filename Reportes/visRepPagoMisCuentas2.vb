Public Class visRepPagoMisCuentas2
    Public objrep As New rptPagoMisCuentas2
    Public db As Boolean
    Public fecha1 As String
    Public fecha2 As String

    Private Sub visRepPagoMisCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        'Dim SQL As String = "SELECT CONVERT(CURDATE(), CHAR) as Fecha, CONCAT(p.per_apellido, ', ', p.per_nombre) as Alumno, c.cur_nombre as Sala, a.alu_turno as Turno, CONCAT('0000', p.per_dni) as Codigo_PE, d.dev_total AS Monto FROM personas as p, devengaciones As d, alumnos as a, cursos as c WHERE d.per_id = p.per_id AND d.dev_cancelada = 0 AND d.dev_anulada = 0 AND p.per_id = a.per_id AND a.alu_curso = c.cur_id"
        Dim SQL As String = String.Format("SELECT p.per_dni, d.dev_id, d.dev_vencimiento1, d.dev_total as total1, d.dev_vencimiento2, d.dev_total * 1.02 as total2, d.dev_vencimiento3, d.dev_total * 1.04 as total3, CONCAT(UPPER(p.per_apellido), ', ', UPPER(p.per_nombre)) as alumno, UPPER(p.per_apellido) as apellido FROM personas as p, devengaciones As d WHERE d.per_id = p.per_id AND d.dev_cancelada = 0 AND d.dev_anulada = 0 AND d.dev_fecha BETWEEN '{0}' AND '{1}'", fecha1, fecha2)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "Deudores"

            objrep.SetDataSource(DS)
            objrep.SetParameterValue(0, fecha1)
            objrep.SetParameterValue(1, fecha2)

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class