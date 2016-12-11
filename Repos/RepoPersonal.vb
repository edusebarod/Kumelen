Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoPersonal
    Private eID As String = "emp_id"
    Private ePerid As String = "per_id"
    Private eNombre As String = "per_nombre"
    Private eApellido As String = "per_apellido"
    Private eFechaNacimiento As String = "per_fecnac"
    Private eLugarNacimiento As String = "per_lugnac"
    Private eDNI As String = "per_dni"
    Private eSexo As String = "per_sexo"
    Private eNacionalidad As String = "per_nacionalidad"
    Private eDomicilio As String = "per_domicilio"
    Private eCP As String = "per_cp"
    Private eLocalidad As String = "loc_id"
    Private eTelefono As String = "per_telefono"
    Private eCelular As String = "per_celular"
    Private eMail As String = "per_mail"
    Private eNivelEscolaridad As String = "per_nivelesc"
    Private eEstadoCivil As String = "per_estadocivil"
    Private eOcupacion As String = "per_ocupacion"
    Private eDomicilioLaboral As String = "per_domlaboral"
    Private eEmpresa As String = "per_empresa"
    Private eCUIL As String = "per_cuil"
    Private eHoras As String = "emp_horas"
    Private eCargo As String = "emp_cargo"
    Private eFechaIngreso As String = "emp_fingreso"
    Private eTipo As String = "emp_tipo"
    Private eObservaciones As String = "emp_obse"
    Private eActivo As String = "emp_activo"

    Public Function Traer_X_Apellido(ByRef Apellido As String, ByRef Emp As Personal, Optional ByVal db As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.*, e.* FROM empleados as e, personas as p WHERE e.per_id = p.per_id AND per_apellido LIKE {0} ", Apellido)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Emp
                    If dr(eID) IsNot DBNull.Value Then .id = dr(eID)
                    If dr(ePerid) IsNot DBNull.Value Then .perid = dr(ePerid)
                    If dr(eNombre) IsNot DBNull.Value Then .nombre = dr(eNombre)
                    If dr(eApellido) IsNot DBNull.Value Then .apellido = dr(eApellido)
                    If dr(eFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(eFechaNacimiento).ToString()
                    If dr(eLugarNacimiento) IsNot DBNull.Value Then .lugarnacimiento = dr(eLugarNacimiento)
                    If dr(eDNI) IsNot DBNull.Value Then .dni = dr(eDNI)
                    If dr(eSexo) IsNot DBNull.Value Then .sexo = dr(eSexo)
                    If dr(eNacionalidad) IsNot DBNull.Value Then .nacionalidad = dr(eNacionalidad)
                    If dr(eDomicilio) IsNot DBNull.Value Then .domicilio = dr(eDomicilio)
                    If dr(eCP) IsNot DBNull.Value Then .cp = dr(eCP)
                    If dr(eLocalidad) IsNot DBNull.Value Then .localidad = dr(eLocalidad)
                    If dr(eTelefono) IsNot DBNull.Value Then .telefono = dr(eTelefono)
                    If dr(eCelular) IsNot DBNull.Value Then .celular = dr(eCelular)
                    If dr(eMail) IsNot DBNull.Value Then .mail = dr(eMail)
                    If dr(eNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(eNivelEscolaridad)
                    If dr(eEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(eEstadoCivil)
                    If dr(eOcupacion) IsNot DBNull.Value Then .ocupacion = dr(eOcupacion)
                    If dr(eDomicilioLaboral) IsNot DBNull.Value Then .domiciliolaboral = dr(eDomicilioLaboral)
                    If dr(eEmpresa) IsNot DBNull.Value Then .empresa = dr(eEmpresa)
                    If dr(eCUIL) IsNot DBNull.Value Then .cuil = dr(eCUIL)
                    If dr(eHoras) IsNot DBNull.Value Then .horas = dr(eHoras)
                    If dr(eCargo) IsNot DBNull.Value Then .cargo = dr(eCargo)
                    If dr(eFechaIngreso) IsNot DBNull.Value Then .fechaIngreso = dr(eFechaIngreso).ToString
                    If dr(eTipo) IsNot DBNull.Value Then .tipo = dr(eTipo)
                    If dr(eFechaIngreso) IsNot DBNull.Value Then .observaciones = dr(eFechaIngreso)
                    If dr(eActivo) IsNot DBNull.Value Then .activo = dr(eActivo)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_DNI(ByRef DNI As String, ByRef Emp As Personal, Optional ByVal db As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.*, e.* FROM empleados as e, personas as p WHERE e.per_id = p.per_id AND p.per_dni LIKE {0} ", DNI)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Emp
                    If dr(eID) IsNot DBNull.Value Then .id = dr(eID)
                    If dr(ePerid) IsNot DBNull.Value Then .perid = dr(ePerid)
                    If dr(eNombre) IsNot DBNull.Value Then .nombre = dr(eNombre)
                    If dr(eApellido) IsNot DBNull.Value Then .apellido = dr(eApellido)
                    If dr(eFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(eFechaNacimiento).ToString()
                    If dr(eLugarNacimiento) IsNot DBNull.Value Then .lugarnacimiento = dr(eLugarNacimiento)
                    If dr(eDNI) IsNot DBNull.Value Then .dni = dr(eDNI)
                    If dr(eSexo) IsNot DBNull.Value Then .sexo = dr(eSexo)
                    If dr(eNacionalidad) IsNot DBNull.Value Then .nacionalidad = dr(eNacionalidad)
                    If dr(eDomicilio) IsNot DBNull.Value Then .domicilio = dr(eDomicilio)
                    If dr(eCP) IsNot DBNull.Value Then .cp = dr(eCP)
                    If dr(eLocalidad) IsNot DBNull.Value Then .localidad = dr(eLocalidad)
                    If dr(eTelefono) IsNot DBNull.Value Then .telefono = dr(eTelefono)
                    If dr(eCelular) IsNot DBNull.Value Then .celular = dr(eCelular)
                    If dr(eMail) IsNot DBNull.Value Then .mail = dr(eMail)
                    If dr(eNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(eNivelEscolaridad)
                    If dr(eEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(eEstadoCivil)
                    If dr(eOcupacion) IsNot DBNull.Value Then .ocupacion = dr(eOcupacion)
                    If dr(eDomicilioLaboral) IsNot DBNull.Value Then .domiciliolaboral = dr(eDomicilioLaboral)
                    If dr(eEmpresa) IsNot DBNull.Value Then .empresa = dr(eEmpresa)
                    If dr(eCUIL) IsNot DBNull.Value Then .cuil = dr(eCUIL)
                    If dr(eHoras) IsNot DBNull.Value Then .horas = dr(eHoras)
                    If dr(eCargo) IsNot DBNull.Value Then .cargo = dr(eCargo)
                    If dr(eFechaIngreso) IsNot DBNull.Value Then .fechaIngreso = dr(eFechaIngreso).ToString
                    If dr(eTipo) IsNot DBNull.Value Then .tipo = dr(eTipo)
                    If dr(eFechaIngreso) IsNot DBNull.Value Then .observaciones = dr(eFechaIngreso)
                    If dr(eActivo) IsNot DBNull.Value Then .activo = dr(eActivo)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_id(ByRef id As Integer, ByRef Emp As Personal, Optional ByVal db As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.*, e.* FROM empleados as e, personas as p WHERE e.per_id = p.per_id AND p.per_id = {0} ", id)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Emp
                    If dr(eID) IsNot DBNull.Value Then .id = dr(eID)
                    If dr(ePerid) IsNot DBNull.Value Then .perid = dr(ePerid)
                    If dr(eNombre) IsNot DBNull.Value Then .nombre = dr(eNombre)
                    If dr(eApellido) IsNot DBNull.Value Then .apellido = dr(eApellido)
                    If dr(eFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(eFechaNacimiento).ToString()
                    If dr(eLugarNacimiento) IsNot DBNull.Value Then .lugarnacimiento = dr(eLugarNacimiento)
                    If dr(eDNI) IsNot DBNull.Value Then .dni = dr(eDNI)
                    If dr(eSexo) IsNot DBNull.Value Then .sexo = dr(eSexo)
                    If dr(eNacionalidad) IsNot DBNull.Value Then .nacionalidad = dr(eNacionalidad)
                    If dr(eDomicilio) IsNot DBNull.Value Then .domicilio = dr(eDomicilio)
                    If dr(eCP) IsNot DBNull.Value Then .cp = dr(eCP)
                    If dr(eLocalidad) IsNot DBNull.Value Then .localidad = dr(eLocalidad)
                    If dr(eTelefono) IsNot DBNull.Value Then .telefono = dr(eTelefono)
                    If dr(eCelular) IsNot DBNull.Value Then .celular = dr(eCelular)
                    If dr(eMail) IsNot DBNull.Value Then .mail = dr(eMail)
                    If dr(eNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(eNivelEscolaridad)
                    If dr(eEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(eEstadoCivil)
                    If dr(eOcupacion) IsNot DBNull.Value Then .ocupacion = dr(eOcupacion)
                    If dr(eDomicilioLaboral) IsNot DBNull.Value Then .domiciliolaboral = dr(eDomicilioLaboral)
                    If dr(eEmpresa) IsNot DBNull.Value Then .empresa = dr(eEmpresa)
                    If dr(eCUIL) IsNot DBNull.Value Then .cuil = dr(eCUIL)
                    If dr(eHoras) IsNot DBNull.Value Then .horas = dr(eHoras)
                    If dr(eCargo) IsNot DBNull.Value Then .cargo = dr(eCargo)
                    If dr(eFechaIngreso) IsNot DBNull.Value Then .fechaIngreso = dr(eFechaIngreso).ToString
                    If dr(eTipo) IsNot DBNull.Value Then .tipo = dr(eTipo)
                    If dr(eObservaciones) IsNot DBNull.Value Then .observaciones = dr(eObservaciones)
                    If dr(eActivo) IsNot DBNull.Value Then .activo = dr(eActivo)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Existe(ByVal DNI As String, Optional ByVal db As Boolean = True) As Boolean
        Dim B As Boolean = True
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM empleados as e, personas as p WHERE e.per_id = p.per_id AND p.per_id = {0}", DNI)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            con.AbrirConexion(db)
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

    Public Function Agregar(ByVal per As Personal, Optional ByVal db As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim result As Integer
        Dim id As Integer
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim SQL As String = String.Format("INSERT INTO `kumelen`.`personas` (`per_id`, `per_nombre`, `per_apellido`, `per_fecnac`, `per_lugnac`, `per_dni`, `per_sexo`, `per_nacionalidad`, `per_domicilio`, `per_CP`, `loc_id`, `per_telefono`, `per_celular`, `per_mail`, `per_nivelesc`, `per_estadocivil`, `per_ocupacion`, `per_domlaboral`, `per_empresa`, `per_cuil`) VALUES (NULL, '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}')",
                                          per.nombre, per.apellido, per.fechanacimiento, per.lugarnacimiento, per.dni, per.sexo, per.nacionalidad, per.domicilio, per.cp, per.localidad, per.telefono, per.celular, per.mail, per.nivelescolaridad, per.estadocivil, per.ocupacion, per.domiciliolaboral, per.empresa, per.cuil)
        'tengo que sacar el id de la persona agregada
        Dim SQL2 As String = "SELECT MAX(per_id) FROM `personas`"

        Try
            con.AbrirConexion(db)
            result = con.EjecutarComando(SQL)
            DA = con.EjecutarConsulta(SQL2)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS)
        If DS.Tables(0).Rows.Count = 0 Then
            MsgBox(Cts.msgErrSinResultados)
        Else
            id = Convert.ToInt32(DS.Tables(0).Rows(0).ItemArray(0))

            Dim SQL3 As String = String.Format("INSERT INTO `kumelen`.`empleados` (`per_id`, `emp_horas`, `emp_cargo`, `emp_fingreso`, `emp_tipo`, `emp_obse`, `emp_activo`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                              id, per.horas, per.cargo, per.fechaIngreso, per.tipo, per.observaciones, per.activo)

            Try
                con.AbrirConexion(db)
                result = con.EjecutarComando(SQL3)
                con.CerrarConexion()
                Return result
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End If
    End Function

    Public Function Editar(ByVal per As Personal, Optional ByVal db As Boolean = True) As Integer
        Dim result As Integer
        Dim SQL As String = String.Format("UPDATE empleados SET emp_horas = '{0}', emp_cargo= '{1}', emp_fingreso= '{2}', emp_tipo= '{3}', emp_obse= '{4}', emp_activo= '{5}' WHERE emp_id = {6}",
                                          per.horas, per.cargo, per.fechaIngreso, per.tipo, per.observaciones, per.activo, per.id)
        Dim SQL2 As String = String.Format("UPDATE personas SET per_nombre = '{0}', per_apellido = '{1}', per_fecnac = '{2}', per_lugnac = '{3}', per_dni = '{4}', per_sexo = '{5}', per_domicilio = '{6}', loc_id = '{7}' WHERE per_id = {8}",
                                          per.nombre, per.apellido, per.fechanacimiento, per.lugarnacimiento, per.dni, per.sexo, per.domicilio, per.localidad, per.id)
        Dim con As New cBaseDatos
        Try
            con.AbrirConexion(db)
            result = con.EjecutarComando(SQL)
            result = con.EjecutarComando(SQL2)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    'Devuelve el id y el nombre de las localidades
    Public Function Localidades(Optional ByVal db As Boolean = True) As DataSet
        'Dim combo As ComboBox
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT loc_id, loc_nombre FROM localidades")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(db)
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
