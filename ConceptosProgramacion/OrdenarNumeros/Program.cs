do
{
    Console.WriteLine("Ingrese el primer numero:");
    var N1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese segundo numero:");
    var N2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese tercer numero:");
    var N3 = int.Parse(Console.ReadLine());

    if (N1 > N2 & N2 > N3)
    {
        Console.WriteLine($"El numero mayor es:{N1}");
        Console.WriteLine($"El numero medio es:{N2}");
        Console.WriteLine($"El numero menor es:{N3}");
    }
    else if (N1 > N3 & N3 > N2)
    {
        Console.WriteLine($"El numero mayor es:{N2}");
        Console.WriteLine($"El numero medio es:{N3}");
        Console.WriteLine($"El numero menor es:{N1}");
    }
    else if (N2 > N1 & N1 > N3)
    {
        Console.WriteLine($"El numero mayor es:{N2}");
        Console.WriteLine($"El numero medio es:{N1}");
        Console.WriteLine($"El numero menor es:{N3}");
    }
    else if (N2 > N3 & N3 > N1)
    {
        Console.WriteLine($"El numero mayor es:{N2}");
        Console.WriteLine($"El numero medio es:{N3}");
        Console.WriteLine($"El numero menor es:{N1}");
    }
    else if (N3 > N1 & N1 > N2)
    {
        Console.WriteLine($"El numero mayor es:{N3}");
        Console.WriteLine($"El numero medio es:{N1}");
        Console.WriteLine($"El numero menor es:{N2}");
    }
    else
    {
        Console.WriteLine($"El numero mayor es:{N3}");
        Console.WriteLine($"El numero medio es:{N2}");
        Console.WriteLine($"El numero menor es:{N1}");

    }

} while (true);
