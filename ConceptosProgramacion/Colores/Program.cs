do{
    Console.WriteLine("POR FAVOR ELIJE UNA DE LAS SIGUIENTES OPCIONES");
    Console.WriteLine("1.Amarillo");
    Console.WriteLine("2.Morado");
    Console.WriteLine("3.Rosado");
    Console.WriteLine("4.Azul");
    Console.WriteLine("5.Rojo");
    Console.WriteLine("6.Magenta");
    Console.WriteLine("7.Gris");
    Console.WriteLine("8.Negro");
    Console.WriteLine("9.Verde");
    Console.WriteLine("10.Blanco");
    Console.Write("Seleccione una opcion: ");

    var opcion = int.Parse(Console.ReadLine());

    Console.Write("INGRESE SU NOMBRE: ");
    var Nombre = Console.ReadLine();

    Console.Write("INGRESE SU DOCUMENTO: ");
    var Documento = Console.ReadLine();

    if (opcion == 1)
    {
        Console.WriteLine($"Gracias {Nombre} Su color preferido es Amarillo!!");
    }
    else if (opcion == 2)
    {
        Console.WriteLine($"Gracias {Nombre} Su color preferido es Morado!!");
    }
    else if (opcion == 3)
    {
        Console.WriteLine($"Gracias {Nombre} Su color preferido es Rosado!!");
    }
    else if (opcion == 4)
    {
        Console.WriteLine($"Gracias {Nombre} Su color preferido es Azul!!");
    }
    else if (opcion == 5)
    {
        Console.WriteLine($"Gracias {Nombre} Su color preferido es Rojo!!");
    }
    else if (opcion == 6)
    {
        Console.WriteLine($"Gracias {Nombre} Su color preferido es Magenta y recibiras un premio!!");
    }
    else if (opcion == 7)
    {
        Console.WriteLine($"Gracias {Nombre} Su color preferido es Gris!!");
    }
    else if (opcion == 8)
    {
        Console.WriteLine($"Gracias {Nombre} Su color preferido es Negro!!");
    }
    else if (opcion == 9)
    {
        Console.WriteLine($"Gracias {Nombre} Su color preferido es Verde!!");
    }
    else
    {
        Console.WriteLine($"Gracias {Nombre} Su color preferido es Blanco!!");
    }

} while (true);
