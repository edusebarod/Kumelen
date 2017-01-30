Imports MySql.Data.MySqlClient

Public Class Conexion
    Private ConStr As String
    Private Con As MySqlConnection

    Public Function AbrirConexion(ByVal Facturar As Boolean) As MySqlConnection
        'con parametro para ver si se factura o no, para diferenciar el tipo de connection string
        Me.ConStr = Me.ConexionFacturable(Facturar)
        Try
            Me.Con = New MySqlConnection
            Con.ConnectionString = Me.ConStr
            Con.Open()
        Catch ex As Exception
            Return Nothing
        End Try
        Return Con
    End Function

    Public Function AbrirConexion() As MySqlConnection
        Me.ConStr = Me.ConexionFacturable(False)
        Try
            Me.Con = New MySqlConnection
            Con.ConnectionString = Me.ConStr
            Con.Open()
        Catch ex As Exception
            Return Nothing
        End Try
        Return Con
    End Function

    Public Sub CerrarConexion()
        Me.Con.Close()
    End Sub

    Public Function ConexionFacturable(ByVal Facturar As Boolean) As String
        'aca podemos levantar de un archivo asi es parametrizable
        If Facturar Then
            Return "Server=127.0.0.1;Database=kumelen;Uid=root;"
        Else
            Return "Server=127.0.0.1;Database=kumelen;Uid=root;"
        End If
    End Function
End Class
