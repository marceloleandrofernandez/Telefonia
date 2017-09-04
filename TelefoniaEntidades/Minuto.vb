Public NotInheritable Class Minuto
    Inherits Plan
    Sub New()
        MyBase.New()
    End Sub
    Sub New(credito As UInteger, nombre As String, precio As Single)
        MyBase.New()
        MyBase.Credito = credito
        MyBase.Nombre = nombre
        MyBase.Precio = precio
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.Nombre
    End Function
    Public Overrides Function disponible() As String
        Return Credito - _consumo & " " & Nombre
    End Function
End Class
