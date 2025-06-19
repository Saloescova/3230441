
do { 
Console.WriteLine("POR FAVOR ELIJE UNA DE LAS SIGUIENTES OPCIONES");
Console.WriteLine("1.PERRO");
Console.WriteLine("2.GATITO");
Console.WriteLine("3.GALLINA");
Console.WriteLine("4.OVEJA");
Console.WriteLine("5.PEZ");
Console.Write("Seleccione una opcion");

var opcion=int.Parse(Console.ReadLine());

Console.Write("INGRESE SU NOMBRE");
var Nombre = Console.ReadLine();

 Console.Write("INGRESE SU DOCUMENTO");
 var Documento = Console.ReadLine();

    if (opcion == 1)
    {
        Console.WriteLine($"Gracias {Nombre} por elejir un Perro,Cuidalo!!");
    }
    else if (opcion == 2)
    {
        Console.WriteLine($"Gracias {Nombre} por elejir un Gatito,Cuidalo!!");
    }
    else if (opcion == 3)
    {
        Console.WriteLine($"Gracias {Nombre} por elejir la gallina,Cuidala!!");
    }
    else if (opcion == 4)
    {
        Console.WriteLine($"Gracias {Nombre} por elejir la Oveja,Cuidala!!");
    }
    else
    {
        Console.WriteLine($"Gracias {Nombre} por elejir el Pez,Cuidalo!!");
    }
} while(true);