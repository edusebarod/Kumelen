Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoUsuario
    Private aID As String = "user_id"
    Private aNombre As String = "user_nombre"
    Private aLogin As String = "user_login"
    Private aPass As String = "user_pass"
    Private aTipo As String = "user_tipo"
    Private aActiva As String = "user_activo"
    Private aObser As String = "user_obse"

    Public Function Agregar(ByVal U As Usuario) As Integer
        Dim con As New cBaseDatos
        Dim SQL As New StringBuilder
        SQL.Append("INSERT INTO Usuarios ")
        SQL.Append(",user_nombre")
        SQL.Append(",user_login")
        SQL.Append(",user_pass")
        SQL.Append(",user_tipo")
        SQL.Append(",user_obse")
        SQL.Append(",user_activo)")
        SQL.Append(" VALUES ")
        SQL.Append("('" & U.nombre & "'")
        SQL.Append(",'" & U.login & "'")
        SQL.Append(",'" & U.pass & "'")
        SQL.Append(",'" & U.tipo & "'")
        SQL.Append(",'" & U.obse & "'")
        SQL.Append(",'" & U.activo & "'")
        SQL.Append(")")
        Dim result As Integer
        Try
            con.AbrirConexion()
            result = con.EjecutarComando(SQL.ToString)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Editar(ByVal U As Usuario) As Integer
        Dim con As New cBaseDatos
        Dim SQL As New StringBuilder
        SQL.Append("UPDATE usuarios ")
        SQL.Append("SET user_nombre = '" & U.nombre & "'")
        SQL.Append(",user_login = '" & U.login & "'")
        SQL.Append(",user_pass = '" & U.pass & "'")
        SQL.Append(",user_tipo = '" & U.tipo & "'")
        SQL.Append(",user_activo = '" & U.activo & "'")
        SQL.Append(",user_obse = '" & U.obse & "'")
        SQL.Append(" WHERE user_id = '" & U.id & "'")
        Dim result As Integer
        Try
            con.AbrirConexion()
            result = con.EjecutarComando(SQL.ToString)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Existe(ByVal Login As String) As Boolean
        Dim B As Boolean = True
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM Usuarios WHERE user_login LIKE '{0}'", Login)
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
        Return B
    End Function

    Public Function Traer_X_codigo(ByVal ID As Integer, ByRef U As Usuario) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT * FROM usuarios WHERE user_id = " & ID
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
                With U
                    .id = dr(aID)
                    .nombre = dr(aNombre)
                    .login = dr(aLogin)
                    .pass = dr(aPass)
                    .tipo = dr(aTipo)
                    .obse = dr(aObser)
                    .activo = dr(aActiva)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    'Public Function Traer_X_nombre(ByVal Nombre As String) As DataSet
    '    Dim conexion As New cBaseDatos
    '    Dim SQL As String = String.Format("SELECT * FROM usuarios WHERE user_nombre LIKE '%{0}%'", Nombre)
    '    Dim DA As New MySqlDataAdapter
    '    Try
    '        conexion.AbrirConexion()
    '        DA = conexion.EjecutarConsulta(SQL)
    '        conexion.CerrarConexion()
    '        Dim DS As DataSet = New DataSet()
    '        DA.Fill(DS)
    '        Return DS
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function

End Class
