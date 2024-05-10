// Escribe una función recursiva que imprima los números pares del 1 al 100

class Program
{
    static void Main(string[] args)
    {
        NumerosPares(1);
    }

    static void NumerosPares(int num)
    {
        if (num <= 100)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
            NumerosPares(num + 1);
        }
    }
}

