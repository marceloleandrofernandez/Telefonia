Public Class Equipo
    Private _marca As String  ' 30
    Private _modelo As String ' 50
    Private _serie As String  ' 15
    Private _fechaVenta As Date
    Sub New()
        _marca = "Default"
        _modelo = "Default"
        _serie = "Default"
        _fechaVenta = Nothing
    End Sub
    Sub New(marca As String, modelo As String, serie As String)
        If Len(marca) < 31 And marca <> "" Then
            Me._marca = marca
        End If
        If Len(modelo) < 51 And modelo <> "" Then
            Me._modelo = modelo
        End If
        If Len(serie) < 16 And serie <> "" Then
            Me._serie = serie
        End If
    End Sub
    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            If Len(value) < 31 And value <> "" Then
                _marca = value
            End If
        End Set
    End Property
    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            If Len(value) < 51 And value <> "" Then
                _modelo = value
            End If
        End Set
    End Property
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If Len(value) < 16 And value <> "" Then
                _serie = value
            End If
        End Set
    End Property
    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property
    Public Sub Vender(fecha As Date)
        _fechaVenta = fecha
    End Sub

End Class
