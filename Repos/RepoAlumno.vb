Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoAlumno
    Private aID As String = "per_id"
    Private alegajo As String = "alu_legajo"
    Private aEnfermedades As String = "alu_enfermedades"
    Private aAlergias As String = "alu_alergias"
    Private aMedicacion As String = "alu_medicacion"
    Private aObservaciones As String = "alu_observaciones"
    Private aMadre As String = "alu_madre"
    Private aPadre As String = "alu_padre"
    Private aFechaBaja As String = "alu_fechabaja"
    Private aFechaAlta As String = "alu_fechaalta"
    Private aActivo As String = "alu_activo"
    Private aBaja As String = "alu_baja"
    Private aCiclo As String = "alu_ciclo"
    Private aTipo As String = "alu_tipo"
    Private aCurso As String = "alu_curso"
    Private aAnoLectivo As String = "alu_anolectivo"
    Private aTurno As String = "alu_turno"
    Private aHorario As String = "alu_horario"
    Private aObraSocial As String = "alu_obrasocial"
    Private aSalud As String = "alu_salud"
    Private aVivienda As String = "alu_vivienda"
    Private aPatio As String = "alu_patio"
    Private aEspacioVerde As String = "alu_espacioverde"
    Private aAnimales As String = "alu_animales"
    Private aPlantas As String = "alu_plantas"
    Private aRelacionPlantas As String = "alu_relacionplantas"
    Private aJuegos As String = "alu_juegos"
    Private aDescuento As String = "alu_descuento"
    Private aServDescuento As String = "alu_servdescuento"
    Private aExperiencia As String = "alu_experiencia"
    Private aTiempo As String = "alu_tiempo"
    Private aLugarExperiencia As String = "alu_lugarexp"
    Private aPersonasRetiro As String = "alu_perRetiro"
    Private aNombre As String = "per_nombre"
    Private aApellido As String = "per_apellido"
    Private aFechaNacimiento As String = "per_fecnac"
    Private aLugarNacimiento As String = "per_lugnac"
    Private aDNI As String = "per_dni"
    Private aSexo As String = "per_sexo"
    Private aNacionalidad As String = "per_nacionalidad"
    Private aDomicilio As String = "per_domicilio"
    Private aCP As String = "per_cp"
    Private aLocalidad As String = "loc_id"
    Private aTelefono As String = "per_telefono"
    Private aCelular As String = "per_celular"
    Private aMail As String = "per_mail"
    Private aNivelEscolaridad As String = "per_nivelesc"
    Private aEstadoCivil As String = "per_estadocivil"
    Private aOcupacion As String = "per_ocupacion"
    Private aDomicilioLaboral As String = "per_domlaboral"
    Private aEmpresa As String = "per_empresa"
    Private aCUIL As String = "per_cuil"
    Private aFotocopiaDNI As String = "alu_fDNI"
    Private aFotocopiaDNIPadre As String = "alu_fDNIpadre"
    Private aFotocopiaDNIMadre As String = "alu_fDNImadre"
    Private aFotocarnet As String = "alu_fotocarnet"
    Private aCertificadoSalud As String = "alu_certifsalud"
    Private aFotocopiaIPE As String = "alu_fIPE"
    Private aEntrevistaDOE As String = "alu_entrevistaDOE"
    Private aFichaMedica As String = "alu_fichaMedica"
    Private aAudiometria As String = "alu_audiometria"
    Private aCertificadoBD As String = "alu_certificadoBD"
    Private aTutor As String = "alu_tutor"
    Private aFotocopiaCarnetVacunacion As String = "alu_fCarnetVacun"
    Private aActaCompromidoFirmada As String = "alu_ActaCompFirmada"
    Private aHorarioFirmado As String = "alu_HorarioFirmado"
    Private aJELunes As String = "alu_jeLunes"
    Private aJEMartes As String = "alu_jeMartes"
    Private aJEMiercoles As String = "alu_jeMiercoles"
    Private aJEJueves As String = "alu_jeJueves"
    Private aJEViernes As String = "alu_jeViernes"

    Public Function Traer_X_Apellido(ByRef Apellido As String, ByRef Alu As Alumno, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.*, a.* FROM alumnos as a, personas as p WHERE a.per_id = p.per_id AND per_apellido LIKE {0} AND a.alu_baja = 0", Apellido)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Alu
                    .id = dr(aID)
                    .legajo = dr(alegajo)
                    If dr(aEnfermedades) IsNot DBNull.Value Then .enfermedades = dr(aEnfermedades)
                    If dr(aAlergias) IsNot DBNull.Value Then .alergias = dr(aAlergias)
                    If dr(aMedicacion) IsNot DBNull.Value Then .medicacion = dr(aMedicacion)
                    If dr(aObservaciones) IsNot DBNull.Value Then .observaciones = dr(aObservaciones)
                    If dr(aPadre) IsNot DBNull.Value Then .padre = dr(aPadre)
                    If dr(aMadre) IsNot DBNull.Value Then .madre = dr(aMadre)
                    If dr(aFechaAlta).ToString() IsNot DBNull.Value Then .fechaalta = dr(aFechaAlta).ToString()
                    If dr(aFechaBaja).ToString() IsNot DBNull.Value Then .fechabaja = dr(aFechaBaja).ToString()
                    If dr(aActivo) IsNot DBNull.Value Then .activo = dr(aActivo)
                    If dr(aBaja) IsNot DBNull.Value Then .baja = dr(aBaja)
                    If dr(aCiclo) IsNot DBNull.Value Then .ciclo = dr(aCiclo)
                    If dr(aTipo) IsNot DBNull.Value Then .tipo = dr(aTipo)
                    If dr(aCurso) IsNot DBNull.Value Then .curso = dr(aCurso)
                    If dr(aAnoLectivo) IsNot DBNull.Value Then .anolectivo = dr(aAnoLectivo)
                    If dr(aTurno) IsNot DBNull.Value Then .turno = dr(aTurno)
                    If dr(aHorario) IsNot DBNull.Value Then .horario = dr(aHorario)
                    If dr(aObraSocial) IsNot DBNull.Value Then .obrasocial = dr(aObraSocial)
                    If dr(aSalud) IsNot DBNull.Value Then .salud = dr(aSalud)
                    If dr(aVivienda) IsNot DBNull.Value Then .vivienda = dr(aVivienda)
                    If dr(aPatio) IsNot DBNull.Value Then .patio = dr(aPatio)
                    If dr(aEspacioVerde) IsNot DBNull.Value Then .espacioverde = dr(aEspacioVerde)
                    If dr(aAnimales) IsNot DBNull.Value Then .animales = dr(aAnimales)
                    If dr(aPlantas) IsNot DBNull.Value Then .plantas = dr(aPlantas)
                    If dr(aRelacionPlantas) IsNot DBNull.Value Then .relacionplantas = dr(aRelacionPlantas)
                    If dr(aJuegos) IsNot DBNull.Value Then .juegos = dr(aJuegos)
                    If dr(aExperiencia) IsNot DBNull.Value Then .experiencia = dr(aExperiencia)
                    If dr(aTiempo) IsNot DBNull.Value Then .tiempo = dr(aTiempo)
                    If dr(aLugarExperiencia) IsNot DBNull.Value Then .lugarexperiencia = dr(aLugarExperiencia)
                    If dr(aPersonasRetiro) IsNot DBNull.Value Then .personasretiro = dr(aPersonasRetiro)
                    If dr(aDescuento) IsNot DBNull.Value Then .descuento = dr(aDescuento)
                    If dr(aServDescuento) IsNot DBNull.Value Then .servdescuento = dr(aServDescuento)
                    If dr(aNombre) IsNot DBNull.Value Then .nombre = dr(aNombre)
                    If dr(aApellido) IsNot DBNull.Value Then .apellido = dr(aApellido)
                    If dr(aFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(aFechaNacimiento)
                    If dr(aLugarNacimiento) IsNot DBNull.Value Then .lugarnacimiento = dr(aLugarNacimiento)
                    If dr(aDNI) IsNot DBNull.Value Then .dni = dr(aDNI)
                    If dr(aSexo) IsNot DBNull.Value Then .sexo = dr(aSexo)
                    If dr(aNacionalidad) IsNot DBNull.Value Then .nacionalidad = dr(aNacionalidad)
                    If dr(aDomicilio) IsNot DBNull.Value Then .domicilio = dr(aDomicilio)
                    If dr(aCP) IsNot DBNull.Value Then .cp = dr(aCP)
                    If dr(aLocalidad) IsNot DBNull.Value Then .localidad = dr(aLocalidad)
                    If dr(aTelefono) IsNot DBNull.Value Then .telefono = dr(aTelefono)
                    If dr(aCelular) IsNot DBNull.Value Then .celular = dr(aCelular)
                    If dr(aMail) IsNot DBNull.Value Then .mail = dr(aMail)
                    If dr(aNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(aNivelEscolaridad)
                    If dr(aEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(aEstadoCivil)
                    If dr(aOcupacion) IsNot DBNull.Value Then .ocupacion = dr(aOcupacion)
                    If dr(aDomicilioLaboral) IsNot DBNull.Value Then .domiciliolaboral = dr(aDomicilioLaboral)
                    If dr(aEmpresa) IsNot DBNull.Value Then .empresa = dr(aEmpresa)
                    If dr(aCUIL) IsNot DBNull.Value Then .cuil = dr(aCUIL)
                    If dr(aFotocopiaDNI) IsNot DBNull.Value Then .fotocopiaDNI = dr(aFotocopiaDNI)
                    If dr(aFotocopiaDNIPadre) IsNot DBNull.Value Then .fotocopiaDNIPadre = dr(aFotocopiaDNIPadre)
                    If dr(aFotocopiaDNIMadre) IsNot DBNull.Value Then .fotocopiaDNIMadre = dr(aFotocopiaDNIMadre)
                    If dr(aFotocarnet) IsNot DBNull.Value Then .fotocarnet = dr(aFotocarnet)
                    If dr(aCertificadoSalud) IsNot DBNull.Value Then .certificadoSalud = dr(aCertificadoSalud)
                    If dr(aFotocopiaIPE) IsNot DBNull.Value Then .fotocopiaIPE = dr(aFotocopiaIPE)
                    If dr(aEntrevistaDOE) IsNot DBNull.Value Then .entrevistaDOE = dr(aEntrevistaDOE)
                    If dr(aFichaMedica) IsNot DBNull.Value Then .fichaMedica = dr(aFichaMedica)
                    If dr(aAudiometria) IsNot DBNull.Value Then .audiometria = dr(aAudiometria)
                    If dr(aCertificadoBD) IsNot DBNull.Value Then .certificadoBD = dr(aCertificadoBD)
                    If dr(aTutor) IsNot DBNull.Value Then .tutor = dr(aTutor)
                    If dr(aFotocopiaCarnetVacunacion) IsNot DBNull.Value Then .fotocopiaCarnetVacunacion = dr(aFotocopiaCarnetVacunacion)
                    If dr(aActaCompromidoFirmada) IsNot DBNull.Value Then .ActaCompromisoFirmado = dr(aActaCompromidoFirmada)
                    If dr(aHorarioFirmado) IsNot DBNull.Value Then .HorarioFirmado = dr(aHorarioFirmado)
                    If dr(aJELunes) IsNot DBNull.Value Then .JELunes = dr(aJELunes)
                    If dr(aJEMartes) IsNot DBNull.Value Then .JEMartes = dr(aJEMartes)
                    If dr(aJEMiercoles) IsNot DBNull.Value Then .JEMiercoles = dr(aJEMiercoles)
                    If dr(aJEJueves) IsNot DBNull.Value Then .JEJueves = dr(aJEJueves)
                    If dr(aJEViernes) IsNot DBNull.Value Then .JEViernes = dr(aJEViernes)

                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_Legajo(ByRef ID As Integer, ByRef Alu As Alumno, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.*, a.* FROM alumnos as a, personas as p WHERE a.per_id = p.per_id AND alu_legajo = {0} AND a.alu_activo = 1 AND a.alu_baja = 0", ID)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Alu
                    .id = dr(aID)
                    .legajo = dr(alegajo)
                    If dr(aEnfermedades) IsNot DBNull.Value Then .enfermedades = dr(aEnfermedades)
                    If dr(aAlergias) IsNot DBNull.Value Then .alergias = dr(aAlergias)
                    If dr(aMedicacion) IsNot DBNull.Value Then .medicacion = dr(aMedicacion)
                    If dr(aObservaciones) IsNot DBNull.Value Then .observaciones = dr(aObservaciones)
                    If dr(aPadre) IsNot DBNull.Value Then .padre = dr(aPadre)
                    If dr(aMadre) IsNot DBNull.Value Then .madre = dr(aMadre)
                    If dr(aFechaAlta).ToString() IsNot DBNull.Value Then .fechaalta = dr(aFechaAlta).ToString()
                    If dr(aFechaBaja).ToString() IsNot DBNull.Value Then .fechabaja = dr(aFechaBaja).ToString()
                    If dr(aActivo) IsNot DBNull.Value Then .activo = dr(aActivo)
                    If dr(aBaja) IsNot DBNull.Value Then .baja = dr(aBaja)
                    If dr(aCiclo) IsNot DBNull.Value Then .ciclo = dr(aCiclo)
                    If dr(aTipo) IsNot DBNull.Value Then .tipo = dr(aTipo)
                    If dr(aCurso) IsNot DBNull.Value Then .curso = dr(aCurso)
                    If dr(aAnoLectivo) IsNot DBNull.Value Then .anolectivo = dr(aAnoLectivo)
                    If dr(aTurno) IsNot DBNull.Value Then .turno = dr(aTurno)
                    If dr(aHorario) IsNot DBNull.Value Then .horario = dr(aHorario)
                    If dr(aObraSocial) IsNot DBNull.Value Then .obrasocial = dr(aObraSocial)
                    If dr(aSalud) IsNot DBNull.Value Then .salud = dr(aSalud)
                    If dr(aVivienda) IsNot DBNull.Value Then .vivienda = dr(aVivienda)
                    If dr(aPatio) IsNot DBNull.Value Then .patio = dr(aPatio)
                    If dr(aEspacioVerde) IsNot DBNull.Value Then .espacioverde = dr(aEspacioVerde)
                    If dr(aAnimales) IsNot DBNull.Value Then .animales = dr(aAnimales)
                    If dr(aPlantas) IsNot DBNull.Value Then .plantas = dr(aPlantas)
                    If dr(aRelacionPlantas) IsNot DBNull.Value Then .relacionplantas = dr(aRelacionPlantas)
                    If dr(aJuegos) IsNot DBNull.Value Then .juegos = dr(aJuegos)
                    If dr(aExperiencia) IsNot DBNull.Value Then .experiencia = dr(aExperiencia)
                    If dr(aTiempo) IsNot DBNull.Value Then .tiempo = dr(aTiempo)
                    If dr(aLugarExperiencia) IsNot DBNull.Value Then .lugarexperiencia = dr(aLugarExperiencia)
                    If dr(aPersonasRetiro) IsNot DBNull.Value Then .personasretiro = dr(aPersonasRetiro)
                    If dr(aDescuento) IsNot DBNull.Value Then .descuento = dr(aDescuento)
                    If dr(aServDescuento) IsNot DBNull.Value Then .servdescuento = dr(aServDescuento)
                    If dr(aNombre) IsNot DBNull.Value Then .nombre = dr(aNombre)
                    If dr(aApellido) IsNot DBNull.Value Then .apellido = dr(aApellido)
                    If dr(aFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(aFechaNacimiento)
                    If dr(aLugarNacimiento) IsNot DBNull.Value Then .lugarnacimiento = dr(aLugarNacimiento)
                    If dr(aDNI) IsNot DBNull.Value Then .dni = dr(aDNI)
                    If dr(aSexo) IsNot DBNull.Value Then .sexo = dr(aSexo)
                    If dr(aNacionalidad) IsNot DBNull.Value Then .nacionalidad = dr(aNacionalidad)
                    If dr(aDomicilio) IsNot DBNull.Value Then .domicilio = dr(aDomicilio)
                    If dr(aCP) IsNot DBNull.Value Then .cp = dr(aCP)
                    If dr(aLocalidad) IsNot DBNull.Value Then .localidad = dr(aLocalidad)
                    If dr(aTelefono) IsNot DBNull.Value Then .telefono = dr(aTelefono)
                    If dr(aCelular) IsNot DBNull.Value Then .celular = dr(aCelular)
                    If dr(aMail) IsNot DBNull.Value Then .mail = dr(aMail)
                    If dr(aNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(aNivelEscolaridad)
                    If dr(aEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(aEstadoCivil)
                    If dr(aOcupacion) IsNot DBNull.Value Then .ocupacion = dr(aOcupacion)
                    If dr(aDomicilioLaboral) IsNot DBNull.Value Then .domiciliolaboral = dr(aDomicilioLaboral)
                    If dr(aEmpresa) IsNot DBNull.Value Then .empresa = dr(aEmpresa)
                    If dr(aCUIL) IsNot DBNull.Value Then .cuil = dr(aCUIL)
                    If dr(aFotocopiaDNI) IsNot DBNull.Value Then .fotocopiaDNI = dr(aFotocopiaDNI)
                    If dr(aFotocopiaDNIPadre) IsNot DBNull.Value Then .fotocopiaDNIPadre = dr(aFotocopiaDNIPadre)
                    If dr(aFotocopiaDNIMadre) IsNot DBNull.Value Then .fotocopiaDNIMadre = dr(aFotocopiaDNIMadre)
                    If dr(aFotocarnet) IsNot DBNull.Value Then .fotocarnet = dr(aFotocarnet)
                    If dr(aCertificadoSalud) IsNot DBNull.Value Then .certificadoSalud = dr(aCertificadoSalud)
                    If dr(aFotocopiaIPE) IsNot DBNull.Value Then .fotocopiaIPE = dr(aFotocopiaIPE)
                    If dr(aEntrevistaDOE) IsNot DBNull.Value Then .entrevistaDOE = dr(aEntrevistaDOE)
                    If dr(aFichaMedica) IsNot DBNull.Value Then .fichaMedica = dr(aFichaMedica)
                    If dr(aAudiometria) IsNot DBNull.Value Then .audiometria = dr(aAudiometria)
                    If dr(aCertificadoBD) IsNot DBNull.Value Then .certificadoBD = dr(aCertificadoBD)
                    If dr(aTutor) IsNot DBNull.Value Then .tutor = dr(aTutor)
                    If dr(aFotocopiaCarnetVacunacion) IsNot DBNull.Value Then .fotocopiaCarnetVacunacion = dr(aFotocopiaCarnetVacunacion)
                    If dr(aActaCompromidoFirmada) IsNot DBNull.Value Then .ActaCompromisoFirmado = dr(aActaCompromidoFirmada)
                    If dr(aHorarioFirmado) IsNot DBNull.Value Then .HorarioFirmado = dr(aHorarioFirmado)
                    If dr(aJELunes) IsNot DBNull.Value Then .JELunes = dr(aJELunes)
                    If dr(aJEMartes) IsNot DBNull.Value Then .JEMartes = dr(aJEMartes)
                    If dr(aJEMiercoles) IsNot DBNull.Value Then .JEMiercoles = dr(aJEMiercoles)
                    If dr(aJEJueves) IsNot DBNull.Value Then .JEJueves = dr(aJEJueves)
                    If dr(aJEViernes) IsNot DBNull.Value Then .JEViernes = dr(aJEViernes)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_ID(ByRef ID As Integer, ByRef Alu As Alumno, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT p.*, a.* FROM alumnos as a, personas as p WHERE a.per_id = p.per_id AND a.per_id = {0} AND a.alu_activo = 1", ID)
        Dim SQL As String = String.Format("SELECT p.*, a.* FROM alumnos as a, personas as p WHERE a.per_id = p.per_id AND a.per_id = {0} AND a.alu_baja = 0", ID)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Alu
                    .id = dr(aID)
                    .legajo = dr(alegajo)
                    If dr(aEnfermedades) IsNot DBNull.Value Then .enfermedades = dr(aEnfermedades)
                    If dr(aAlergias) IsNot DBNull.Value Then .alergias = dr(aAlergias)
                    If dr(aMedicacion) IsNot DBNull.Value Then .medicacion = dr(aMedicacion)
                    If dr(aObservaciones) IsNot DBNull.Value Then .observaciones = dr(aObservaciones)
                    If dr(aPadre) IsNot DBNull.Value Then .padre = dr(aPadre)
                    If dr(aMadre) IsNot DBNull.Value Then .madre = dr(aMadre)
                    If dr(aFechaAlta).ToString() IsNot DBNull.Value Then .fechaalta = dr(aFechaAlta).ToString()
                    If dr(aFechaBaja).ToString() IsNot DBNull.Value Then .fechabaja = dr(aFechaBaja).ToString()
                    If dr(aActivo) IsNot DBNull.Value Then .activo = dr(aActivo)
                    If dr(aBaja) IsNot DBNull.Value Then .baja = dr(aBaja)
                    If dr(aCiclo) IsNot DBNull.Value Then .ciclo = dr(aCiclo)
                    If dr(aTipo) IsNot DBNull.Value Then .tipo = dr(aTipo)
                    If dr(aCurso) IsNot DBNull.Value Then .curso = dr(aCurso)
                    If dr(aAnoLectivo) IsNot DBNull.Value Then .anolectivo = dr(aAnoLectivo)
                    If dr(aTurno) IsNot DBNull.Value Then .turno = dr(aTurno)
                    If dr(aHorario) IsNot DBNull.Value Then .horario = dr(aHorario)
                    If dr(aObraSocial) IsNot DBNull.Value Then .obrasocial = dr(aObraSocial)
                    If dr(aSalud) IsNot DBNull.Value Then .salud = dr(aSalud)
                    If dr(aVivienda) IsNot DBNull.Value Then .vivienda = dr(aVivienda)
                    If dr(aPatio) IsNot DBNull.Value Then .patio = dr(aPatio)
                    If dr(aEspacioVerde) IsNot DBNull.Value Then .espacioverde = dr(aEspacioVerde)
                    If dr(aAnimales) IsNot DBNull.Value Then .animales = dr(aAnimales)
                    If dr(aPlantas) IsNot DBNull.Value Then .plantas = dr(aPlantas)
                    If dr(aRelacionPlantas) IsNot DBNull.Value Then .relacionplantas = dr(aRelacionPlantas)
                    If dr(aJuegos) IsNot DBNull.Value Then .juegos = dr(aJuegos)
                    If dr(aExperiencia) IsNot DBNull.Value Then .experiencia = dr(aExperiencia)
                    If dr(aTiempo) IsNot DBNull.Value Then .tiempo = dr(aTiempo)
                    If dr(aLugarExperiencia) IsNot DBNull.Value Then .lugarexperiencia = dr(aLugarExperiencia)
                    If dr(aPersonasRetiro) IsNot DBNull.Value Then .personasretiro = dr(aPersonasRetiro)
                    If dr(aDescuento) IsNot DBNull.Value Then .descuento = dr(aDescuento)
                    If dr(aServDescuento) IsNot DBNull.Value Then .servdescuento = dr(aServDescuento)
                    If dr(aNombre) IsNot DBNull.Value Then .nombre = dr(aNombre)
                    If dr(aApellido) IsNot DBNull.Value Then .apellido = dr(aApellido)
                    If dr(aFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(aFechaNacimiento)
                    If dr(aLugarNacimiento) IsNot DBNull.Value Then .lugarnacimiento = dr(aLugarNacimiento)
                    If dr(aDNI) IsNot DBNull.Value Then .dni = dr(aDNI)
                    If dr(aSexo) IsNot DBNull.Value Then .sexo = dr(aSexo)
                    If dr(aNacionalidad) IsNot DBNull.Value Then .nacionalidad = dr(aNacionalidad)
                    If dr(aDomicilio) IsNot DBNull.Value Then .domicilio = dr(aDomicilio)
                    If dr(aCP) IsNot DBNull.Value Then .cp = dr(aCP)
                    If dr(aLocalidad) IsNot DBNull.Value Then .localidad = dr(aLocalidad)
                    If dr(aTelefono) IsNot DBNull.Value Then .telefono = dr(aTelefono)
                    If dr(aCelular) IsNot DBNull.Value Then .celular = dr(aCelular)
                    If dr(aMail) IsNot DBNull.Value Then .mail = dr(aMail)
                    If dr(aNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(aNivelEscolaridad)
                    If dr(aEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(aEstadoCivil)
                    If dr(aOcupacion) IsNot DBNull.Value Then .ocupacion = dr(aOcupacion)
                    If dr(aDomicilioLaboral) IsNot DBNull.Value Then .domiciliolaboral = dr(aDomicilioLaboral)
                    If dr(aEmpresa) IsNot DBNull.Value Then .empresa = dr(aEmpresa)
                    If dr(aCUIL) IsNot DBNull.Value Then .cuil = dr(aCUIL)
                    If dr(aFotocopiaDNI) IsNot DBNull.Value Then .fotocopiaDNI = dr(aFotocopiaDNI)
                    If dr(aFotocopiaDNIPadre) IsNot DBNull.Value Then .fotocopiaDNIPadre = dr(aFotocopiaDNIPadre)
                    If dr(aFotocopiaDNIMadre) IsNot DBNull.Value Then .fotocopiaDNIMadre = dr(aFotocopiaDNIMadre)
                    If dr(aFotocarnet) IsNot DBNull.Value Then .fotocarnet = dr(aFotocarnet)
                    If dr(aCertificadoSalud) IsNot DBNull.Value Then .certificadoSalud = dr(aCertificadoSalud)
                    If dr(aFotocopiaIPE) IsNot DBNull.Value Then .fotocopiaIPE = dr(aFotocopiaIPE)
                    If dr(aEntrevistaDOE) IsNot DBNull.Value Then .entrevistaDOE = dr(aEntrevistaDOE)
                    If dr(aFichaMedica) IsNot DBNull.Value Then .fichaMedica = dr(aFichaMedica)
                    If dr(aAudiometria) IsNot DBNull.Value Then .audiometria = dr(aAudiometria)
                    If dr(aCertificadoBD) IsNot DBNull.Value Then .certificadoBD = dr(aCertificadoBD)
                    If dr(aTutor) IsNot DBNull.Value Then .tutor = dr(aTutor)
                    If dr(aFotocopiaCarnetVacunacion) IsNot DBNull.Value Then .fotocopiaCarnetVacunacion = dr(aFotocopiaCarnetVacunacion)
                    If dr(aActaCompromidoFirmada) IsNot DBNull.Value Then .ActaCompromisoFirmado = dr(aActaCompromidoFirmada)
                    If dr(aHorarioFirmado) IsNot DBNull.Value Then .HorarioFirmado = dr(aHorarioFirmado)
                    If dr(aJELunes) IsNot DBNull.Value Then .JELunes = dr(aJELunes)
                    If dr(aJEMartes) IsNot DBNull.Value Then .JEMartes = dr(aJEMartes)
                    If dr(aJEMiercoles) IsNot DBNull.Value Then .JEMiercoles = dr(aJEMiercoles)
                    If dr(aJEJueves) IsNot DBNull.Value Then .JEJueves = dr(aJEJueves)
                    If dr(aJEViernes) IsNot DBNull.Value Then .JEViernes = dr(aJEViernes)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_ID_activo(ByRef ID As Integer, ByRef Alu As Alumno, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.*, a.* FROM alumnos as a, personas as p WHERE a.per_id = p.per_id AND a.per_id = {0} AND a.alu_activo = 1 AND a.alu_baja = 0", ID)
        'Dim SQL As String = String.Format("SELECT p.*, a.* FROM alumnos as a, personas as p WHERE a.per_id = p.per_id AND a.per_id = {0} AND a.alu_baja = 0", ID)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Alu
                    .id = dr(aID)
                    .legajo = dr(alegajo)
                    If dr(aEnfermedades) IsNot DBNull.Value Then .enfermedades = dr(aEnfermedades)
                    If dr(aAlergias) IsNot DBNull.Value Then .alergias = dr(aAlergias)
                    If dr(aMedicacion) IsNot DBNull.Value Then .medicacion = dr(aMedicacion)
                    If dr(aObservaciones) IsNot DBNull.Value Then .observaciones = dr(aObservaciones)
                    If dr(aPadre) IsNot DBNull.Value Then .padre = dr(aPadre)
                    If dr(aMadre) IsNot DBNull.Value Then .madre = dr(aMadre)
                    If dr(aFechaAlta).ToString() IsNot DBNull.Value Then .fechaalta = dr(aFechaAlta).ToString()
                    If dr(aFechaBaja).ToString() IsNot DBNull.Value Then .fechabaja = dr(aFechaBaja).ToString()
                    If dr(aActivo) IsNot DBNull.Value Then .activo = dr(aActivo)
                    If dr(aBaja) IsNot DBNull.Value Then .baja = dr(aBaja)
                    If dr(aCiclo) IsNot DBNull.Value Then .ciclo = dr(aCiclo)
                    If dr(aTipo) IsNot DBNull.Value Then .tipo = dr(aTipo)
                    If dr(aCurso) IsNot DBNull.Value Then .curso = dr(aCurso)
                    If dr(aAnoLectivo) IsNot DBNull.Value Then .anolectivo = dr(aAnoLectivo)
                    If dr(aTurno) IsNot DBNull.Value Then .turno = dr(aTurno)
                    If dr(aHorario) IsNot DBNull.Value Then .horario = dr(aHorario)
                    If dr(aObraSocial) IsNot DBNull.Value Then .obrasocial = dr(aObraSocial)
                    If dr(aSalud) IsNot DBNull.Value Then .salud = dr(aSalud)
                    If dr(aVivienda) IsNot DBNull.Value Then .vivienda = dr(aVivienda)
                    If dr(aPatio) IsNot DBNull.Value Then .patio = dr(aPatio)
                    If dr(aEspacioVerde) IsNot DBNull.Value Then .espacioverde = dr(aEspacioVerde)
                    If dr(aAnimales) IsNot DBNull.Value Then .animales = dr(aAnimales)
                    If dr(aPlantas) IsNot DBNull.Value Then .plantas = dr(aPlantas)
                    If dr(aRelacionPlantas) IsNot DBNull.Value Then .relacionplantas = dr(aRelacionPlantas)
                    If dr(aJuegos) IsNot DBNull.Value Then .juegos = dr(aJuegos)
                    If dr(aExperiencia) IsNot DBNull.Value Then .experiencia = dr(aExperiencia)
                    If dr(aTiempo) IsNot DBNull.Value Then .tiempo = dr(aTiempo)
                    If dr(aLugarExperiencia) IsNot DBNull.Value Then .lugarexperiencia = dr(aLugarExperiencia)
                    If dr(aPersonasRetiro) IsNot DBNull.Value Then .personasretiro = dr(aPersonasRetiro)
                    If dr(aDescuento) IsNot DBNull.Value Then .descuento = dr(aDescuento)
                    If dr(aServDescuento) IsNot DBNull.Value Then .servdescuento = dr(aServDescuento)
                    If dr(aNombre) IsNot DBNull.Value Then .nombre = dr(aNombre)
                    If dr(aApellido) IsNot DBNull.Value Then .apellido = dr(aApellido)
                    If dr(aFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(aFechaNacimiento)
                    If dr(aLugarNacimiento) IsNot DBNull.Value Then .lugarnacimiento = dr(aLugarNacimiento)
                    If dr(aDNI) IsNot DBNull.Value Then .dni = dr(aDNI)
                    If dr(aSexo) IsNot DBNull.Value Then .sexo = dr(aSexo)
                    If dr(aNacionalidad) IsNot DBNull.Value Then .nacionalidad = dr(aNacionalidad)
                    If dr(aDomicilio) IsNot DBNull.Value Then .domicilio = dr(aDomicilio)
                    If dr(aCP) IsNot DBNull.Value Then .cp = dr(aCP)
                    If dr(aLocalidad) IsNot DBNull.Value Then .localidad = dr(aLocalidad)
                    If dr(aTelefono) IsNot DBNull.Value Then .telefono = dr(aTelefono)
                    If dr(aCelular) IsNot DBNull.Value Then .celular = dr(aCelular)
                    If dr(aMail) IsNot DBNull.Value Then .mail = dr(aMail)
                    If dr(aNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(aNivelEscolaridad)
                    If dr(aEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(aEstadoCivil)
                    If dr(aOcupacion) IsNot DBNull.Value Then .ocupacion = dr(aOcupacion)
                    If dr(aDomicilioLaboral) IsNot DBNull.Value Then .domiciliolaboral = dr(aDomicilioLaboral)
                    If dr(aEmpresa) IsNot DBNull.Value Then .empresa = dr(aEmpresa)
                    If dr(aCUIL) IsNot DBNull.Value Then .cuil = dr(aCUIL)
                    If dr(aFotocopiaDNI) IsNot DBNull.Value Then .fotocopiaDNI = dr(aFotocopiaDNI)
                    If dr(aFotocopiaDNIPadre) IsNot DBNull.Value Then .fotocopiaDNIPadre = dr(aFotocopiaDNIPadre)
                    If dr(aFotocopiaDNIMadre) IsNot DBNull.Value Then .fotocopiaDNIMadre = dr(aFotocopiaDNIMadre)
                    If dr(aFotocarnet) IsNot DBNull.Value Then .fotocarnet = dr(aFotocarnet)
                    If dr(aCertificadoSalud) IsNot DBNull.Value Then .certificadoSalud = dr(aCertificadoSalud)
                    If dr(aFotocopiaIPE) IsNot DBNull.Value Then .fotocopiaIPE = dr(aFotocopiaIPE)
                    If dr(aEntrevistaDOE) IsNot DBNull.Value Then .entrevistaDOE = dr(aEntrevistaDOE)
                    If dr(aFichaMedica) IsNot DBNull.Value Then .fichaMedica = dr(aFichaMedica)
                    If dr(aAudiometria) IsNot DBNull.Value Then .audiometria = dr(aAudiometria)
                    If dr(aCertificadoBD) IsNot DBNull.Value Then .certificadoBD = dr(aCertificadoBD)
                    If dr(aTutor) IsNot DBNull.Value Then .tutor = dr(aTutor)
                    If dr(aFotocopiaCarnetVacunacion) IsNot DBNull.Value Then .fotocopiaCarnetVacunacion = dr(aFotocopiaCarnetVacunacion)
                    If dr(aActaCompromidoFirmada) IsNot DBNull.Value Then .ActaCompromisoFirmado = dr(aActaCompromidoFirmada)
                    If dr(aHorarioFirmado) IsNot DBNull.Value Then .HorarioFirmado = dr(aHorarioFirmado)
                    If dr(aJELunes) IsNot DBNull.Value Then .JELunes = dr(aJELunes)
                    If dr(aJEMartes) IsNot DBNull.Value Then .JEMartes = dr(aJEMartes)
                    If dr(aJEMiercoles) IsNot DBNull.Value Then .JEMiercoles = dr(aJEMiercoles)
                    If dr(aJEJueves) IsNot DBNull.Value Then .JEJueves = dr(aJEJueves)
                    If dr(aJEViernes) IsNot DBNull.Value Then .JEViernes = dr(aJEViernes)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Función devuelve true se encuenta un alumno por DNI y llena la instancia Alu con los datos de la base de datos.
    ''' Si no encuentra un alumno devuelve False.
    ''' </summary>
    ''' <param name="DNI">DNI del alumno a buscar</param>
    ''' <param name="Alu">Instancia de la clase alumno vacía, que se completa si se encuentra un alumno por DNI</param>
    ''' <param name="bd">True = Vía 1, Talse = Vía 2</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Traer_X_DNI(ByRef DNI As Integer, ByRef Alu As Alumno, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.*, a.* FROM alumnos as a, personas as p WHERE a.per_id = p.per_id AND p.per_dni = {0} AND a.alu_baja = 0", DNI)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Alu
                    .id = dr(aID)
                    .legajo = dr(alegajo)
                    If dr(aEnfermedades) IsNot DBNull.Value Then .enfermedades = dr(aEnfermedades)
                    If dr(aAlergias) IsNot DBNull.Value Then .alergias = dr(aAlergias)
                    If dr(aMedicacion) IsNot DBNull.Value Then .medicacion = dr(aMedicacion)
                    If dr(aObservaciones) IsNot DBNull.Value Then .observaciones = dr(aObservaciones)
                    If dr(aPadre) IsNot DBNull.Value Then .padre = dr(aPadre)
                    If dr(aMadre) IsNot DBNull.Value Then .madre = dr(aMadre)
                    If dr(aFechaAlta).ToString() IsNot DBNull.Value Then .fechaalta = dr(aFechaAlta).ToString()
                    If dr(aFechaBaja).ToString() IsNot DBNull.Value Then .fechabaja = dr(aFechaBaja).ToString()
                    If dr(aActivo) IsNot DBNull.Value Then .activo = dr(aActivo)
                    If dr(aBaja) IsNot DBNull.Value Then .baja = dr(aBaja)
                    If dr(aCiclo) IsNot DBNull.Value Then .ciclo = dr(aCiclo)
                    If dr(aTipo) IsNot DBNull.Value Then .tipo = dr(aTipo)
                    If dr(aCurso) IsNot DBNull.Value Then .curso = dr(aCurso)
                    If dr(aAnoLectivo) IsNot DBNull.Value Then .anolectivo = dr(aAnoLectivo)
                    If dr(aTurno) IsNot DBNull.Value Then .turno = dr(aTurno)
                    If dr(aHorario) IsNot DBNull.Value Then .horario = dr(aHorario)
                    If dr(aObraSocial) IsNot DBNull.Value Then .obrasocial = dr(aObraSocial)
                    If dr(aSalud) IsNot DBNull.Value Then .salud = dr(aSalud)
                    If dr(aVivienda) IsNot DBNull.Value Then .vivienda = dr(aVivienda)
                    If dr(aPatio) IsNot DBNull.Value Then .patio = dr(aPatio)
                    If dr(aEspacioVerde) IsNot DBNull.Value Then .espacioverde = dr(aEspacioVerde)
                    If dr(aAnimales) IsNot DBNull.Value Then .animales = dr(aAnimales)
                    If dr(aPlantas) IsNot DBNull.Value Then .plantas = dr(aPlantas)
                    If dr(aRelacionPlantas) IsNot DBNull.Value Then .relacionplantas = dr(aRelacionPlantas)
                    If dr(aJuegos) IsNot DBNull.Value Then .juegos = dr(aJuegos)
                    If dr(aExperiencia) IsNot DBNull.Value Then .experiencia = dr(aExperiencia)
                    If dr(aTiempo) IsNot DBNull.Value Then .tiempo = dr(aTiempo)
                    If dr(aLugarExperiencia) IsNot DBNull.Value Then .lugarexperiencia = dr(aLugarExperiencia)
                    If dr(aPersonasRetiro) IsNot DBNull.Value Then .personasretiro = dr(aPersonasRetiro)
                    If dr(aDescuento) IsNot DBNull.Value Then .descuento = dr(aDescuento)
                    If dr(aServDescuento) IsNot DBNull.Value Then .servdescuento = dr(aServDescuento)
                    If dr(aNombre) IsNot DBNull.Value Then .nombre = dr(aNombre)
                    If dr(aApellido) IsNot DBNull.Value Then .apellido = dr(aApellido)
                    If dr(aFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(aFechaNacimiento)
                    If dr(aLugarNacimiento) IsNot DBNull.Value Then .lugarnacimiento = dr(aLugarNacimiento)
                    If dr(aDNI) IsNot DBNull.Value Then .dni = dr(aDNI)
                    If dr(aSexo) IsNot DBNull.Value Then .sexo = dr(aSexo)
                    If dr(aNacionalidad) IsNot DBNull.Value Then .nacionalidad = dr(aNacionalidad)
                    If dr(aDomicilio) IsNot DBNull.Value Then .domicilio = dr(aDomicilio)
                    If dr(aCP) IsNot DBNull.Value Then .cp = dr(aCP)
                    If dr(aLocalidad) IsNot DBNull.Value Then .localidad = dr(aLocalidad)
                    If dr(aTelefono) IsNot DBNull.Value Then .telefono = dr(aTelefono)
                    If dr(aCelular) IsNot DBNull.Value Then .celular = dr(aCelular)
                    If dr(aMail) IsNot DBNull.Value Then .mail = dr(aMail)
                    If dr(aNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(aNivelEscolaridad)
                    If dr(aEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(aEstadoCivil)
                    If dr(aOcupacion) IsNot DBNull.Value Then .ocupacion = dr(aOcupacion)
                    If dr(aDomicilioLaboral) IsNot DBNull.Value Then .domiciliolaboral = dr(aDomicilioLaboral)
                    If dr(aEmpresa) IsNot DBNull.Value Then .empresa = dr(aEmpresa)
                    If dr(aCUIL) IsNot DBNull.Value Then .cuil = dr(aCUIL)
                    If dr(aFotocopiaDNI) IsNot DBNull.Value Then .fotocopiaDNI = dr(aFotocopiaDNI)
                    If dr(aFotocopiaDNIPadre) IsNot DBNull.Value Then .fotocopiaDNIPadre = dr(aFotocopiaDNIPadre)
                    If dr(aFotocopiaDNIMadre) IsNot DBNull.Value Then .fotocopiaDNIMadre = dr(aFotocopiaDNIMadre)
                    If dr(aFotocarnet) IsNot DBNull.Value Then .fotocarnet = dr(aFotocarnet)
                    If dr(aCertificadoSalud) IsNot DBNull.Value Then .certificadoSalud = dr(aCertificadoSalud)
                    If dr(aFotocopiaIPE) IsNot DBNull.Value Then .fotocopiaIPE = dr(aFotocopiaIPE)
                    If dr(aEntrevistaDOE) IsNot DBNull.Value Then .entrevistaDOE = dr(aEntrevistaDOE)
                    If dr(aFichaMedica) IsNot DBNull.Value Then .fichaMedica = dr(aFichaMedica)
                    If dr(aAudiometria) IsNot DBNull.Value Then .audiometria = dr(aAudiometria)
                    If dr(aCertificadoBD) IsNot DBNull.Value Then .certificadoBD = dr(aCertificadoBD)
                    If dr(aTutor) IsNot DBNull.Value Then .tutor = dr(aTutor)
                    If dr(aFotocopiaCarnetVacunacion) IsNot DBNull.Value Then .fotocopiaCarnetVacunacion = dr(aFotocopiaCarnetVacunacion)
                    If dr(aActaCompromidoFirmada) IsNot DBNull.Value Then .ActaCompromisoFirmado = dr(aActaCompromidoFirmada)
                    If dr(aHorarioFirmado) IsNot DBNull.Value Then .HorarioFirmado = dr(aHorarioFirmado)
                    If dr(aJELunes) IsNot DBNull.Value Then .JELunes = dr(aJELunes)
                    If dr(aJEMartes) IsNot DBNull.Value Then .JEMartes = dr(aJEMartes)
                    If dr(aJEMiercoles) IsNot DBNull.Value Then .JEMiercoles = dr(aJEMiercoles)
                    If dr(aJEJueves) IsNot DBNull.Value Then .JEJueves = dr(aJEJueves)
                    If dr(aJEViernes) IsNot DBNull.Value Then .JEViernes = dr(aJEViernes)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Función devuelve true se encuenta un alumno por DNI y llena la instancia Alu con los datos de la base de datos.
    ''' Si no encuentra un alumno devuelve False.
    ''' </summary>
    ''' <param name="DNI">DNI del alumno a buscar</param>
    ''' <param name="Alu">Instancia de la clase alumno vacía, que se completa si se encuentra un alumno por DNI</param>
    ''' <param name="bd">True = Vía 1, Talse = Vía 2</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Traer_X_DNI_activo(ByRef DNI As Integer, ByRef Alu As Alumno, Optional ByVal bd As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.*, a.* FROM alumnos as a, personas as p WHERE a.per_id = p.per_id AND p.per_dni = {0}  AND a.alu_activo = 1 AND a.alu_baja = 0", DNI)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Alu
                    .id = dr(aID)
                    .legajo = dr(alegajo)
                    If dr(aEnfermedades) IsNot DBNull.Value Then .enfermedades = dr(aEnfermedades)
                    If dr(aAlergias) IsNot DBNull.Value Then .alergias = dr(aAlergias)
                    If dr(aMedicacion) IsNot DBNull.Value Then .medicacion = dr(aMedicacion)
                    If dr(aObservaciones) IsNot DBNull.Value Then .observaciones = dr(aObservaciones)
                    If dr(aPadre) IsNot DBNull.Value Then .padre = dr(aPadre)
                    If dr(aMadre) IsNot DBNull.Value Then .madre = dr(aMadre)
                    If dr(aFechaAlta).ToString() IsNot DBNull.Value Then .fechaalta = dr(aFechaAlta).ToString()
                    If dr(aFechaBaja).ToString() IsNot DBNull.Value Then .fechabaja = dr(aFechaBaja).ToString()
                    If dr(aActivo) IsNot DBNull.Value Then .activo = dr(aActivo)
                    If dr(aBaja) IsNot DBNull.Value Then .baja = dr(aBaja)
                    If dr(aCiclo) IsNot DBNull.Value Then .ciclo = dr(aCiclo)
                    If dr(aTipo) IsNot DBNull.Value Then .tipo = dr(aTipo)
                    If dr(aCurso) IsNot DBNull.Value Then .curso = dr(aCurso)
                    If dr(aAnoLectivo) IsNot DBNull.Value Then .anolectivo = dr(aAnoLectivo)
                    If dr(aTurno) IsNot DBNull.Value Then .turno = dr(aTurno)
                    If dr(aHorario) IsNot DBNull.Value Then .horario = dr(aHorario)
                    If dr(aObraSocial) IsNot DBNull.Value Then .obrasocial = dr(aObraSocial)
                    If dr(aSalud) IsNot DBNull.Value Then .salud = dr(aSalud)
                    If dr(aVivienda) IsNot DBNull.Value Then .vivienda = dr(aVivienda)
                    If dr(aPatio) IsNot DBNull.Value Then .patio = dr(aPatio)
                    If dr(aEspacioVerde) IsNot DBNull.Value Then .espacioverde = dr(aEspacioVerde)
                    If dr(aAnimales) IsNot DBNull.Value Then .animales = dr(aAnimales)
                    If dr(aPlantas) IsNot DBNull.Value Then .plantas = dr(aPlantas)
                    If dr(aRelacionPlantas) IsNot DBNull.Value Then .relacionplantas = dr(aRelacionPlantas)
                    If dr(aJuegos) IsNot DBNull.Value Then .juegos = dr(aJuegos)
                    If dr(aExperiencia) IsNot DBNull.Value Then .experiencia = dr(aExperiencia)
                    If dr(aTiempo) IsNot DBNull.Value Then .tiempo = dr(aTiempo)
                    If dr(aLugarExperiencia) IsNot DBNull.Value Then .lugarexperiencia = dr(aLugarExperiencia)
                    If dr(aPersonasRetiro) IsNot DBNull.Value Then .personasretiro = dr(aPersonasRetiro)
                    If dr(aDescuento) IsNot DBNull.Value Then .descuento = dr(aDescuento)
                    If dr(aServDescuento) IsNot DBNull.Value Then .servdescuento = dr(aServDescuento)
                    If dr(aNombre) IsNot DBNull.Value Then .nombre = dr(aNombre)
                    If dr(aApellido) IsNot DBNull.Value Then .apellido = dr(aApellido)
                    If dr(aFechaNacimiento) IsNot DBNull.Value Then .fechanacimiento = dr(aFechaNacimiento)
                    If dr(aLugarNacimiento) IsNot DBNull.Value Then .lugarnacimiento = dr(aLugarNacimiento)
                    If dr(aDNI) IsNot DBNull.Value Then .dni = dr(aDNI)
                    If dr(aSexo) IsNot DBNull.Value Then .sexo = dr(aSexo)
                    If dr(aNacionalidad) IsNot DBNull.Value Then .nacionalidad = dr(aNacionalidad)
                    If dr(aDomicilio) IsNot DBNull.Value Then .domicilio = dr(aDomicilio)
                    If dr(aCP) IsNot DBNull.Value Then .cp = dr(aCP)
                    If dr(aLocalidad) IsNot DBNull.Value Then .localidad = dr(aLocalidad)
                    If dr(aTelefono) IsNot DBNull.Value Then .telefono = dr(aTelefono)
                    If dr(aCelular) IsNot DBNull.Value Then .celular = dr(aCelular)
                    If dr(aMail) IsNot DBNull.Value Then .mail = dr(aMail)
                    If dr(aNivelEscolaridad) IsNot DBNull.Value Then .nivelescolaridad = dr(aNivelEscolaridad)
                    If dr(aEstadoCivil) IsNot DBNull.Value Then .estadocivil = dr(aEstadoCivil)
                    If dr(aOcupacion) IsNot DBNull.Value Then .ocupacion = dr(aOcupacion)
                    If dr(aDomicilioLaboral) IsNot DBNull.Value Then .domiciliolaboral = dr(aDomicilioLaboral)
                    If dr(aEmpresa) IsNot DBNull.Value Then .empresa = dr(aEmpresa)
                    If dr(aCUIL) IsNot DBNull.Value Then .cuil = dr(aCUIL)
                    If dr(aFotocopiaDNI) IsNot DBNull.Value Then .fotocopiaDNI = dr(aFotocopiaDNI)
                    If dr(aFotocopiaDNIPadre) IsNot DBNull.Value Then .fotocopiaDNIPadre = dr(aFotocopiaDNIPadre)
                    If dr(aFotocopiaDNIMadre) IsNot DBNull.Value Then .fotocopiaDNIMadre = dr(aFotocopiaDNIMadre)
                    If dr(aFotocarnet) IsNot DBNull.Value Then .fotocarnet = dr(aFotocarnet)
                    If dr(aCertificadoSalud) IsNot DBNull.Value Then .certificadoSalud = dr(aCertificadoSalud)
                    If dr(aFotocopiaIPE) IsNot DBNull.Value Then .fotocopiaIPE = dr(aFotocopiaIPE)
                    If dr(aEntrevistaDOE) IsNot DBNull.Value Then .entrevistaDOE = dr(aEntrevistaDOE)
                    If dr(aFichaMedica) IsNot DBNull.Value Then .fichaMedica = dr(aFichaMedica)
                    If dr(aAudiometria) IsNot DBNull.Value Then .audiometria = dr(aAudiometria)
                    If dr(aCertificadoBD) IsNot DBNull.Value Then .certificadoBD = dr(aCertificadoBD)
                    If dr(aTutor) IsNot DBNull.Value Then .tutor = dr(aTutor)
                    If dr(aFotocopiaCarnetVacunacion) IsNot DBNull.Value Then .fotocopiaCarnetVacunacion = dr(aFotocopiaCarnetVacunacion)
                    If dr(aActaCompromidoFirmada) IsNot DBNull.Value Then .ActaCompromisoFirmado = dr(aActaCompromidoFirmada)
                    If dr(aHorarioFirmado) IsNot DBNull.Value Then .HorarioFirmado = dr(aHorarioFirmado)
                    If dr(aJELunes) IsNot DBNull.Value Then .JELunes = dr(aJELunes)
                    If dr(aJEMartes) IsNot DBNull.Value Then .JEMartes = dr(aJEMartes)
                    If dr(aJEMiercoles) IsNot DBNull.Value Then .JEMiercoles = dr(aJEMiercoles)
                    If dr(aJEJueves) IsNot DBNull.Value Then .JEJueves = dr(aJEJueves)
                    If dr(aJEViernes) IsNot DBNull.Value Then .JEViernes = dr(aJEViernes)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_Sala(ByVal sala As Integer, ByVal turno As String, Optional ByVal bd As Boolean = True) As List(Of Integer)
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim alumnos As New List(Of Integer)
        Try
            SQL = String.Format("SELECT p.per_id as alum FROM cursos as c, personas as p, alumnos as a WHERE c.cur_id = {0} AND a.per_id = p.per_id AND a.alu_curso = c.cur_id AND a.alu_turno LIKE '{1}' AND a.alu_activo = 1 AND a.alu_baja = 0", sala, turno)
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)

            Dim arrAlumnos As New ArrayList
            For Each dr As DataRow In DS.Tables(0).Rows
                alumnos.Add(dr.ItemArray(0))
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return alumnos
    End Function
    Public Function Existe(ByVal legajo As String, Optional ByVal bd As Boolean = True) As Boolean
        Dim B As Boolean = True
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM alumnos as a, personas as p WHERE a.per_id = p.per_id AND p.per_id = {0}", legajo)
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

    'Agrega un alumno a los dos vías
    Public Function Agregar(ByVal alu As Alumno, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim result As Integer
        Dim id As Integer
        Dim DA As New MySqlClient.MySqlDataAdapter
        'se agrega al via 1
        Dim SQL As String = String.Format("INSERT INTO `personas` (`per_id`, `per_nombre`, `per_apellido`, `per_fecnac`, `per_lugnac`, `per_dni`, `per_sexo`, `per_nacionalidad`, `per_domicilio`, `per_CP`, `loc_id`, `per_telefono`, `per_celular`, `per_mail`, `per_nivelesc`, `per_estadocivil`, `per_ocupacion`, `per_domlaboral`, `per_empresa`, `per_cuil`) VALUES (NULL, '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}')",
                                          alu.nombre, alu.apellido, alu.fechanacimiento, alu.lugarnacimiento, alu.dni, alu.sexo, alu.nacionalidad, alu.domicilio, alu.cp, alu.localidad, alu.telefono, alu.celular, alu.mail, alu.nivelescolaridad, alu.estadocivil, alu.ocupacion, alu.domiciliolaboral, alu.empresa, alu.cuil)
        'tengo que sacar el id de la persona agregada
        Dim SQL2 As String = "SELECT MAX(per_id) FROM `personas`"

        Try
            con.AbrirConexion(True)
            result = con.EjecutarComando(SQL)
            DA = con.EjecutarConsulta(SQL2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        Dim DS As DataSet = New DataSet()
        DA.Fill(DS)
        If Not DS.Tables(0).Rows.Count = 0 Then
            id = Convert.ToInt32(DS.Tables(0).Rows(0).ItemArray(0))
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        Dim SQL3 As String = String.Format("INSERT INTO `alumnos` (`per_id`, `alu_legajo`, `alu_enfermedades`, `alu_alergias`, `alu_medicacion`, `alu_observaciones`, `alu_padre`, `alu_madre`, `alu_fechaalta`, `alu_activo`, `alu_ciclo`, `alu_tipo`, `alu_curso`, `alu_anolectivo`, `alu_turno`, `alu_horario`, `alu_obrasocial`, `alu_salud`, `alu_vivienda`, `alu_patio`, `alu_espacioverde`, `alu_animales`, `alu_plantas`, `alu_relacionplantas`, `alu_juegos`, `alu_experiencia`, `alu_tiempo`, `alu_lugarexp`, `alu_perRetiro`, `alu_descuento`, `alu_servdescuento`, `alu_fDNI`, `alu_fDNIPadre`, `alu_fDNIMadre`, `alu_fotocarnet`, `alu_certifsalud`, `alu_fIPE`, `alu_entrevistaDOE`, `alu_fichaMedica`, `alu_audiometria`, `alu_certificadoBD`, `alu_tutor`, `alu_fCarnetVacun`, `alu_ActaCompFirmada`, `alu_HorarioFirmado`, `alu_jeLunes`, `alu_jeMartes`, `alu_jeMiercoles`, `alu_jeJueves`, `alu_jeViernes`, `alu_baja`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}','{32}','{33}','{34}','{35}','{36}','{37}','{38}','{39}','{40}','{41}','{42}','{43}','{44}','{45}','{46}','{47}','{48}','{49}','{50}')",
                                          id, alu.legajo, alu.enfermedades, alu.alergias, alu.medicacion, alu.observaciones, alu.padre, alu.madre, alu.fechaalta, alu.activo, alu.ciclo, alu.tipo, alu.curso, alu.anolectivo, alu.turno, alu.horario, alu.obrasocial, alu.salud, alu.vivienda, alu.patio, alu.espacioverde, alu.animales, alu.plantas, alu.relacionplantas, alu.juegos, alu.experiencia, alu.tiempo, alu.lugarexperiencia, alu.personasretiro, alu.descuento, alu.servdescuento, alu.fotocopiaDNI, alu.fotocopiaDNIPadre, alu.fotocopiaDNIMadre, alu.fotocarnet, alu.certificadoSalud, alu.fotocopiaIPE, alu.entrevistaDOE, alu.fichaMedica, alu.audiometria, alu.certificadoBD, alu.tutor, alu.fotocopiaCarnetVacunacion, alu.ActaCompromisoFirmado, alu.HorarioFirmado, alu.JELunes, alu.JEMartes, alu.JEMiercoles, alu.JEJueves, alu.JEViernes, alu.baja)

        Try
            result = con.EjecutarComando(SQL3)
            con.CerrarConexion()
            'Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        'se agrega al via 2
        Try
            con.AbrirConexion(False)
            result = con.EjecutarComando(SQL)
            DA = con.EjecutarConsulta(SQL2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        'DS.Clear()
        'DS.Dispose()
        'DA.Fill(DS)
        'If Not DS.Tables(0).Rows.Count = 0 Then
        'id = Convert.ToInt32(DS.Tables(0).Rows(0).ItemArray(0))
        'Else
        'MsgBox(Cts.msgErrSinResultados)
        'End If

        Try
            result = con.EjecutarComando(SQL3)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        Return result
    End Function

    Public Function Editar(ByVal alu As Alumno, Optional ByVal bd As Boolean = True) As Integer
        Dim result As Integer
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As New DataSet
        Dim SQL As String = String.Format("UPDATE alumnos SET alu_legajo = '{0}', alu_enfermedades = '{1}', alu_alergias = '{2}', alu_medicacion = '{3}', alu_observaciones = '{4}', alu_padre = '{5}', alu_madre = '{6}', alu_fechaalta = '{7}', alu_activo = '{8}', alu_ciclo = '{9}', alu_tipo = '{10}', alu_curso = '{11}', alu_anolectivo = '{12}', alu_turno = '{13}', alu_horario = '{14}', alu_obrasocial = '{15}', alu_salud = '{16}', alu_vivienda = '{17}', alu_patio = '{18}', alu_espacioverde = '{19}', alu_animales = '{20}', alu_plantas = '{21}', alu_relacionplantas = '{22}', alu_juegos = '{23}', alu_descuento = '{24}', alu_servdescuento = '{25}',alu_experiencia = '{26}', alu_tiempo = '{27}', alu_lugarexp = '{28}', alu_perRetiro = '{29}', alu_fDNI = '{30}', alu_fDNIpadre = '{31}', alu_fDNImadre = '{32}', alu_fotocarnet = '{33}', alu_certifsalud = '{34}', alu_fIPE = '{35}', alu_entrevistaDOE = '{36}', alu_fichaMedica = '{37}', alu_audiometria = '{38}', alu_certificadoBD = '{39}', alu_tutor = '{40}', alu_fCarnetVacun = '{41}', alu_ActaCompFirmada = '{42}', alu_HorarioFirmado = '{43}', alu_jeLunes = '{44}', alu_jeMartes = '{45}', alu_jeMiercoles = '{46}', alu_jeJueves = '{47}', alu_jeViernes = '{48}', alu_baja = '{49}' WHERE per_id = {50}",
                                          alu.legajo, alu.enfermedades, alu.alergias, alu.medicacion, alu.observaciones, alu.padre, alu.madre, alu.fechaalta, alu.activo, alu.ciclo, alu.tipo, alu.curso, alu.anolectivo, alu.turno, alu.horario, alu.obrasocial, alu.salud, alu.vivienda, alu.patio, alu.espacioverde, alu.animales, alu.plantas, alu.relacionplantas, alu.juegos, alu.descuento, alu.servdescuento, alu.experiencia, alu.tiempo, alu.lugarexperiencia, alu.personasretiro, alu.fotocopiaDNI, alu.fotocopiaDNIPadre, alu.fotocopiaDNIMadre, alu.fotocarnet, alu.certificadoSalud, alu.fotocopiaIPE, alu.entrevistaDOE, alu.fichaMedica, alu.audiometria, alu.certificadoBD, alu.tutor, alu.fotocopiaCarnetVacunacion, alu.ActaCompromisoFirmado, alu.HorarioFirmado, alu.JELunes, alu.JEMartes, alu.JEMiercoles, alu.JEJueves, alu.JEViernes, alu.baja, alu.id)
        Dim SQL2 As String = String.Format("UPDATE personas SET per_nombre = '{0}', per_apellido = '{1}', per_fecnac = '{2}', per_lugnac = '{3}', per_dni = '{4}', per_sexo = '{5}', per_nacionalidad = '{6}', per_domicilio = '{7}', per_CP = '{8}', loc_id = '{9}', per_telefono = '{10}', per_celular = '{11}', per_mail = '{12}', per_nivelesc = '{13}', per_estadocivil = '{14}', per_ocupacion = '{15}', per_domlaboral = '{16}', per_empresa = '{17}', per_cuil = '{18}' WHERE per_id = {19}",
                                          alu.nombre, alu.apellido, alu.fechanacimiento, alu.lugarnacimiento, alu.dni, alu.sexo, alu.nacionalidad, alu.domicilio, alu.cp, alu.localidad, alu.telefono, alu.celular, alu.mail, alu.nivelescolaridad, alu.estadocivil, alu.ocupacion, alu.domiciliolaboral, alu.empresa, alu.cuil, alu.id)
        Dim con As New cBaseDatos

        'se guarda en el via 1
        Try
            con.AbrirConexion(True)
            result = con.EjecutarComando(SQL)
            DA = con.EjecutarConsulta(SQL2)
            con.CerrarConexion()
            DA.Fill(DS)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        'se guarda en el via 2
        Try
            con.AbrirConexion(False)
            result = con.EjecutarComando(SQL)
            result = con.EjecutarComando(SQL2)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        Return result
    End Function

    'Devuelve el id y el nombre de las localidades
    Public Function Localidades() As DataSet
        'Dim combo As ComboBox
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT loc_id, loc_nombre FROM localidades")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function

    'Devuelve el id y el nombre de los cursos
    Public Function Cursos(Optional ByVal bd As Boolean = True) As DataSet
        'Dim combo As ComboBox
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cur_id, cur_nombre FROM cursos")
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

    'Devuelve el nombre de una sala por id
    Public Function Sala(ByVal id As Integer, Optional ByVal bd As Boolean = True) As String
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cur_nombre FROM cursos WHERE cur_id = {0}", id)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim sal As String = ""
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            sal = DS.Tables(0).Rows(0).ItemArray(0).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return sal
    End Function
    Public Function TraerTodas(ByVal SoloActivas As Boolean) As DataSet
        Dim conexion As New cBaseDatos
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim SQL As String = "SELECT * FROM localidades"
        If SoloActivas Then
            SQL += " WHERE loc_activa = " & Activo
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

    'Obtiene el nombre del tutor de un alumno a partir de su alu_id
    Public Function tutor(id As Integer, Optional bd As Boolean = True) As String
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT a.alu_tutor FROM alumnos as a WHERE a.per_id = {0} ", id)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DA2 As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Dim res As String = ""
        Try
            ' obtiene el tutor: madre o padre
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            'conexion.CerrarConexion()

            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then
                res = ""
            Else
                If DS.Tables(0).Rows(0) IsNot DBNull.Value Then
                    res = DS.Tables(0).Rows(0).ItemArray(0).ToString
                    'obtiene el nombre del tutor
                    If res = "Madre" Then
                        SQL = String.Format("SELECT p.per_dni FROM personas as p, alumnos as a WHERE a.alu_madre = p.per_id AND a.per_id = {0}", id)
                        DA2 = conexion.EjecutarConsulta(SQL)
                        DA2.Fill(DS2)
                        If DS2.Tables(0).Rows.Count = 0 Then
                            res = ""
                        Else
                            res = DS2.Tables(0).Rows(0).ItemArray(0).ToString
                        End If
                    ElseIf res = "Padre" Then
                        SQL = String.Format("SELECT p.per_dni FROM personas as p, alumnos as a WHERE a.alu_padre = p.per_id AND a.per_id = {0}", id)
                        DA2 = conexion.EjecutarConsulta(SQL)
                        DA2.Fill(DS2)
                        If DS2.Tables(0).Rows.Count = 0 Then
                            res = ""
                        Else
                            res = DS2.Tables(0).Rows(0).ItemArray(0).ToString
                        End If
                    Else
                        res = ""
                    End If
                Else
                    res = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return res
    End Function

    ''' <summary>
    ''' recupera todos los datos necesarios para realizar las Actas Compromiso, segun requerimiento
    ''' </summary>
    ''' <returns>Un DataSet con los datos requeridos</returns>
    ''' <remarks></remarks>
    Public Function actasCompromiso() As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT CONCAT(per_apellido, ', ', per_nombre) AS Alumno, per_dni AS DNI, cur_nombre AS Sala, alu_tipo AS Nivel, m.madre as Madre, m.madre_dni, m.madre_domicilio, m.madre_telefono, m.madre_celular, m.madre_mail, p.padre AS Padre, p.padre_dni, p.padre_domicilio, padre_telefono, p.padre_celular, p.padre_mail " & _
                            "FROM personas AS p, alumnos AS a, cursos AS c, ( " & _
                            "   SELECT CONCAT(per_apellido, ', ', per_nombre) AS madre, pp.per_id AS id, pp.per_dni AS madre_dni, pp.per_domicilio AS madre_domicilio, pp.per_telefono as madre_telefono, pp.per_celular as madre_celular, pp.per_mail as madre_mail " & _
                            "   FROM personas AS pp, alumnos AS aa " & _
                            "   WHERE aa.alu_madre = pp.per_id" & _
                            ") as m, (" & _
                            "   SELECT CONCAT(per_apellido, ', ', per_nombre) AS padre, pp.per_id AS id, pp.per_dni AS padre_dni, pp.per_domicilio AS padre_domicilio, pp.per_telefono as padre_telefono, pp.per_celular as padre_celular, pp.per_mail as padre_mail" & _
                            "   FROM personas AS pp, alumnos AS aa " & _
                            "    WHERE aa.alu_padre = pp.per_id " & _
                            ") as p " & _
                            "WHERE p.per_id = a.per_id AND c.cur_id = a.alu_curso AND a.alu_madre = m.id AND a.alu_padre = p.id AND a.alu_activo = 1 AND a.alu_baja = 0" & _
                            "GROUP BY Alumno " & _
                            "ORDER BY Alumno"
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()

            DA.Fill(DS)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function

End Class
