do
{
    Console.Write("Ingrese un numero:");
    var numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("El numero es Par");
    }
    else
    {
        Console.WriteLine("El numero es impar ");
    }
}while (true);