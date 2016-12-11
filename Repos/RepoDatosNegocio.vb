Imports MySql.Data.MySqlClient
Imports System.Text

Public Class RepoDatosNegocio
    Private aId As String = "id"
    Private aRazSocial As String = "razon_social"
    Private aDireccion As String = "direccion"
    Private aLoc As String = "localidad"
    Private aCUIT As String = "cuit"
    Private aTelefono As String = "telefono"
    Private aMail As String = "mail"
    Private aWeb As String = "web"

    Public Function Traer(ByVal id As Integer, ByRef Datos As Proveedor, Optional ByVal db As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM datosnegocio WHERE id = {0}", id)
        'Dim DA As New SqlClient.SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Datos
                    .id = dr(aId)
                    .razonsocial = dr(aRazSocial)
                    .direccion = dr(aDireccion)
                    .localidad = dr(aLoc)
                    .cuit = dr(aCUIT)
                    .telefono = dr(aTelefono)
                    .mail = dr(aMail)
                    .web = dr(aWeb)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_todos(Optional ByVal db As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT * FROM datosnegocio ORDER BY razon_social"
        'Dim DA As New SqlClient.SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()

        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function

    Public Function Editar(ByVal Datos As Proveedor, Optional ByVal db As Boolean = True) As Integer
        Dim result As Integer
        Dim sql As New StringBuilder
        sql.Append("UPDATE datosnegocio ")
        sql.Append("SET razon_social = '" & Datos.razonsocial & "'")
        sql.Append(",direccion = '" & Datos.direccion & "'")
        sql.Append(",localidad = '" & Datos.localidad & "'")
        sql.Append(",cuit = '" & Datos.cuit & "'")
        sql.Append(",telefono = '" & Datos.telefono & "'")
        sql.Append(",mail = '" & Datos.mail & "'")
        sql.Append(",web = '" & Datos.web & "'")
        sql.Append(" WHERE id = '" & Datos.id & "'")
        Dim con As New cBaseDatos
        Try
            con.AbrirConexion(db)
            result = con.EjecutarComando(sql.ToString)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function agregar(ByVal Datos As Proveedor, Optional ByVal db As Boolean = True) As Integer
        Dim result As Integer
        Dim SQL As New StringBuilder
        With Datos
            SQL.Append("INSERT INTO datosnegocio (razon_social, direccion, localidad, cuit, telefono, mail, web)")
            SQL.Append("VALUES ('" & .razonsocial & "', '")
            SQL.Append(.direccion & "', '")
            SQL.Append(.localidad & "', '")
            SQL.Append(.cuit & "', '")
            SQL.Append(.telefono & "', '")
            SQL.Append(.mail & "', '")
            SQL.Append(.web & "');")
        End With
        Dim con As New cBaseDatos
        Try
            con.AbrirConexion(db)
            result = con.EjecutarComando(SQL.ToString)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
End Class

