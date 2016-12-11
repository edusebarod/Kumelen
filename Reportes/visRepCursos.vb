Public Class visRepCursos
    Public db As Boolean
    Public objrep As New rptCursos

    Private Sub visRepServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT c.cur_id, CONCAT(p.per_apellido, ', ', p.per_nombre) as emp_nombre, c.cur_anolectivo, c.cur_nombre, c.cur_turno, c.cur_activo FROM cursos as c, personas as p, empleados as e WHERE c.cur_activo = 1 AND c.emp_id = e.emp_id AND e.per_id = p.per_id"
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "cursos"
            objrep.SetDataSource(DS)

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class