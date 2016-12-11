Public Class DatosNegocio
    Private _id As Integer
    Private _razonsocial As String
    Private _direccion As String
    Private _localidad As String
    Private _cuit As String
    Private _telefono As String
    Private _mail As String
    Private _web As String

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property razonsocial() As String
        Get
            Return _razonsocial
        End Get
        Set(ByVal value As String)
            _razonsocial = value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Property localidad() As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            _localidad = value
        End Set
    End Property

    Public Property cuit() As String
        Get
            Return _cuit
        End Get
        Set(ByVal value As String)
            _cuit = value
        End Set
    End Property

    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property mail() As String
        Get
            Return _mail
        End Get
        Set(ByVal value As String)
            _mail = value
        End Set
    End Property

    Public Property web() As String
        Get
            Return _web
        End Get
        Set(ByVal value As String)
            _web = value
        End Set
    End Property
End Class
