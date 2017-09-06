Public NotInheritable Class MegaByte
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
    Public Overrides Sub addConsumo(valor As UInteger)
        valor = valor / 1024 ^ 2
        Console.WriteLine(valor)
        If valor + _consumo <= Credito Then
            _consumo += valor
        End If
    End Sub
    Public Overrides Function disponible() As String
        Return Credito - _consumo & " " & ToString() & "(s)"
    End Function
End Class
