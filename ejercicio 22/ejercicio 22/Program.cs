Console.WriteLine("ingrese contrasena");
while (true)
{
    string contraseña = Console.ReadLine();
    if (contraseña == "contrasena")
    {
        Console.WriteLine("contraseña correcta");
        break;
    }
    else
    {
        Console.WriteLine("contraseña incorrecta, intente de nuevo");
    }
}