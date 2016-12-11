Public Class Pago
    Private _id As Integer
    Private _proveedor As Integer
    Private _concepto As String
    Private _cuentaGasto As String
    Private _cuentaPago As Integer
    Private _monto As Double
    Private _fecha As String
    Private _observaciones As String
    Private _nrocomprobante As String
    Private _tipomovbco As String
    Private _banco As String
    Private _nrocheque As String
    Private _lugar As String
    Private _vencimientocheque As String

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property proveedor() As Integer
        Get
            Return _proveedor
        End Get
        Set(ByVal value As Integer)
            _proveedor = value
        End Set
    End Property

    Public Property concepto() As String
        Get
            Return _concepto
        End Get
        Set(ByVal value As String)
            _concepto = value
        End Set
    End Property

    Public Property cuentaGasto() As String
        Get
            Return _cuentaGasto
        End Get
        Set(ByVal value As String)
            _cuentaGasto = value
        End Set
    End Property

    Public Property cuentaPago() As Integer
        Get
            Return _cuentaPago
        End Get
        Set(ByVal value As Integer)
            _cuentaPago = value
        End Set
    End Property

    Public Property monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
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

    Public Property nrocomprobante() As String
        Get
            Return _nrocomprobante
        End Get
        Set(ByVal value As String)
            _nrocomprobante = value
        End Set
    End Property

    Public Property tipomovbco() As String
        Get
            Return _tipomovbco
        End Get
        Set(ByVal value As String)
            _tipomovbco = value
        End Set
    End Property

    Public Property banco() As String
        Get
            Return _banco
        End Get
        Set(ByVal value As String)
            _banco = value
        End Set
    End Property

    Public Property nrocheque() As String
        Get
            Return _nrocheque
        End Get
        Set(ByVal value As String)
            _nrocheque = value
        End Set
    End Property

    Public Property lugar() As String
        Get
            Return _lugar
        End Get
        Set(ByVal value As String)
            _lugar = value
        End Set
    End Property

    Public Property vencimientocheque() As String
        Get
            Return _vencimientocheque
        End Get
        Set(ByVal value As String)
            _vencimientocheque = value
        End Set
    End Property
End Class
