// Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 
class Program
{
    static void Main(string[] args)
    {
        int n = 5; // Puedes cambiar este valor a cualquier número deseado
        ImprimirPiramideInvertida(n);
    }

    static void ImprimirPiramideInvertida(int n)
    {
        // Caso base: si n es 0, no hay nada que imprimir
        if (n == 0)
            return;

        // Imprime la fila actual de números invertidos
        for (int i = n; i >= 1; i--)
            Console.Write(i + " ");

        Console.WriteLine(); // Salto de línea al final de cada fila

        // Llama recursivamente a la función para imprimir la pirámide invertida de n-1 números
        ImprimirPiramideInvertida(n - 1);
    }
}

