Public Class visRepDeudaAlumno
    Public idalumno As String
    Public total As Double
    Public nroDev As String
    Public objrep As New rptDeudaAlumno
    Public xsala As Boolean 'si es una devengacion por sala, no se previsualiza
    Public intereses As Boolean
    Public bd As Boolean

    Private Sub visRepDeudaAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, dev_fecha, serv_nombre, dev_total, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3 FROM devengaciones as d, devengacionesdetalles as dd, personas as p WHERE d.dev_id = dd.dev_id AND d.per_id = p.per_id AND p.per_id = {0} AND dd.dde_cancelada = 0 ORDER BY alumno", idalumno)
        Dim SQL2 As String = String.Format("SELECT SUM(dde_monto) as total FROM devengacionesdetalles as dd, devengaciones as d, personas as p WHERE p.per_id = {0} AND d.per_id = p.per_id AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 1", idalumno)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Dim repoDev As New RepoDevengación
        Try
            conexion.AbrirConexion(bd)
            'DA = conexion.EjecutarConsulta(SQL)
            'DA.Fill(DS)
            'conexion.CerrarConexion()
            DS = repoDev.Devengaciones_NoCanceladas_Alumno(idalumno, bd)
            DS.Tables(0).TableName = "Detalles"
            objrep.SetDataSource(DS)

            'DA.Dispose()
            DA = conexion.EjecutarConsulta(SQL2)
            DA.Fill(DS2)
            conexion.CerrarConexion()

            total = DS2.Tables(0).Rows(0).ItemArray(0)
            objrep.SetParameterValue(0, total)

            DeudaAlumno.ReportSource = objrep
            DeudaAlumno.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class