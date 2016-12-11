Public Class visRepAlumnosXNivel
    Public objrep As New rptAlumnosXNivel
    Public Nivel As String

    Private Sub visRepAlumnosXCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT CONCAT (p.per_apellido, ', ', p.per_nombre) as Alumno, p.per_dni AS DNI, c.cur_nombre as Sala FROM cursos as c, personas as p, alumnos as a WHERE a.alu_tipo LIKE '{0}' AND a.per_id = p.per_id AND a.alu_curso = c.cur_id AND a.alu_baja = 0 ORDER BY Sala, Alumno", Nivel)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "Lista"

            objrep.SetDataSource(DS)
            objrep.SetParameterValue(0, Nivel)


            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class