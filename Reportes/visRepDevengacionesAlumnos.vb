Public Class visRepDevengacionesAlumnos
    Public objrep As New rptDevengacionesAlumnos
    Public bd As Boolean

    Private Sub visRepDevengacionesAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT CONCAT(p.per_apellido, ', ', p.per_nombre) as alumno, c.cur_nombre as sala, a.alu_turno as turno, SPACE(40) as cpe, d.dev_vencimiento1 as vencimiento1, d.dev_total as monto, d.dev_observaciones as observaciones, p.per_dni as dni, d.dev_id as dev_id FROM personas as p, devengaciones As d, alumnos as a, cursos as c WHERE a.per_id = p.per_id AND d.per_id = p.per_id AND a.alu_curso = c.cur_id AND d.dev_cancelada = 0 AND d.dev_anulada = 0 ORDER BY alumno"
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "Devengaciones"

            For Each dr As DataRow In DS.Tables(0).Rows
                'Se completa el cpe
                dr("cpe") = generarCodBarra(dr("dni"), dr("dev_id").ToString.PadLeft(8, "0"), dr("vencimiento1"))
            Next

            'If Not bd Then
            ' objrep.SetParameterValue(0, "Vía 2")
            ' Else
            ' objrep.SetParameterValue(0, " ")
            ' End If

            objrep.SetDataSource(DS)

            CrystalReportViewer2.ReportSource = objrep
            CrystalReportViewer2.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class