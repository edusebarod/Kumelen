Imports MySql.Data.MySqlClient


Public Class reporFacturacion
    Public movimiento As Integer
    Dim DS As New DSFacturacion

    Private Sub vreporFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim lector As MySqlDataReader
            Dim tabla As New DataTable
            Dim reporte As New CrystalReport1
            Dim conexion As New cBaseDatos
            Dim DA As New MySqlDataAdapter

            Dim sql As String = String.Format("Select * FROM movimientos as m, movimientosdetalles as md, alumnos as a, personas as p WHERE m.mov_id = md.mov_id AND m.per_id = p.per_id AND p.per_id = a.per_id AND  m.mov_id = {0}", movimiento)

            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(sql)
            DA.Fill(DS)
            conexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

    End Sub
End Class