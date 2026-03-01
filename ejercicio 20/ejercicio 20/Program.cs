Console.WriteLine("ingrese numero");
int numero = int.Parse(Console.ReadLine());
int contador = 0;
while (numero > 0)
{
    numero = numero / 10;
    contador++;
}
Console.WriteLine("El numero tiene " + contador + " digitos.");
