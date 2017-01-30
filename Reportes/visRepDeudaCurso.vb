Public Class visRepDeudaCurso
    Public objrep As New rptDeudaCurso
    Public curso As String
    Public bd As Boolean

    Private Sub visRepDeudaAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cur_nombre FROM cursos as c WHERE c.cur_id = {0}", curso)
        Dim SQL2 As String = String.Format("SELECT SUM(dde_monto) as total FROM devengacionesdetalles as dd, devengaciones as d, personas as p, alumnos as a WHERE d.per_id = p.per_id AND p.per_id = a.per_id AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND a.alu_activo = 1 AND a.alu_baja = 0 AND a.alu_curso = {0}", curso)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Dim DS3 As DataSet = New DataSet()
        Dim repoDev As New RepoDevengación
        Dim total As Double
        Dim curso_nombre As String
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            conexion.CerrarConexion()
            curso_nombre = DS.Tables(0).Rows(0).ItemArray(0).ToString

            DS2 = repoDev.Devengaciones_NoAnuladas_Curso(curso, bd)
            DS2.Tables(0).TableName = "Detalles"
            objrep.SetDataSource(DS2)

            DA.Dispose()
            DA = conexion.EjecutarConsulta(SQL2)
            DA.Fill(DS3)
            conexion.CerrarConexion()

            total = DS3.Tables(0).Rows(0).ItemArray(0)

            objrep.SetParameterValue(0, total)
            objrep.SetParameterValue(1, curso_nombre)

            DeudaCurso.ReportSource = objrep
            DeudaCurso.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class