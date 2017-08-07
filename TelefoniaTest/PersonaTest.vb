Imports TelefoniaEntidades
Module PersonaTest
    Sub main()
        Dim pers As New Persona("Perez", "Juan", 33555999)
        Console.WriteLine("[*]-TEST DE PERSONA-[*]")
        Console.WriteLine("[*] Valores asignados al constructor [*]")
        Console.WriteLine("Apellido {0}", pers.Apellido)
        Console.WriteLine("Nombre {0}", pers.Nombre)
        Console.WriteLine("DNI {0}", pers.Documento)

        Console.WriteLine("[*] Valores Asignados MAYORES al maximo permitido [*]")
        pers.Nombre = "sjkaouyedmasldmnaisndlapoojdjaislandjalslhjalalsldjslalsldjdlsjsldjeldla"
        pers.Apellido = "aassdaasdlfmfneidnskalsldjdlalsldjslalsldjdlsjsldjeldlaleldjalslejdlsl"
        Console.WriteLine(Len(pers.Nombre))
        pers.Documento = 22888777
        Console.WriteLine("Apellido {0}", pers.Apellido)
        Console.WriteLine("Nombre {0}", pers.Nombre)
        Console.WriteLine("DNI {0}", pers.Documento)

        Console.WriteLine("[*] Valores Asignados VACIOS [*]")
        pers.Nombre = ""
        pers.Apellido = ""
        pers.Documento = 22888777
        Console.WriteLine("Apellido {0}", pers.Apellido)
        Console.WriteLine("Nombre {0}", pers.Nombre)
        Console.WriteLine("DNI {0}", pers.Documento)

        Console.WriteLine("[*] Valores Asignados DENTRO del rango permitido [*]")
        pers.Nombre = "Ramona Juliana"
        pers.Apellido = "Cacerez Quintana"
        pers.Documento = 55999555
        Console.WriteLine("Apellido {0}", pers.Apellido)
        Console.WriteLine("Nombre {0}", pers.Nombre)
        Console.WriteLine("DNI {0}", pers.Documento)
        Console.ReadKey()
    End Sub
End Module
