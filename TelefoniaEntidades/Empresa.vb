Public Class Empresa
    Private _razonSocial As String    '  80
    Private _cuit As String           '  13
    Sub New()
        _razonSocial = ""
        _cuit = ""
    End Sub
    Sub New(razonSocial As String, cuit As String)
        If Len(razonSocial) < 81 And razonSocial <> "" Then
            Me._razonSocial = razonSocial
        End If
        If Len(cuit) < 14 And razonSocial <> "" Then
            Me._cuit = cuit
        End If
    End Sub
    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            If Len(value) < 81 And value <> "" Then
                _razonSocial = value
            End If
        End Set
    End Property
    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If Len(value) < 14 And value <> "" Then
                _cuit = value
            End If
        End Set
    End Property
End Class
