Imports TelefoniaEntidades
Module MegaByteTest
    Sub New()
        Dim mor As New MegaByte(100, "Mordida", 150)

        Console.WriteLine("[*] Test de Mordida [*]")
        mor.Credito = 120
        Console.WriteLine("Nombre Plan :{0}", mor.Nombre)
        Console.WriteLine("Credito: {0}", mor.Credito)
        Console.WriteLine("Precio: {0}", mor.Precio)
        Console.WriteLine("Disponible: {0}", mor.disponible)
        mor.addConsumo(10)
        Console.WriteLine("Disponible: {0}", mor.disponible)
        mor.addConsumo(10)
        Console.WriteLine("Disponible: {0}", mor.disponible)
        mor.addConsumo(80)
        Console.WriteLine("Disponible: {0}", mor.disponible)
        mor.addConsumo(80)
        Console.WriteLine("Disponible: {0}", mor.disponible)
        mor.addConsumo(20)
        Console.WriteLine("Disponible: {0}", mor.disponible)
        Console.ReadKey()
    End Sub
End Module
