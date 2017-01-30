Public Class visRepDeudaGeneral
    Public objrep As New rptDeudaGeneral
    Public bd As Boolean

    Private Sub visRepDeudaAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT SUM(dde_monto) as total FROM devengacionesdetalles as dd, devengaciones as d, personas as p, alumnos as a WHERE d.per_id = p.per_id AND p.per_id = a.per_id AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND a.alu_activo = 1 AND a.alu_baja = 0")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Dim repoDev As New RepoDevengación
        Dim total As Double
        Try
            DS = repoDev.Devengaciones_NoCanceladas(bd)
            DS.Tables(0).TableName = "Detalle"
            objrep.SetDataSource(DS)

            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS2)
            conexion.CerrarConexion()

            total = DS2.Tables(0).Rows(0).ItemArray(0)

            objrep.SetParameterValue(0, total)

            DeudaGeneral.ReportSource = objrep
            DeudaGeneral.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class