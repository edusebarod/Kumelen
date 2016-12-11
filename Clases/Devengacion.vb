Public Class Devengacion
    Private _id As Integer
    Private _vencimiento1 As String
    Private _vencimiento2 As String
    Private _vencimiento3 As String
    Private _alumno As Integer
    Private _total As Double
    Private _fecha As String
    Private _observaciones As String
    Private _tipo As String
    Private _cancelada As Integer
    Private _codBarra As String


    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property vencimiento1() As String
        Get
            Return _vencimiento1
        End Get
        Set(ByVal value As String)
            _vencimiento1 = value
        End Set
    End Property

    Public Property vencimiento2() As String
        Get
            Return _vencimiento2
        End Get
        Set(ByVal value As String)
            _vencimiento2 = value
        End Set
    End Property

    Public Property vencimiento3() As String
        Get
            Return _vencimiento3
        End Get
        Set(ByVal value As String)
            _vencimiento3 = value
        End Set
    End Property

    Public Property alumno() As Integer
        Get
            Return _alumno
        End Get
        Set(ByVal value As Integer)
            _alumno = value
        End Set
    End Property

    Public Property total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

    Public Property fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
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

    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    Public Property cancelada() As Integer
        Get
            Return _cancelada
        End Get
        Set(ByVal value As Integer)
            _cancelada = value
        End Set
    End Property

    Public Property codBarra() As String
        Get
            Return _codBarra
        End Get
        Set(ByVal value As String)
            _codBarra = value
        End Set
    End Property
End Class
