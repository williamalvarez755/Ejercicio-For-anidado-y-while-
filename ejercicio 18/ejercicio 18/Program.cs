using System.Timers;

int factorial=1;
int i=1;
Console.WriteLine("ingrese el numero de que desea calcular el factorial");
int numero = int.Parse(Console.ReadLine());
while ( i<= numero)
{
    factorial = i * factorial;
        i++;
}
Console.WriteLine($"el factorias de {numero} es {factorial}");