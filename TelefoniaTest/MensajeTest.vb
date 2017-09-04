Imports TelefoniaEntidades
Module MensajeTest
    Sub New()
        Dim men As New Minuto(100, "Mensaje", 150)

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




        Console.ReadKey()
    End Sub
End Module
