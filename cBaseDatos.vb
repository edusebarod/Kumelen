Imports MySql.Data.MySqlClient
Imports System.Xml
Imports System.IO

Public Class cBaseDatos
    Private ConStr As String
    Public Conexion As New MySqlConnection()
    'Public Conexion As MySqlConnection
    Public Comando As MySqlCommand
    Public Transaccion As MySqlTransaction

    Public Function EjecutarConsulta(ByVal sentenciaSQL As String) As MySqlDataAdapter
        Dim DA As MySqlDataAdapter = Nothing
        Comando.Connection = Conexion
        Comando.Transaction = Transaccion
        Comando.CommandText = sentenciaSQL
        Try
            DA = New MySqlDataAdapter(Comando.CommandText, Conexion)
        Catch ex As MySqlException
            MsgBox("Ocurrió un error del tipo: " & ex.GetType().ToString() _
                   & " mientras se intentaba rebertir los cambios en el sistema.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Cts.msgTitulo)
        End Try
        Return DA
    End Function

    Public Function EjecutarComando(ByVal comandoSQL As String) As Integer
        'POST -1 error, sino cantidad de filas afectadas
        Dim result As Integer = 0
        Transaccion = Conexion.BeginTransaction()
        Comando.Connection = Conexion
        Comando.Transaction = Transaccion
        Try
            Comando.CommandText = comandoSQL
            result = Comando.ExecuteNonQuery()
            Transaccion.Commit()
        Catch e As Exception
            Try
                Transaccion.Rollback()
            Catch ex As MySqlException
                If Not Transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error del tipo: " & ex.GetType().ToString() _
                           & " mientras se intentaba rebertir los cambios en el sistema.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Cts.msgTitulo)
                End If
            End Try
            MsgBox("Ocurrió un error del tipo: " & e.GetType().ToString() _
                   & " mientras se intentaba rebertir los cambios en el sistema.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Cts.msgTitulo)
            MsgBox("No se actualizo el sistema con los datos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Cts.msgTitulo)
            'Finally
            'Conexion.Close()
        End Try
        Return result
    End Function

    Public Sub AbrirConexion(Optional ByVal bd As Boolean = True)
        Try
            Me.Conexion = New MySqlConnection
            Me.Comando = New MySqlCommand
            If bd Then
                Me.Conexion.ConnectionString = Cts.via1
            Else
                Me.Conexion.ConnectionString = Cts.via2
            End If
            Me.Conexion.Open()
        Catch ex As BaseDatosException
            MessageBox.Show(ex.Message)
            Throw New BaseDatosException("Error al conectarse.")
        End Try
    End Sub

    Public Sub CerrarConexion()
        Me.Conexion.Close()
    End Sub

    Public Function selecionar(sql As String) As MySqlClient.MySqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim con As New cBaseDatos
        Try
            con.AbrirConexion()
            DA = con.EjecutarConsulta(sql)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DA
    End Function

    Public Function insertar(sql As String) As Integer
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim con As New cBaseDatos
        Dim id As Integer
        Try
            con.AbrirConexion()
            DA = con.EjecutarConsulta(sql)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function

End Class


Public Class BaseDatosException
    Inherits ApplicationException

    Public Sub New(ByVal mensaje As String, ByVal original As Exception)
        MyBase.New(mensaje, original)
    End Sub

    Public Sub New(ByVal mensaje As String)
        MyBase.New(mensaje)
    End Sub
End Class