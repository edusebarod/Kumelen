Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoFallodeCajaGlobal
    Private fdcg As New FallodeCajaGlobal
    Private aID As String = "fdcg_id"
    Private aFecha As String = "fdcg_fecha"
    Private aSaldoVia1 As String = "fdcg_saldovia1"
    Private aSaldoVia2 As String = "fdcg_saldovia2"
    Private aExistencia As String = "fdcg_existencia"
    Private aExistenciaFisica As String = "fdcg_existenciafisica"
    Private aSobres As String = "fdcg_sobres"
    Private aSobresDetalle As String = "fdcg_sobresdetalle"
    Private aVales As String = "fdcg_vales"
    Private aValesDetalle As String = "fdcg_valesdetalle"
    Private aDiferencia As String = "fdcg_diferencia"
    Private aObservaciones As String = "fdcg_observaciones"

    'Devuelve un dataset con los arqueos ordenados por fecha
    Public Function FallosdeCaja() As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT * FROM fallodecajaglobal ORDER BY fdcg_fecha"
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(False)
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
    Public Function FallodeCaja_Fecha(ByVal fecha As String) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM fallodecajaglobal WHERE fdcg_fecha BETWEEN '{0} 00:00' AND '{1} 23:59' ORDER BY fdcg_fecha", fecha, fecha)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(False)
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
    Public Function FallodeCaja_Id(ByVal id As Integer, ByRef fdcg As FallodeCajaGlobal) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM fallodecajaglobal WHERE fdcg_id = {0} ORDER BY fdcg_fecha", id)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim ret As Boolean = False
        Try
            conexion.AbrirConexion(False)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            If Not DS.Tables(0).Rows.Count = 0 Then
                For Each dr As DataRow In DS.Tables(0).Rows
                    With fdcg
                        .id = dr(aID)
                        If dr(aFecha) IsNot DBNull.Value Then .fecha = dr(aFecha).ToString
                        If dr(aSaldoVia1) IsNot DBNull.Value Then .saldovia1 = dr(aSaldoVia1)
                        If dr(aSaldoVia2) IsNot DBNull.Value Then .saldovia2 = dr(aSaldoVia2)
                        If dr(aExistencia) IsNot DBNull.Value Then .existencia = dr(aExistencia)
                        If dr(aExistenciaFisica) IsNot DBNull.Value Then .existenciaFisica = dr(aExistenciaFisica)
                        If dr(aSobres) IsNot DBNull.Value Then .sobres = dr(aSobres)
                        If dr(aSobresDetalle) IsNot DBNull.Value Then .sobresdetalle = dr(aSobresDetalle)
                        If dr(aVales) IsNot DBNull.Value Then .sobres = dr(aVales)
                        If dr(aValesDetalle) IsNot DBNull.Value Then .valesdetalle = dr(aValesDetalle)
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


    'Impacta un arqueo en la base de datos
    Public Function Insertar(fecha As String, saldovia1 As Decimal, saldovia2 As Decimal, existencia As Decimal, existenciaFisica As String, sobres As Decimal, sobresDetalle As String, vales As Decimal, valesDetalle As String, diferencia As Decimal, observaciones As String, cajaFuerte As Decimal, cajaFuerteDetalle As String) As Integer
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim SQL As String
        Dim result As Integer


        con.AbrirConexion(False)

        'se inserta el fallo de caja
        SQL = String.Format("INSERT INTO `fallodecajaglobal` (`fdcg_id`, `fdcg_fecha`,`fdcg_saldovia1`, `fdcg_saldovia2`, `fdcg_existencia`, `fdcg_existenciafisica`, `fdcg_sobres`, `fdcg_sobresdetalle`, `fdcg_vales`, `fdcg_valesdetalle`, `fdcg_diferencia`, `fdcg_observaciones`, `fdcg_cajafuerte`, `fdcg_cajafuertedetalle`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')",
                                         fecha, saldovia1, saldovia2, existencia, existenciaFisica, sobres, sobresDetalle, vales, valesDetalle, diferencia, observaciones, cajaFuerte, cajaFuerteDetalle)
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
