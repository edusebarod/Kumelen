Public Class visRepFacturacion10
    Public idFactura As Integer
    Public alumno As String
    Public objrep As New rptFacturacion1
    Public bd As New Boolean

    Private Sub visRepFacturacion10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("select * from personas as p, alumnos as a, movimientos as m, movimientosdetalles as md where m.mov_id = {0} AND md.mov_id =  {1} AND m.per_id = p.per_id AND a.per_id = m.per_id", idFactura, idFactura)
        Dim SQL As String = String.Format("SELECT * FROM movimientos WHERE mov_id = {0}; SELECT * FROM movimientosdetalles WHERE mov_id = {1}", idFactura, idFactura)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        'Dim DS3 As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            conexion.CerrarConexion()

            DS.Tables(0).TableName = "movimientos"
            DS.Tables(1).TableName = "movimientosdetalles"
            objrep.SetDataSource(DS)

            'If alumno = "" Then
            'SQL = String.Format("SELECT CONCAT(per_apellido, "", "", per_nombre) FROM personas as p WHERE p.per_id = {0}", DS.Tables(0).Rows(0).ItemArray(1).ToString)
            'conexion.AbrirConexion(bd)
            'DA.Dispose()
            'DA = conexion.EjecutarConsulta(SQL)
            'DS.Clear()
            'DS.Dispose()
            'DA.Fill(DS2)
            'alumno = DS2.Tables(0).Rows(0).Item(0).ToString
            'conexion.CerrarConexion()
            'End If
            alumno = "test"
            objrep.SetParameterValue(0, Alumno)

            MessageBox.Show(DS.Tables(0).Rows(0).Item(7).ToString)
            facturacion.ReportSource = objrep
            facturacion.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class