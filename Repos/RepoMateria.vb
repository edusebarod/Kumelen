Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoMateria
    Private aID As String = "mat_id"
    Private aNombre As String = "mat_nombre"
    Private aActiva As String = "mat_activa"
    Private aCodigo As String = "mat_codigo"

    Public Function Traer_X_codigo(ByRef ID As Integer, ByRef Materia As Materia) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM materias WHERE mat_codigo = {0}", ID)
        'Dim DA As New SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Materia
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
        Dim SQL As String = String.Format("SELECT * FROM materias WHERE mat_nombre LIKE '{0}'", Nombre)
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

    Public Function Agregar(ByVal Mat As Materia) As Integer
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("INSERT INTO materias (mat_nombre, mat_codigo, mat_activa) VALUES ('{0}','{1}','{2}')",
                                          Mat.nombre, Mat.codigo, Mat.activo)
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

    Public Function Editar(ByVal Mat As Materia) As Integer
        Dim result As Integer
        Dim SQL As String = String.Format("UPDATE materias SET mat_nombre = '{0}' , mat_codigo = {1}, mat_activa = {2} WHERE mat_id = {3}",
                                          Mat.nombre, Mat.codigo, Mat.activo, Mat.id)
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
        'Dim DA As New SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim SQL As String = "SELECT * FROM materias"
        If SoloActivas Then
            SQL += " WHERE mat_activa = " & Activo
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