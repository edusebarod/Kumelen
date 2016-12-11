Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoFallodeCaja
    Private fdc As New FallodeCaja
    Private aID As String = "fdc_id"
    Private aFecha As String = "fdc_fecha"
    Private aSaldo As String = "fdc_saldo"
    Private aExistencia As String = "fdc_existencia"
    Private aDiferencia As String = "fdc_diferencia"
    Private aObservaciones As String = "fdc_observaciones"

    'Devuelve un dataset con las facturas con su detalle por persona
    Public Function FallosdeCaja(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT * FROM fallodecaja ORDER BY fdc_fecha"
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function

    'Devuelve un dataset con el fallo de Caja de la fecha indicada
    Public Function FallodeCaja_Fecha(ByVal fecha As String, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM fallodecaja WHERE fdc_fecha BETWEEN '{0} 00:00' AND '{1} 23:59' ORDER BY fdc_fecha", fecha, fecha)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function

    'Devuelve un dataset con el fallo de Caja del id indicado
    Public Function FallodeCaja_Id(ByVal id As Integer, ByRef fdc As FallodeCaja, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM fallodecaja WHERE fdc_id = {0} ORDER BY fdc_fecha", id)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim ret As Boolean = False
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            If Not DS.Tables(0).Rows.Count = 0 Then
                For Each dr As DataRow In DS.Tables(0).Rows
                    With fdc
                        .id = dr(aID)
                        If dr(aFecha) IsNot DBNull.Value Then.fecha = dr(aFecha).ToString
                        If dr(aSaldo) IsNot DBNull.Value Then .saldo = dr(aSaldo)
                        If dr(aExistencia) IsNot DBNull.Value Then .existencia = dr(aExistencia)
                        If dr(aDiferencia) IsNot DBNull.Value Then .diferencia = dr(aDiferencia)
                        If dr(aObservaciones) IsNot DBNull.Value Then .observaciones = dr(aObservaciones)
                    End With
                Next
                ret = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ret
    End Function


    'Impacta la devengación en la base de datos
    'cta: nombre de la cuenta contra la que se devenga
    'ser: nombre del servicio que se devenga
    'alu: id del alumno al que se le devenga
    'Total: monto total de la devengación
    'observaciones: observaciones de la devengación
    Public Function Insertar(fecha As String, saldo As Decimal, existencia As Decimal, diferencia As Decimal, observaciones As String, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim SQL As String
        Dim result As Integer


        con.AbrirConexion(bd)

        'se inserta el fallo de caja
        SQL = String.Format("INSERT INTO `fallodecaja` (`fdc_id`, `fdc_fecha`,`fdc_saldo`, `fdc_existencia`, `fdc_diferencia`, `fdc_observaciones`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}')",
                                         fecha, saldo, existencia, diferencia, observaciones)
        Try
            result = con.EjecutarComando(SQL)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        con.CerrarConexion()
        Return result
    End Function
End Class
