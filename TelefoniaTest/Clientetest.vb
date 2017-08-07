Imports TelefoniaEntidades
Module Clientetest
    Sub main()
        Dim cli As New Cliente
        Console.WriteLine("[*]-TEST DE CLIENTE-[*]")
        cli.Id = 7777
        Console.WriteLine("ID de Cliente: {0}", cli.Id)
        Console.WriteLine("[*] Asignando valor diferente [*]")
        cli.Id = 8888
        Console.WriteLine("ID de Cliente: {0}", cli.Id)
        Console.ReadKey()

    End Sub
End Module
