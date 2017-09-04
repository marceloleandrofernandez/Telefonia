Imports TelefoniaEntidades
Module MinutoTest
    Sub main()
        Dim min As New Minuto(100, "Minutos", 150)

        Console.WriteLine("[*] Test de Minuto [*]")
        min.Credito = 120
        Console.WriteLine("Nombre Plan :{0}", min.Nombre)
        Console.WriteLine("Credito: {0}", min.Credito)
        Console.WriteLine("Precio: {0}", min.Precio)
        Console.WriteLine("Disponible: {0}", min.disponible)
        min.addConsumo(10)
        Console.WriteLine("Disponible: {0}", min.disponible)
        min.addConsumo(10)
        Console.WriteLine("Disponible: {0}", min.disponible)
        min.addConsumo(80)
        Console.WriteLine("Disponible: {0}", min.disponible)
        min.addConsumo(80)
        Console.WriteLine("Disponible: {0}", min.disponible)
        min.addConsumo(20)
        Console.WriteLine("Disponible: {0}", min.disponible)
        Console.ReadKey()
    End Sub
End Module
