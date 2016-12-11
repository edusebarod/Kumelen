Imports System.Data.SqlClient
Imports System.Text


Public Class RepoCuenta
    Private aID As String = "cue_id"
    Private aNombre As String = "cue_nombre"
    Private aSaldo As String = "cue_saldo"
    Private aTipo As String = "cue_tipo"
    Private aActiva As String = "cue_activa"
    Private aDevengaciones As String = "cue_devengaciones"
    Private aFacturaciones As String = "cue_facturaciones"
    Private aPagosDebe As String = "cue_pagosGasto"
    Private aPagosHaber As String = "cue_pagosEgreso"

    Public Function Traer_X_codigo(ByRef ID As Integer, ByRef Cue As Cuenta, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM cuentas WHERE cue_id = {0}", ID)
        'Dim DA As New SqlClient.SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Cue
                    .id = dr(aID)
                    .nombre = dr(aNombre)
                    If dr(aSaldo) IsNot DBNull.Value Then .saldo = dr(aSaldo)
                    If dr(aTipo) IsNot DBNull.Value Then .tipo = dr(aTipo)
                    .activo = dr(aActiva)
                    .devengaciones = dr(aDevengaciones)
                    .facturaciones = dr(aFacturaciones)
                    .pagosDebe = dr(aPagosDebe)
                    .pagosHaber = dr(aPagosHaber)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Existe(ByVal Nombre As String, Optional ByVal bd As Boolean = True) As Boolean
        Dim B As Boolean = True
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM cuentas WHERE cue_nombre LIKE '{0}'", Nombre)
        'Dim DA As SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            con.AbrirConexion(bd)
            DA = con.EjecutarConsulta(SQL)
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then B = False
            con.CerrarConexion()
            Return B
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Agregar(ByVal Cue As Cuenta, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("INSERT INTO cuentas (cue_nombre, cue_saldo, cue_tipo, cue_activa, cue_codigo, cue_devengaciones, cue_facturaciones, cue_pagosGasto, cue_pagosEgreso, cue_grupo) VALUES ('{0}','{1}','{2}','{3}', {4}, {5}, {6}, {7}, {8}, {9})",
                                          Cue.nombre, Cue.saldo, Cue.tipo, Cue.activo, Cue.codigo, Cue.devengaciones, Cue.facturaciones, Cue.pagosDebe, Cue.pagosHaber, Cue.grupo)
        Dim result As Integer
        Try
            con.AbrirConexion(bd)
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Editar(ByVal Cue As Cuenta, Optional ByVal bd As Boolean = True) As Integer
        Dim result As Integer
        Dim SQL As String = String.Format("UPDATE cuentas SET cue_nombre = '{0}', cue_saldo = '{1}', cue_tipo = '{2}', cue_activa = '{3}', cue_devengaciones = {4}, cue_facturaciones = {5}, cue_pagosEgreso = {6}, cue_pagosGasto = {7}, cue_grupo = {8} WHERE cue_id = {9}",
                                          Cue.nombre, Cue.saldo, Cue.tipo, Cue.activo, Cue.devengaciones, Cue.facturaciones, Cue.pagosHaber, Cue.pagosDebe, Cue.grupo, Cue.id)
        Dim con As New cBaseDatos
        Try
            con.AbrirConexion(bd)
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
