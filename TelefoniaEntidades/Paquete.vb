Public Class Paquete
    Implements IServicio

    Private _plan As List(Of Plan)
    Sub New()
        _plan = New List(Of Plan)
    End Sub
    Public Sub addPlan(plan As Plan)
        _plan.Add(plan)
    End Sub
    Public Function getAllPlan() As List(Of Plan)
        Return _plan
    End Function
    Public Sub removePlan(plan As Plan)
        _plan.Remove(plan)
    End Sub
    'Revisame!
    Public Function getDisponible() As String Implements IServicio.getDisponible
        Dim coso As String
        coso = ""
        For Each item In getAllPlan()
            coso += "Nombre Plan: " & item.Nombre & " " & "Precio: " & item.Credito & vbCrLf
        Next
        Return coso
    End Function
    Public Property Nombre As String Implements IServicio.Nombre

    Public Property Precio As Single Implements IServicio.Precio
End Class
