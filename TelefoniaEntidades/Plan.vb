Public MustInherit Class Plan
    Private _credito As UInteger
    Private _nombre As String
    Private _precio As Single
    Protected _consumo As UInteger
    Sub New()
        _credito = 0
        _nombre = ""
        _precio = 0.0
        _consumo = 0
    End Sub
    Sub New(credito As UInteger, nombre As String, precio As Single)
        Me.New()
        Me.Credito = credito
        Me.Nombre = nombre
        Me.Precio = precio
    End Sub
    Public Property Credito As UInteger
        Get
            Return _credito
        End Get
        Set(value As UInteger)
            _credito = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Precio As Single
        Get
            Return _precio
        End Get
        Set(value As Single)
            _precio = value
        End Set
    End Property
    
    Public MustOverride Function disponible() As String

    Public Sub addConsumo(valor As UInteger)
        If valor + _consumo <= Credito Then
            _consumo += valor
        End If
    End Sub
End Class
