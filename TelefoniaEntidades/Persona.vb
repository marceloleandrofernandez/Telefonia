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
        If Len(apellido) < 31 And apellido <> "" Then
            Me._apellido = apellido
        End If
        If Len(nombre) < 51 And nombre <> "" Then
            Me._nombre = nombre
        End If
        Me._documento = documento
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



