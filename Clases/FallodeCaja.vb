Public Class FallodeCaja
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _fecha As String
    Public Property fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Private _saldo As Decimal
    Public Property saldo() As Decimal
        Get
            Return _saldo
        End Get
        Set(ByVal value As Decimal)
            _saldo = value
        End Set
    End Property

    Private _existencia As Decimal
    Public Property existencia() As Decimal
        Get
            Return _existencia
        End Get
        Set(ByVal value As Decimal)
            _existencia = value
        End Set
    End Property

    Private _diferencia As Decimal
    Public Property diferencia() As String
        Get
            Return _diferencia
        End Get
        Set(ByVal value As String)
            _diferencia = value
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
End Class
