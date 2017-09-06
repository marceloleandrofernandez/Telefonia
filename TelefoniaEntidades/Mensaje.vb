Public NotInheritable Class Mensaje
    Inherits Plan
    Sub New()
        Me.New(0, "", 0.0)
    End Sub
    Sub New(credito As UInteger, nombre As String, precio As Single)
        MyBase.New(credito, nombre, precio)
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.Nombre
    End Function
    Public Overrides Function disponible() As String
        Return Credito - _consumo & " " & ToString()
    End Function
End Class
