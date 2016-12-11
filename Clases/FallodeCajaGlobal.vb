Public Class FallodeCajaGlobal
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

    Private _saldovia1 As Decimal
    Public Property saldovia1() As Decimal
        Get
            Return _saldovia1
        End Get
        Set(ByVal value As Decimal)
            _saldovia1 = value
        End Set
    End Property

    Private _saldovia2 As Decimal
    Public Property saldovia2() As Decimal
        Get
            Return _saldovia2
        End Get
        Set(ByVal value As Decimal)
            _saldovia2 = value
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

    Private _existenciaFisica As String
    Public Property existenciaFisica() As String
        Get
            Return _existenciaFisica
        End Get
        Set(ByVal value As String)
            _existenciaFisica = value
        End Set
    End Property

    Private _sobres As Decimal
    Public Property sobres() As Decimal
        Get
            Return _sobres
        End Get
        Set(ByVal value As Decimal)
            _sobres = value
        End Set
    End Property

    Private _sobresDetalle As String
    Public Property sobresdetalle() As String
        Get
            Return _sobresDetalle
        End Get
        Set(ByVal value As String)
            _sobresDetalle = value
        End Set
    End Property

    Private _vales As Decimal
    Public Property vales() As Decimal
        Get
            Return _vales
        End Get
        Set(ByVal value As Decimal)
            _vales = value
        End Set
    End Property

    Private _valesDetalle As String
    Public Property valesdetalle() As String
        Get
            Return _valesDetalle
        End Get
        Set(ByVal value As String)
            _valresDetalle = value
        End Set
    End Property

    Private _diferencia As Decimal
    Public Property diferencia() As Decimal
        Get
            Return _diferencia
        End Get
        Set(ByVal value As Decimal)
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
