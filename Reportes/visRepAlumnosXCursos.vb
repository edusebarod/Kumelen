Public Class visRepAlumnosXCursos
    Public idCurso As Integer
    Public turno As String
    Public objrep As New rptAlumnosXCurso
    Public Curso As String
    Public db As Boolean

    Private Sub visRepAlumnosXCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT c.cur_nombre as Sala, CONCAT(p.per_apellido, ', ', p.per_nombre) as Alumno, p.per_dni AS DNI, a.alu_descuento AS Beca FROM cursos as c, personas as p, alumnos as a WHERE c.cur_id = {0} AND a.per_id = p.per_id AND a.alu_curso = c.cur_id AND a.alu_turno LIKE '{1}' AND a.alu_activo = 1 AND a.alu_baja = 0 ORDER BY Alumno; SELECT cur_nombre FROM cursos WHERE cur_id = {2}", idCurso, turno, idCurso)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "Lista"
            DS.Tables(1).TableName = "Curso"

            objrep.SetDataSource(DS)
            objrep.SetParameterValue(0, DS.Tables(1).Rows(0).ItemArray(0).ToString)
            objrep.SetParameterValue(1, turno)

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Imprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.Control And e.P = Keys.S Then
        'If e.KeyCode = Keys.Control + Keys.P Then
        If e.KeyCode = Keys.P Then
            Me.CrystalReportViewer1.PrintReport()
        End If
    End Sub
End Class