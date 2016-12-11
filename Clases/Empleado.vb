Public Class Empleado
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _perid As Integer
    Public Property perid() As Integer
        Get
            Return _perid
        End Get
        Set(ByVal value As Integer)
            _perid = value
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

    Private _cuil As String
    Public Property cuil() As String
        Get
            Return _cuil
        End Get
        Set(ByVal value As String)
            _cuil = value
        End Set
    End Property

    Private _horas As String
    Public Property horas() As String
        Get
            Return _horas
        End Get
        Set(ByVal value As String)
            _horas = value
        End Set
    End Property

    Private _cargo As String
    Public Property cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
        End Set
    End Property

    Private _fechaingreso As String
    Public Property fechaingreso() As String
        Get
            Return _fechaingreso
        End Get
        Set(ByVal value As String)
            _fechaingreso = value
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

    Private _observaciones As String
    Public Property observaciones() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value
        End Set
    End Property

    Private _activo As String
    Public Property activo() As String
        Get
            Return _activo
        End Get
        Set(ByVal value As String)
            _activo = value
        End Set
    End Property
End Class