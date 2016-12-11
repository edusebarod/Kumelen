Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoPadres
    Private pID As String = "per_id"
    Private pNombre As String = "per_nombre"
    Private pApellido As String = "per_apellido"
    Private pDNI As String = "per_dni"
    Private pFechaNacimiento As String = "per_fecnac"
    Private pNivelEscolaridad As String = "per_nivelesc"
    Private pDomicilio As String = "per_domicilio"
    Private pLocalidad As String = "loc_id"
    Private pEstadoCivil As String = "per_estadocivil"
    Private pOcupacion As String = "per_ocupacion"
    Private pEmpresa As String = "per_empresa"
    Private pTelefono As String = "per_telefono"
    Private pCelular As String = "per_celular"
    Private pMail As String = "per_mail"
    'TODO implementar estos campos en los padres
    'Private pObservaciones As String = "alu_observaciones"
    'Private pActivo As String = "alu_activo"
    'Private pTipo As String = "alu_tipo"

    Public Function Traer_X_Apellido(ByRef Apellido As String, ByRef Pad As Padre, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.* FROM personas as p WHERE per_apellido LIKE {0} ", Apellido)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Pad
                    .id = dr(pID)
                    If dr(pNombre) IsNot DBNull.Value Then .nombre = dr(pNombre)
                    If dr(pApellido) IsNot DBNull.Value Then .apellido = dr(pApellido)
                    If dr(pFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(pFechaNacimiento)
                    If dr(pDNI) IsNot DBNull.Value Then .dni = dr(pDNI)
                    If dr(pDomicilio) IsNot DBNull.Value Then .domicilio = dr(pDomicilio)
                    If dr(pLocalidad) IsNot DBNull.Value Then .localidad = dr(pLocalidad)
                    If dr(pTelefono) IsNot DBNull.Value Then .telefono = dr(pTelefono)
                    If dr(pCelular) IsNot DBNull.Value Then .celular = dr(pCelular)
                    If dr(pMail) IsNot DBNull.Value Then .mail = dr(pMail)
                    If dr(pNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(pNivelEscolaridad)
                    If dr(pEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(pEstadoCivil)
                    If dr(pOcupacion) IsNot DBNull.Value Then .ocupacion = dr(pOcupacion)
                    If dr(pEmpresa) IsNot DBNull.Value Then .empresa = dr(pEmpresa)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_DNI(ByRef DNI As String, ByRef Pad As Padre, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.* FROM personas as p WHERE p.per_dni LIKE {0} ", DNI)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Pad
                    .id = dr(pID)
                    If dr(pNombre) IsNot DBNull.Value Then .nombre = dr(pNombre)
                    If dr(pApellido) IsNot DBNull.Value Then .apellido = dr(pApellido)
                    If dr(pFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(pFechaNacimiento)
                    If dr(pDNI) IsNot DBNull.Value Then .dni = dr(pDNI)
                    If dr(pDomicilio) IsNot DBNull.Value Then .domicilio = dr(pDomicilio)
                    If dr(pLocalidad) IsNot DBNull.Value Then .localidad = dr(pLocalidad)
                    If dr(pTelefono) IsNot DBNull.Value Then .telefono = dr(pTelefono)
                    If dr(pCelular) IsNot DBNull.Value Then .celular = dr(pCelular)
                    If dr(pMail) IsNot DBNull.Value Then .mail = dr(pMail)
                    If dr(pNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(pNivelEscolaridad)
                    If dr(pEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(pEstadoCivil)
                    If dr(pOcupacion) IsNot DBNull.Value Then .ocupacion = dr(pOcupacion)
                    If dr(pEmpresa) IsNot DBNull.Value Then .empresa = dr(pEmpresa)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_ID(ByRef ID As String, ByRef Pad As Padre, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.* FROM personas as p WHERE p.per_id = {0} ", ID)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Pad
                    .id = dr(pID)
                    If dr(pNombre) IsNot DBNull.Value Then .nombre = dr(pNombre)
                    If dr(pApellido) IsNot DBNull.Value Then .apellido = dr(pApellido)
                    If dr(pFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(pFechaNacimiento)
                    If dr(pDNI) IsNot DBNull.Value Then .dni = dr(pDNI)
                    If dr(pDomicilio) IsNot DBNull.Value Then .domicilio = dr(pDomicilio)
                    If dr(pLocalidad) IsNot DBNull.Value Then .localidad = dr(pLocalidad)
                    If dr(pTelefono) IsNot DBNull.Value Then .telefono = dr(pTelefono)
                    If dr(pCelular) IsNot DBNull.Value Then .celular = dr(pCelular)
                    If dr(pMail) IsNot DBNull.Value Then .mail = dr(pMail)
                    If dr(pNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(pNivelEscolaridad)
                    If dr(pEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(pEstadoCivil)
                    If dr(pOcupacion) IsNot DBNull.Value Then .ocupacion = dr(pOcupacion)
                    If dr(pEmpresa) IsNot DBNull.Value Then .empresa = dr(pEmpresa)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Existe(ByVal DNI As String, Optional ByVal bd As Boolean = True) As Boolean
        Dim B As Boolean = True
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM personas as p WHERE p.per_dni LIKE {0}", DNI)
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

    Public Function Agregar(ByVal pad As Padre) As Integer
        Dim con As New cBaseDatos
        Dim result As Integer
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As New DataSet
        Dim SQL As String = String.Format("INSERT INTO `personas` (`per_id`, `per_nombre`, `per_apellido`, `per_fecnac`, `per_dni`, `per_domicilio`, `loc_id`, `per_telefono`, `per_celular`, `per_mail`, `per_nivelesc`, `per_estadocivil`, `per_ocupacion`, `per_empresa`) VALUES (NULL, '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                                          pad.nombre, pad.apellido, pad.fechanacimiento, pad.dni, pad.domicilio, pad.localidad, pad.telefono, pad.celular, pad.mail, pad.nivelescolaridad, pad.estadocivil, pad.ocupacion, pad.empresa)
        Dim SQL2 As String = "SELECT MAX(p.per_id) FROM personas as p"
        Try
            ' Agregar en el via 1
            con.AbrirConexion(True)
            result = con.EjecutarComando(SQL)
            con.EjecutarConsulta(SQL2)
            con.CerrarConexion()

            ' Agregar en el via2
            con.AbrirConexion(False)
            result = con.EjecutarComando(SQL)
            DA = con.EjecutarConsulta(SQL2)
            con.CerrarConexion()

            DA.Fill(DS)

            If Not DS.Tables(0).Rows.Count = 0 Then
                result = Convert.ToInt32(DS.Tables(0).Rows(0).ItemArray(0))
            Else
                MsgBox(Cts.msgErrSinResultados)
            End If
            Return result

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Editar(ByVal pad As Padre) As Integer
        Dim result As Integer
        'Dim temp As Date = Date.Parse(pad.fechanacimiento)
        'Dim temp As Date = Date.ParseExact(pad.fechanacimiento, "yyyy-MM-dd", culture, style)
        Dim SQL As String = String.Format("UPDATE personas SET per_nombre = '{0}', per_apellido = '{1}', per_fecnac = '{2}', per_dni = '{3}', per_domicilio = '{4}', loc_id = '{5}', per_telefono = '{6}', per_celular = '{7}', per_mail = '{8}', per_nivelesc = '{9}', per_estadocivil = '{10}', per_ocupacion = '{11}', per_empresa= '{12}' WHERE per_id = {13}",
                                          pad.nombre, pad.apellido, pad.fechanacimiento, pad.dni, pad.domicilio, pad.localidad, pad.telefono, pad.celular, pad.mail, pad.nivelescolaridad, pad.estadocivil, pad.ocupacion, pad.empresa, pad.id)
        Dim con As New cBaseDatos
        Try
            'actualiza el via 1
            con.AbrirConexion(True)
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
            'actualiza en via2
            con.AbrirConexion(False)
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    'Devuelve el id y el nombre de las localidades
    Public Function Localidades(Optional ByVal bd As Boolean = True) As DataSet
        'Dim combo As ComboBox
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT loc_id, loc_nombre FROM localidades")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function
End Class

