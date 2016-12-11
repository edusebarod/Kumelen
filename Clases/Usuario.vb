Public Class Usuario
    Private _Id As Integer
    Public Property id() As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Private _Nombre As String
    Public Property nombre() As Integer
        Get
            Return _Nombre
        End Get
        Set(value As Integer)
            _Nombre = value
        End Set
    End Property

    Private _Login As String
    Public Property login() As Integer
        Get
            Return _Login
        End Get
        Set(value As Integer)
            _login = value
        End Set
    End Property

    Private _Pass As String
    Public Property pass() As Integer
        Get
            Return _Pass
        End Get
        Set(value As Integer)
            _Pass = value
        End Set
    End Property

    Private _Tipo As String
    Public Property tipo() As Integer
        Get
            Return _Tipo
        End Get
        Set(value As Integer)
            _Tipo = value
        End Set
    End Property

    Private _Obse As String
    Public Property obse() As Integer
        Get
            Return _Obse
        End Get
        Set(value As Integer)
            _Obse = value
        End Set
    End Property

    Private _Activo As Integer
    Public Property activo() As Integer
        Get
            Return _Activo
        End Get
        Set(value As Integer)
            _Activo = value
        End Set
    End Property
End Class
