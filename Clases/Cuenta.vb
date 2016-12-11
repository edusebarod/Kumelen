Public Class Cuenta
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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

    Private _saldo As String
    Public Property saldo() As Integer
        Get
            Return _saldo
        End Get
        Set(ByVal value As Integer)
            _saldo = value
        End Set
    End Property

    Private _tipo As Integer
    Public Property tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
        End Set
    End Property

    Private _grupo As String
    Public Property grupo() As String
        Get
            Return _grupo
        End Get
        Set(ByVal value As String)
            _grupo = value
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

    Private _codigo As Integer
    Public Property codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Private _devengaciones As Integer
    Public Property devengaciones() As Integer
        Get
            Return _devengaciones
        End Get
        Set(ByVal value As Integer)
            _devengaciones = value
        End Set
    End Property

    Private _facturaciones As Integer
    Public Property facturaciones() As Integer
        Get
            Return _facturaciones
        End Get
        Set(ByVal value As Integer)
            _facturaciones = value
        End Set
    End Property

    Private _pagosDebe As Integer
    Public Property pagosDebe() As Integer
        Get
            Return _pagosDebe
        End Get
        Set(ByVal value As Integer)
            _pagosDebe = value
        End Set
    End Property

    Private _pagosHaber As Integer
    Public Property pagosHaber() As Integer
        Get
            Return _pagosHaber
        End Get
        Set(ByVal value As Integer)
            _pagosHaber = value
        End Set
    End Property
End Class
