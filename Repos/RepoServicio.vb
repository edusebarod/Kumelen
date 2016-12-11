Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoServicio
    Private aID As String = "serv_id"
    Private aCodigo As String = "serv_codigo"
    Private aNombre As String = "serv_nombre"
    Private aPrecio As String = "serv_precio"
    Private aActiva As String = "serv_activo"
    Private aObser As String = "serv_observaciones"
    Private aTipo As String = "serv_tipo"
    Private aCantidad As String = "serv_cantidad"

    Public Function Agregar(ByVal S As Servicio, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim SQL As New StringBuilder
        SQL.Append("INSERT INTO servicios ")
        SQL.Append("(serv_codigo")
        SQL.Append(",serv_nombre")
        SQL.Append(",serv_precio")
        SQL.Append(",serv_activo")
        SQL.Append(",serv_observaciones")
        SQL.Append(",serv_tipo")
        SQL.Append(",serv_cantidad)")
        SQL.Append(" VALUES ")
        SQL.Append("('" & S.codigo & "'")
        SQL.Append(",'" & S.nombre & "'")
        SQL.Append(",'" & S.precio & "'")
        SQL.Append(",'" & S.activo & "'")
        SQL.Append(",'" & S.observaciones & "'")
        SQL.Append("," & S.tipo)
        SQL.Append(", " & S.cantidad)
        SQL.Append(")")
        Dim result As Integer
        Try
            con.AbrirConexion(bd)
            result = con.EjecutarComando(SQL.ToString)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Editar(ByVal S As Servicio, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim SQL As New StringBuilder
        SQL.Append("UPDATE servicios ")
        SQL.Append("SET serv_codigo = '" & S.codigo & "'")
        SQL.Append(",serv_nombre = '" & S.nombre & "'")
        SQL.Append(",serv_precio = '" & S.precio & "'")
        SQL.Append(",serv_activo = '" & S.activo & "'")
        SQL.Append(",serv_observaciones = '" & S.observaciones & "'")
        SQL.Append(",serv_tipo = " & S.tipo)
        SQL.Append(",serv_cantidad = " & S.cantidad)
        SQL.Append(" WHERE serv_id = '" & S.id & "'")
        Dim result As Integer
        Try
            con.AbrirConexion(bd)
            result = con.EjecutarComando(SQL.ToString)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Existe(ByVal Codigo As Integer, Optional ByVal bd As Boolean = True) As Boolean
        Dim B As Boolean = True
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM servicios WHERE serv_nombre = '{0}'", Codigo)
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

    Public Function Traer_X_codigo(ByVal ID As Integer, ByRef S As Servicio, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT * FROM servicios WHERE serv_codigo = " & ID
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With S
                    .id = dr(aID)
                    .codigo = dr(aCodigo)
                    .nombre = dr(aNombre)
                    .precio = dr(aPrecio)
                    .activo = dr(aActiva)
                    .observaciones = dr(aObser)
                    .tipo = dr(aTipo)
                    .cantidad = dr(aCantidad)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_ID(ByVal ID As String, ByRef S As Servicio, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT * FROM servicios WHERE serv_id = " & ID
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With S
                    .id = dr(aID)
                    .codigo = dr(aCodigo)
                    .nombre = dr(aNombre)
                    .precio = dr(aPrecio)
                    .activo = dr(aActiva)
                    .observaciones = dr(aObser)
                    .tipo = dr(aTipo)
                    .cantidad = dr(aCantidad)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function EsProducto(ByVal nombre As String, Optional ByVal bd As Boolean = True) As Boolean
        Dim B As Boolean = False
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("SELECT serv_tipo FROM servicios WHERE serv_nombre LIKE '{0}'", nombre)
        Dim dr As DataRow
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            con.AbrirConexion(bd)
            DA = con.EjecutarConsulta(SQL)
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            dr = DS.Tables(0).Rows(0)
            If dr("serv_tipo") = 1 Then B = True
            con.CerrarConexion()
            Return B
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
