Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoLocalidad
    Private aID As String = "loc_id"
    Private aNombre As String = "loc_nombre"
    Private aActiva As String = "loc_activa"
    Private aCodigo As String = "loc_codigo"

    Public Function Traer_X_codigo(ByRef ID As Integer, ByRef Loc As Localidad) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM localidades WHERE loc_codigo = {0}", ID)
        'Dim DA As New SqlClient.SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Loc
                    .id = dr(aID)
                    .codigo = dr(aCodigo)
                    .nombre = dr(aNombre)
                    .activo = dr(aActiva)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_id(ByRef ID As Integer, ByRef Loc As Localidad) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM localidades WHERE loc_id = {0}", ID)
        'Dim DA As New SqlClient.SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Loc
                    .id = dr(aID)
                    .codigo = dr(aCodigo)
                    .nombre = dr(aNombre)
                    .activo = dr(aActiva)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Existe(ByVal Nombre As String) As Boolean
        Dim B As Boolean = True
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM localidades WHERE loc_nombre LIKE '{0}'", Nombre)
        'Dim DA As SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            con.AbrirConexion()
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

    Public Function Agregar(ByVal loc As Localidad) As Integer
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("INSERT INTO localidades (loc_nombre, loc_codigo, loc_activa) VALUES ('{0}','{1}','{2}')",
                                          loc.nombre, loc.codigo, loc.activo)
        Dim result As Integer
        Try
            con.AbrirConexion()
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Editar(ByVal Loc As Localidad) As Integer
        Dim result As Integer
        Dim SQL As String = String.Format("UPDATE localidades SET loc_nombre = '{0}' , loc_codigo = {1},loc_activa = {2} WHERE loc_id = {3}",
                                          Loc.nombre, Loc.codigo, Loc.activo, Loc.id)
        Dim con As New cBaseDatos
        Try
            con.AbrirConexion()
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function TraerTodas(ByVal SoloActivas As Boolean) As DataSet
        Dim conexion As New cBaseDatos
        'Dim DA As New SqlClient.SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim SQL As String = "SELECT * FROM localidades"
        If SoloActivas Then
            SQL += " WHERE loc_activa = " & Activo
        End If
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

End Class