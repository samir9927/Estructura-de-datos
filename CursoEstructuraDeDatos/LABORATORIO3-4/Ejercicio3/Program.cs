// Escribe una función recursiva que imprima la pirámide de números del 1 al n. 
class Program
{
    static void Main(string[] args)
    {
        int n = 5; // Puedes cambiar este valor a cualquier número deseado
        ImprimirPiramide(n);
    }

    static void ImprimirPiramide(int n)
    {
        // Caso base: si n es 0, no hay nada que imprimir
        if (n == 0)
            return;

        // Imprime la pirámide de n-1 números
        ImprimirPiramide(n - 1);

        // Imprime la fila actual de números
        for (int i = 1; i <= n; i++)
            Console.Write(i + " ");

        Console.WriteLine(); // Salto de línea al final de cada fila
    }
}

