Imports MySql.Data.MySqlClient

Public Class RepoRetiroAlumno
    Private aID As String = "rta_id"
    Private aAlumno As String = "alu_id"
    Private aNombre As String = "rta_nombre"
    Private aApellido As String = "rta_apellido"
    Private aVinculo As String = "rta_vinculo"

    Public Function Agregar(IDAlumno As Integer, Nombre As String, Apellido As String, Vinculo As String) As Integer
        Dim con As New cBaseDatos
        Dim SQL As String
        SQL = String.Format("INSERT INTO retirosalumnos (alu_id, rta_nombre, rta_apellido, rta_vinculo) VALUES ({0},'{1}','{2}','{3}')",
                            IDAlumno, Nombre, Apellido, Vinculo)
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

    Public Function TraerRetiros(ByVal IDAlumno As Integer) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT rta_id, rta_nombre +', '+rta_apellido FROM retirosalumnos WHERE alu_id = {0}", IDAlumno)
        'Dim DA As New SqlClient.SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
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

    Public Function QuitarRetiro(IDRetiro As Integer) As Integer
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("DELETE FROM retirosalumnos WHERE rta_id = {0}", IDRetiro)
        Dim result As Integer
        Try
            con.AbrirConexion()
            result = con.EjecutarComando(Sql.ToString)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

    End Function

End Class
