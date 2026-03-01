Console.WriteLine("ingrese numeros hasta que la sume supere 100");
 int suma = 0;
    while (suma <= 100)
    {
        Console.WriteLine("ingrese un numero");
        int numero = int.Parse(Console.ReadLine());
        suma += numero;
    }
    Console.WriteLine("la suma supero 100, la suma total es: " + suma);
  