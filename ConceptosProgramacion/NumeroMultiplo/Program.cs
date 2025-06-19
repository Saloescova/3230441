do
{
    Console.WriteLine("Ingrese el primer numero:");
    var N1 = (Console.ReadLine());

    if (int.TryParse(N1, out int N1Int))
    {
        Console.WriteLine("Ingrese segundo numero:");
        var N2 = Console.ReadLine();
        if (int.TryParse(N2, out int N2Int))
        {
            
            if (N1Int % N2Int == 0)
            {
                Console.WriteLine($"El numero: {N2},es multiplo de:{N1}");
            }
            else
            {
                Console.WriteLine($"El numero: {N2},no es multiplo de:{N1}");
            }
        }
        else
        {
            Console.WriteLine("debes ingresar un entero!!");
        }
    }
    else
    {
        Console.WriteLine("El numero:");
    }






    
  


   
    }while (true) ;
   