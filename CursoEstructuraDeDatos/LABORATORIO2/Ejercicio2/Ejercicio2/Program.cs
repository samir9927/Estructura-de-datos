//2)	Solicita un número al usuario y determina si es par o impar. 

Console.WriteLine("Ingrese un número:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
Console.WriteLine("El número ingresado es par.");
}
else
{
Console.WriteLine("El número ingresado es impar.");
}

