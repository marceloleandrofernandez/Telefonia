Public Class Persona
    Private _apellido As String ' 30
    Private _nombre As String   ' 50
    Private _documento As UInteger
    Sub New()
        _apellido = ""
        _nombre = ""
        _documento = 0
    End Sub
    Sub New(apellido As String, nombre As String, documento As UInteger)
        Me.New()
        Me.Apellido = apellido
        Me.Nombre = nombre
        Me.Documento = documento
    End Sub
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If Len(value) < 31 And value <> "" Then
                _apellido = value
            End If
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If Len(value) < 51 And value <> "" Then
                _nombre = value
            End If
        End Set
    End Property
    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property
End Class



