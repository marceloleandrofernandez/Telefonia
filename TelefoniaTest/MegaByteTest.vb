Imports TelefoniaEntidades
Module MegaByteTest
    Sub main()
        Dim mor As New MegaByte(100, "Megabyte", 150)
        Console.WriteLine("[*] Test de Mega [*]")
        mor.Credito = 120
        mor.addConsumo(4225567)
        Console.WriteLine("Credito: {0}", mor.Credito)
        Console.WriteLine("Disponible: {0}", mor.disponible)
        mor.addConsumo(4225567)
        Console.WriteLine("Credito: {0}", mor.Credito)
        Console.WriteLine("Disponible: {0}", mor.disponible)
        mor.addConsumo(1048526 * 120)
        Console.WriteLine("Credito: {0}", mor.Credito)
        Console.WriteLine("Disponible: {0}", mor.disponible)



        ''Console.WriteLine(calcu(1048526))

        'Console.WriteLine("Nombre Plan :{0}", mor.Nombre)
        'Console.WriteLine("Credito: {0}", mor.Credito)
        'Console.WriteLine("Precio: {0}", mor.Precio)
        'Console.WriteLine("Disponible: {0}", mor.disponible)
        'mor.addConsumo(10)
        'Console.WriteLine("Disponible: {0}", mor.disponible)
        'mor.addConsumo(10)
        'Console.WriteLine("Disponible: {0}", mor.disponible)
        'mor.addConsumo(80)
        'Console.WriteLine("Disponible: {0}", mor.disponible)
        'mor.addConsumo(80)
        'Console.WriteLine("Disponible: {0}", mor.disponible)
        'mor.addConsumo(20)
        'Console.WriteLine("Disponible: {0}", mor.disponible)
        Console.ReadKey()
    End Sub
    Function calcu(baites As UInteger) As Double
        Dim megas As Decimal
        megas = baites / 1014 ^ 2

        Return Math.Round(megas, 3)
    End Function
End Module
