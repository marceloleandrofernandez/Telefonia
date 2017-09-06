Imports TelefoniaEntidades
Module MensajeTest
    Sub main()
        Dim men As New Mensaje(100, "Mensaje", 150)

        Console.WriteLine("[*] Test de Mensaje [*]")
        men.Credito = 120
        Console.WriteLine("Nombre Plan :{0}", men.Nombre)
        Console.WriteLine("Credito: {0}", men.Credito)
        Console.WriteLine("Precio: {0}", men.Precio)
        Console.WriteLine("Disponible: {0}", men.disponible)
        men.addConsumo(10)
        Console.WriteLine("Disponible: {0}", men.disponible)
        men.addConsumo(10)
        Console.WriteLine("Disponible: {0}", men.disponible)
        men.addConsumo(80)
        Console.WriteLine("Disponible: {0}", men.disponible)
        men.addConsumo(80)
        Console.WriteLine("Disponible: {0}", men.disponible)
        men.addConsumo(20)
        Console.WriteLine("Disponible: {0}", men.disponible)
        Dim men2 As Plan
        men2 = New Mensaje(100, "Mensaje", 300)



        Console.ReadKey()
    End Sub
End Module
