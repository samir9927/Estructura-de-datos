// Escribe una función recursiva que imprima la suma de los números del 1 al n.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La suma de los números del 1 al " + numero + " es: " + SumaDeNumeros(numero));
    }

    static int SumaDeNumeros(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n + SumaDeNumeros(n - 1);
        }
    }
}

