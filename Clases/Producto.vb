Public Class Producto
    Private _id As Integer
    Private _codigo As Integer
    Private _nombre As String
    Private _precio As Double
    Private _stock As Double
    Private _activo As Integer
    Private _observaciones As String

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
        End Set
    End Property

    Public Property stock() As Double
        Get
            Return _stock
        End Get
        Set(ByVal value As Double)
            _stock = value
        End Set
    End Property

    Public Property activo() As Integer
        Get
            Return _activo
        End Get
        Set(ByVal value As Integer)
            _activo = value
        End Set
    End Property

    Public Property observaciones() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value
        End Set
    End Property
End Class