Public Class Alumno
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _legajo As String
    Public Property legajo() As String
        Get
            Return _legajo
        End Get
        Set(ByVal value As String)
            _legajo = value
        End Set
    End Property

    Private _enfermedades As String
    Public Property enfermedades() As String
        Get
            Return _enfermedades
        End Get
        Set(ByVal value As String)
            _enfermedades = value
        End Set
    End Property

    Private _alergias As String
    Public Property alergias() As String
        Get
            Return _alergias
        End Get
        Set(ByVal value As String)
            _alergias = value
        End Set
    End Property

    Private _medicacion As String
    Public Property medicacion() As String
        Get
            Return _medicacion
        End Get
        Set(ByVal value As String)
            _medicacion = value
        End Set
    End Property

    Private _observaciones As String
    Public Property observaciones() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value
        End Set
    End Property

    Private _padre As Integer
    Public Property padre() As Integer
        Get
            Return _padre
        End Get
        Set(ByVal value As Integer)
            _padre = value
        End Set
    End Property

    Private _madre As Integer
    Public Property madre() As Integer
        Get
            Return _madre
        End Get
        Set(ByVal value As Integer)
            _madre = value
        End Set
    End Property

    Private _fechabaja As String
    Public Property fechabaja() As String
        Get
            Return _fechabaja
        End Get
        Set(ByVal value As String)
            _fechabaja = value
        End Set
    End Property

    Private _fechaalta As String
    Public Property fechaalta() As String
        Get
            Return _fechaalta
        End Get
        Set(ByVal value As String)
            _fechaalta = value
        End Set
    End Property

    Private _activo As Integer
    Public Property activo() As Integer
        Get
            Return _activo
        End Get
        Set(ByVal value As Integer)
            _activo = value
        End Set
    End Property

    Private _baja As Integer
    Public Property baja() As Integer
        Get
            Return _baja
        End Get
        Set(ByVal value As Integer)
            _baja = value
        End Set
    End Property

    Private _ciclo As String
    Public Property ciclo() As String
        Get
            Return _ciclo
        End Get
        Set(ByVal value As String)
            _ciclo = value
        End Set
    End Property

    Private _tipo As String
    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    Private _curso As String
    Public Property curso() As String
        Get
            Return _curso
        End Get
        Set(ByVal value As String)
            _curso = value
        End Set
    End Property

    Private _anolectivo As String
    Public Property anolectivo() As String
        Get
            Return _anolectivo
        End Get
        Set(ByVal value As String)
            _anolectivo = value
        End Set
    End Property

    Private _turno As String
    Public Property turno() As String
        Get
            Return _turno
        End Get
        Set(ByVal value As String)
            _turno = value
        End Set
    End Property

    Private _horario As String
    Public Property horario() As String
        Get
            Return _horario
        End Get
        Set(ByVal value As String)
            _horario = value
        End Set
    End Property

    Private _obrasocial As String
    Public Property obrasocial() As String
        Get
            Return _obrasocial
        End Get
        Set(ByVal value As String)
            _obrasocial = value
        End Set
    End Property

    Private _salud As String
    Public Property salud() As String
        Get
            Return _salud
        End Get
        Set(ByVal value As String)
            _salud = value
        End Set
    End Property

    Private _vivienda As String
    Public Property vivienda() As String
        Get
            Return _vivienda
        End Get
        Set(ByVal value As String)
            _vivienda = value
        End Set
    End Property

    Private _patio As Integer
    Public Property patio() As Integer
        Get
            Return _patio
        End Get
        Set(ByVal value As Integer)
            _patio = value
        End Set
    End Property

    Private _espacioverde As Integer
    Public Property espacioverde() As Integer
        Get
            Return _espacioverde
        End Get
        Set(ByVal value As Integer)
            _espacioverde = value
        End Set
    End Property

    Private _animales As Integer
    Public Property animales() As Integer
        Get
            Return _animales
        End Get
        Set(ByVal value As Integer)
            _animales = value
        End Set
    End Property

    Private _plantas As Integer
    Public Property plantas() As Integer
        Get
            Return _plantas
        End Get
        Set(ByVal value As Integer)
            _plantas = value
        End Set
    End Property

    Private _relacionplantas As Integer
    Public Property relacionplantas() As Integer
        Get
            Return _relacionplantas
        End Get
        Set(ByVal value As Integer)
            _relacionplantas = value
        End Set
    End Property

    Private _juegos As String
    Public Property juegos() As String
        Get
            Return _juegos
        End Get
        Set(ByVal value As String)
            _juegos = value
        End Set
    End Property

    Private _descuento As Decimal
    Public Property descuento() As Decimal
        Get
            Return _descuento
        End Get
        Set(ByVal value As Decimal)
            _descuento = value
        End Set
    End Property

    Private _servdescuento As String
    Public Property servdescuento() As String
        Get
            Return _servdescuento
        End Get
        Set(ByVal value As String)
            _servdescuento = value
        End Set
    End Property

    Private _experiencia As Integer
    Public Property experiencia() As Integer
        Get
            Return _experiencia
        End Get
        Set(ByVal value As Integer)
            _experiencia = value
        End Set
    End Property

    Private _tiempo As Integer
    Public Property tiempo() As Integer
        Get
            Return _tiempo
        End Get
        Set(ByVal value As Integer)
            _tiempo = value
        End Set
    End Property

    Private _lugarexperiencia As String
    Public Property lugarexperiencia() As String
        Get
            Return _lugarexperiencia
        End Get
        Set(ByVal value As String)
            _lugarexperiencia = value
        End Set
    End Property

    Private _personasretiro As String
    Public Property personasretiro() As String
        Get
            Return _personasretiro
        End Get
        Set(ByVal value As String)
            _personasretiro = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _apellido As String
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Private _fechanacimiento As String
    Public Property fechanacimiento() As String

        Get
            Return _fechanacimiento
        End Get
        Set(ByVal value As String)
            _fechanacimiento = value
        End Set
    End Property

    Private _lugarnacimiento As String
    Public Property lugarnacimiento() As String

        Get
            Return _lugarnacimiento
        End Get
        Set(ByVal value As String)
            _lugarnacimiento = value
        End Set
    End Property

    Private _dni As String
    Public Property dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    Private _sexo As String
    Public Property sexo() As String
        Get
            Return _sexo
        End Get
        Set(ByVal value As String)
            _sexo = value
        End Set
    End Property

    Private _nacionalidad As String
    Public Property nacionalidad() As String
        Get
            Return _nacionalidad
        End Get
        Set(ByVal value As String)
            _nacionalidad = value
        End Set
    End Property

    Private _domicilio As String
    Public Property domicilio() As String
        Get
            Return _domicilio
        End Get
        Set(ByVal value As String)
            _domicilio = value
        End Set
    End Property

    Private _cp As String
    Public Property cp() As String
        Get
            Return _cp
        End Get
        Set(ByVal value As String)
            _cp = value
        End Set
    End Property

    Private _localidad As String
    Public Property localidad() As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            _localidad = value
        End Set
    End Property

    Private _telefono As String
    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Private _celular As String
    Public Property celular() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property

    Private _mail As String
    Public Property mail() As String
        Get
            Return _mail
        End Get
        Set(ByVal value As String)
            _mail = value
        End Set
    End Property

    Private _nivelescolaridad As String
    Public Property nivelescolaridad() As String
        Get
            Return _nivelescolaridad
        End Get
        Set(ByVal value As String)
            _nivelescolaridad = value
        End Set
    End Property

    Private _estadocivil As String
    Public Property estadocivil() As String
        Get
            Return _estadocivil
        End Get
        Set(ByVal value As String)
            _estadocivil = value
        End Set
    End Property

    Private _ocupacion As String
    Public Property ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            _ocupacion = value
        End Set
    End Property

    Private _domiciliolaboral As String
    Public Property domiciliolaboral() As String
        Get
            Return _domiciliolaboral
        End Get
        Set(ByVal value As String)
            _domiciliolaboral = value
        End Set
    End Property

    Private _empresa As String
    Public Property empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
        End Set
    End Property

    Private _cuil As String
    Public Property cuil() As String
        Get
            Return _cuil
        End Get
        Set(ByVal value As String)
            _cuil = value
        End Set
    End Property

    Private _fotocopiaDNI As Integer
    Public Property fotocopiaDNI() As Integer
        Get
            Return _fotocopiaDNI
        End Get
        Set(ByVal value As Integer)
            _fotocopiaDNI = value
        End Set
    End Property

    Private _fotocopiaDNIPadre As Integer
    Public Property fotocopiaDNIPadre() As Integer
        Get
            Return _fotocopiaDNIPadre
        End Get
        Set(ByVal value As Integer)
            _fotocopiaDNIPadre = value
        End Set
    End Property

    Private _fotocopiaDNIMadre As Integer
    Public Property fotocopiaDNIMadre() As Integer
        Get
            Return _fotocopiaDNIMadre
        End Get
        Set(ByVal value As Integer)
            _fotocopiaDNIMadre = value
        End Set
    End Property


    Private _fotocarnet As Integer
    Public Property fotocarnet() As Integer
        Get
            Return _fotocarnet
        End Get
        Set(ByVal value As Integer)
            _fotocarnet = value
        End Set
    End Property

    Private _certificadoSalud As Integer
    Public Property certificadoSalud() As Integer
        Get
            Return _certificadoSalud
        End Get
        Set(ByVal value As Integer)
            _certificadoSalud = value
        End Set
    End Property

    Private _fotocopiaIPE As Integer
    Public Property fotocopiaIPE() As Integer
        Get
            Return _fotocopiaIPE
        End Get
        Set(ByVal value As Integer)
            _fotocopiaIPE = value
        End Set
    End Property

    Private _entrevistaDOE As Integer
    Public Property entrevistaDOE() As Integer
        Get
            Return _entrevistaDOE
        End Get
        Set(ByVal value As Integer)
            _entrevistaDOE = value
        End Set
    End Property

    Private _fichaMedica As Integer
    Public Property fichaMedica() As Integer
        Get
            Return _fichaMedica
        End Get
        Set(ByVal value As Integer)
            _fichaMedica = value
        End Set
    End Property

    Private _audiometria As Integer
    Public Property audiometria() As Integer
        Get
            Return _audiometria
        End Get
        Set(ByVal value As Integer)
            _audiometria = value
        End Set
    End Property

    Private _certificadoBD As Integer
    Public Property certificadoBD() As Integer
        Get
            Return _certificadoBD
        End Get
        Set(ByVal value As Integer)
            _certificadoBD = value
        End Set
    End Property

    Private _tutor As String
    Public Property tutor() As String
        Get
            Return _tutor
        End Get
        Set(ByVal value As String)
            _tutor = value
        End Set
    End Property

    Private _fotocopiaCarnetVacunacion As Integer
    Public Property fotocopiaCarnetVacunacion() As Integer
        Get
            Return _fotocopiaCarnetVacunacion
        End Get
        Set(ByVal value As Integer)
            _fotocopiaCarnetVacunacion = value
        End Set
    End Property

    Private _ActaCompromisoFirmado As Integer
    Public Property ActaCompromisoFirmado() As Integer
        Get
            Return _ActaCompromisoFirmado
        End Get
        Set(ByVal value As Integer)
            _ActaCompromisoFirmado = value
        End Set
    End Property

    Private _HorarioFirmado As Integer
    Public Property HorarioFirmado() As Integer
        Get
            Return _HorarioFirmado
        End Get
        Set(ByVal value As Integer)
            _HorarioFirmado = value
        End Set
    End Property

    Private _JELunes As Integer
    Public Property JELunes() As Integer
        Get
            Return _JELunes
        End Get
        Set(ByVal value As Integer)
            _JELunes = value
        End Set
    End Property

    Private _JEMartes As Integer
    Public Property JEMartes() As Integer
        Get
            Return _JEMartes
        End Get
        Set(ByVal value As Integer)
            _JEMartes = value
        End Set
    End Property

    Private _JEMiercoles As Integer
    Public Property JEMiercoles() As Integer
        Get
            Return _JEMiercoles
        End Get
        Set(ByVal value As Integer)
            _JEMiercoles = value
        End Set
    End Property

    Private _JEJueves As Integer
    Public Property JEJueves() As Integer
        Get
            Return _JEJueves
        End Get
        Set(ByVal value As Integer)
            _JEJueves = value
        End Set
    End Property

    Private _JEViernes As Integer
    Public Property JEViernes() As Integer
        Get
            Return _JEViernes
        End Get
        Set(ByVal value As Integer)
            _JEViernes = value
        End Set
    End Property

End Class