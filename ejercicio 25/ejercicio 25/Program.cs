int opcion = 0;

while (opcion != 3)
{
    Console.WriteLine("1. Saludar");
    Console.WriteLine("2. Mostrar mensaje");
    Console.WriteLine("3. Salir");
    Console.Write("Elija una opción: ");

    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola, bienvenido!");
            break;

        case 2:
            Console.WriteLine("Este es un menú con while.");
            break;

        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    Console.WriteLine();
}