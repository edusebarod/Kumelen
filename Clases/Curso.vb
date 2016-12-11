Public Class Curso
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _docente As Integer
    Public Property docente() As Integer
        Get
            Return _docente
        End Get
        Set(ByVal value As Integer)
            _docente = value
        End Set
    End Property

    Private _anolectivo As String
    Public Property anolectivo() As Integer
        Get
            Return _anolectivo
        End Get
        Set(ByVal value As Integer)
            _anolectivo = value
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

    Private _turno As String
    Public Property turno() As String
        Get
            Return _turno
        End Get
        Set(ByVal value As String)
            _turno = value
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

End Class

