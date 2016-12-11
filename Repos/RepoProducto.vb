Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoProducto
    Private aID As String = "pro_id"
    Private aCodigo As String = "pro_codigo"
    Private aNombre As String = "pro_nombre"
    Private aPrecio As String = "pro_precio"
    Private aStock As String = "pro_stock"
    Private aActiva As String = "pro_activo"
    Private aObser As String = "pro_observaciones"

    Public Function Agregar(ByVal P As Producto) As Integer
        Dim con As New cBaseDatos
        Dim SQL As New StringBuilder
        SQL.Append("INSERT INTO productos ")
        SQL.Append("(pro_codigo")
        SQL.Append(",pro_nombre")
        SQL.Append(",pro_precio")
        SQL.Append(",pro_stock")
        SQL.Append(",pro_activo")
        SQL.Append(",pro_observaciones)")
        SQL.Append(" VALUES ")
        SQL.Append("('" & P.codigo & "'")
        SQL.Append(",'" & P.nombre & "'")
        SQL.Append(",'" & P.precio & "'")
        SQL.Append(",'" & P.stock & "'")
        SQL.Append(",'" & P.activo & "'")
        SQL.Append(",'" & P.observaciones & "'")
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

    Public Function Editar(ByVal P As Producto) As Integer
        Dim con As New cBaseDatos
        Dim SQL As New StringBuilder
        SQL.Append("UPDATE productos ")
        SQL.Append("SET pro_codigo = '" & P.codigo & "'")
        SQL.Append(",pro_nombre = '" & P.nombre & "'")
        SQL.Append(",pro_precio = '" & P.precio & "'")
        SQL.Append(",pro_stock = '" & P.stock & "'")
        SQL.Append(",pro_activo = '" & P.activo & "'")
        SQL.Append(",pro_observaciones = '" & P.observaciones & "'")
        SQL.Append(" WHERE pro_id = '" & P.id & "'")
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

    Public Function Existe(ByVal Nombre As String) As Boolean
        Dim B As Boolean = True
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM productos WHERE pro_nombre LIKE '{0}'", Nombre)
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

    Public Function Traer_X_codigo(ByVal ID As Integer, ByRef Producto As Producto) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT * FROM productos WHERE pro_codigo = " & ID
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
                With Producto
                    .id = dr(aID)
                    .codigo = dr(aCodigo)
                    .nombre = dr(aNombre)
                    .precio = dr(aPrecio)
                    .stock = dr(aStock)
                    .activo = dr(aActiva)
                    .observaciones = dr(aObser)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

End Class
