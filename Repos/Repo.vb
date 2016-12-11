Imports MySql.Data.MySqlClient

Public Class Repo
    Public Function Traer_X_nombre(ByVal SQLbase As String, ByVal Parametro As String, ByVal TipoConexion As Boolean) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format(SQLbase & " LIKE '%{0}%'", Parametro)
        'Dim DA As New SqlClient.SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(TipoConexion)
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


'Public Function obtenerPorNombre(ByVal nombreTabla As String) As DataSet
'    Dim conexion As New ConexionBase
'    Dim myconexion = conexion.inicializarConexion()

'    Dim comando As MySqlCommand = myconexion.CreateCommand
'    comando.CommandText = String.Format("select * from {0}", nombreTabla)

'    Dim dt As New MySqlDataAdapter(comando.CommandText, myconexion)
'    Dim das = New DataSet()
'    dt.Fill(das, nombreTabla.ToString)

'    conexion.finalizarConexion()
'    Return das
'End Function


'Public Function AgregarUno(ByVal sp As String, ByVal lista As List(Of String)) As Boolean
'    Dim conexion As New ConexionBase
'    Dim myconexion = conexion.inicializarConexion()

'    Dim comando As MySqlCommand = myconexion.CreateCommand
'    comando.CommandText = sp.ToString
'    comando.CommandType = CommandType.StoredProcedure

'    For Each Str As String In lista
'        comando.Parameters.Add(Str)
'    Next

'    comando.ExecuteNonQuery()

'    conexion.finalizarConexion()
'    Return True
'End Function