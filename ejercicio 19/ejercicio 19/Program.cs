Console.WriteLine("ingrese la tabala de de multiplar del nummero que dese");
int numero = int.Parse(Console.ReadLine());
int i = 0;
while (i <= numero)
{
    while (i <=10)
    {
        Console.WriteLine($"{i} x {numero} = {i * numero}");
        i++;
    }
}
