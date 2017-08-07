Imports TelefoniaEntidades
Module EmpresaTest
    Sub main()
        Dim emp As New Empresa("Cooperativa Cooperacion", "30-24568794-7")
        Console.WriteLine("[*]-TEST DE EMPRESA-[*]")
        Console.WriteLine("[*] Valores asignados al constructor [*]")
        Console.WriteLine("Razon Social {0}", emp.RazonSocial)
        Console.WriteLine("Cuit: {0}", emp.Cuit)

        Console.WriteLine("[*] Valores Asignados MAYORES al maximo permitido [*]")
        emp.RazonSocial = "unodostrescuatrocincoseissieteochonuevediezonceñlasdkjfasdhflkjasdhflakjsdhflkasdjhfaksdhflaskdghlasdkfglasdkghlaskdfh"
        emp.Cuit = "kidmasjfkeopsd"
        Console.WriteLine("Razon Social: {0}", emp.RazonSocial)
        Console.WriteLine("Cuit: {0}", emp.Cuit)

        Console.WriteLine("[*] Valores Asignados VACIOS [*]")
        emp.RazonSocial = ""
        emp.Cuit = ""
        Console.WriteLine("Razon Social: {0}", emp.RazonSocial)
        Console.WriteLine("Cuit: {0}", emp.Cuit)

        Console.WriteLine("[*] Valores Asignados DENTRO del rango permitido [*]")
        emp.RazonSocial = "Una Empresa SRL"
        emp.Cuit = "31-33222444-8"
        Console.WriteLine("Razon Social: {0}", emp.RazonSocial)
        Console.WriteLine("Cuit: {0}", emp.Cuit)

        Console.ReadKey()
    End Sub
End Module
