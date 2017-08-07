Imports TelefoniaEntidades
Module EquipoTest

    Sub Main()
        Console.WriteLine("[*]-Test de Equipo-[*]")

        Dim equipo1 As New Equipo("Nokia", "N-Saraza", "N-series")
        Dim equipo2 As New Equipo("Samsung", "Relox", "A23411")
        Console.WriteLine("[*] Valores Asignados al constructor[*]")
        Console.WriteLine("Marca : {0}", equipo1.Marca)
        Console.WriteLine("Modelo : {0}", equipo1.Modelo)
        Console.WriteLine("Serie : {0}", equipo1.Serie)
        equipo1.Vender("1/8/2017")
        Console.WriteLine("Fecha Venta : {0}", equipo1.FechaVenta)

        Console.WriteLine("[*] Despues de tratar de modificar con valores MAYORES [*]")
        equipo1.Marca = "masdetrintacaracterestienenqueentrarenSAMSUNG"
        equipo1.Modelo = "acasonmasdecincuentacaracteresasiqueestalineatienequesermaslargaGALAXY"
        equipo1.Serie = "EstassonquincecaracteresnomaS20"
        equipo1.Vender(" 12 /12/2017")
        Console.WriteLine("Marca : {0}", equipo1.Marca)
        Console.WriteLine("Modelo : {0}", equipo1.Modelo)
        Console.WriteLine("Serie : {0}", equipo1.Serie)
        Console.WriteLine("Fecha Venta : {0}", equipo1.FechaVenta)

        Console.WriteLine("[*] Despues de tratar de modificar con valores VACIOS [*]")
        equipo1.Marca = ""
        equipo1.Modelo = ""
        equipo1.Serie = ""
        equipo1.Vender("12/12/2027")
        Console.WriteLine("Marca : {0}", equipo1.Marca)
        Console.WriteLine("Modelo : {0}", equipo1.Modelo)
        Console.WriteLine("Serie : {0}", equipo1.Serie)
        Console.WriteLine("Fecha Venta : {0}", equipo1.FechaVenta)

        Console.WriteLine("[*] Despues de tratar de modificar con valores DENTRO del rango [*]")
        equipo1.Marca = "Aifone"
        equipo1.Modelo = "Faiv es"
        equipo1.Serie = "Es"
        equipo1.Vender("2/12/2027")
        Console.WriteLine("Marca : {0}", equipo1.Marca)
        Console.WriteLine("Modelo : {0}", equipo1.Modelo)
        Console.WriteLine("Serie : {0}", equipo1.Serie)
        Console.WriteLine("Fecha Venta : {0}", equipo1.FechaVenta)
        'Console.WriteLine("Marca : {0}", equipo2.Marca)
        'Console.WriteLine("Modelo : {0}", equipo2.Modelo)
        'Console.WriteLine("Serie : {0}", equipo2.Serie)
        'Console.WriteLine("Fecha Venta : {0}", equipo2.FechaVenta)
        Console.ReadKey()

    End Sub

End Module
