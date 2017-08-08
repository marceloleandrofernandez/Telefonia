Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String
    Sub New()
        _codigoArea = 0
        _numero = 0
        _estado = ""
    End Sub
    Sub New(codigoArea As UShort, numero As UInteger)
        Me.New()
        Me.CodigoArea = codigoArea
        Me.Numero = numero
    End Sub
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If value > 99 And value < 10000 Then
                _codigoArea = value
            End If
        End Set
    End Property
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            If value > 99999 And value < 10000000 Then
                _numero = value
            End If
        End Set
    End Property

    Public ReadOnly Property Estado As String
        Get
            Return _estado
        End Get
    End Property
    Public Sub Reactivar()
        _estado = "Activa"
    End Sub
    Public Sub Suspender()
        _estado = "Suspendida"
    End Sub
End Class
