Imports TelefoniaEntidades
Module LineaTest
    Sub main()
        Dim linea As New Linea(376, 4556677)
        Console.WriteLine("[*]-TEST DE LINEA-[*]")
        Console.WriteLine("[*] Valores asignados al constructor [*]")
        Console.WriteLine("Codigo de Area {0}", linea.CodigoArea)
        Console.WriteLine("Numero {0}", linea.Numero)
        Console.WriteLine("Estado {0}", linea.Estado)

        Console.WriteLine("[*] Valores Asignados MAYORES al maximo permitido [*]")
        linea.CodigoArea = 20000
        linea.Numero = 20000000
        linea.Reactivar()
        Console.WriteLine("Codigo de Area {0}", linea.CodigoArea)
        Console.WriteLine("Numero {0}", linea.Numero)
        Console.WriteLine("Estado {0}", linea.Estado)

        Console.WriteLine("[*] Valores Asignados MENORES al Minimo permitido [*]")
        linea.CodigoArea = 45
        linea.Numero = 90000
        linea.Suspender()
        Console.WriteLine("Codigo de Area {0}", linea.CodigoArea)
        Console.WriteLine("Numero {0}", linea.Numero)
        Console.WriteLine("Estado {0}", linea.Estado)

        Console.WriteLine("[*] Valores Asignados DENTRO del rango permitido [*]")
        linea.CodigoArea = 3755
        linea.Numero = 4203450
        linea.Reactivar()
        Console.WriteLine("Codigo de Area {0}", linea.CodigoArea)
        Console.WriteLine("Numero {0}", linea.Numero)
        Console.WriteLine("Estado {0}", linea.Estado)

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ReadKey()
    End Sub
End Module
