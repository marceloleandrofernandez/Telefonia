﻿Public Class Cliente
    Private _id As Integer
    Sub New()
        _id = 0
    End Sub
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
End Class
