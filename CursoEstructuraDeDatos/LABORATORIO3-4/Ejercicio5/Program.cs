// Escribe una función recursiva que imprima la tabla de multiplicar del n. 

class Program
{
    static void Main(string[] args)
    {
        int n = 5; // Puedes cambiar este valor a cualquier número deseado
        Console.WriteLine("Tabla de multiplicar del " + n + ":");
        ImprimirTablaMultiplicar(n, 1);
    }

    static void ImprimirTablaMultiplicar(int n, int multiplicador)
    {
        // Caso base: cuando el multiplicador alcanza 13, terminamos la recursión
        if (multiplicador == 13)
            return;

        // Imprime el resultado de la multiplicación
        Console.WriteLine(n + " x " + multiplicador + " = " + (n * multiplicador));

        // Llama recursivamente a la función con el siguiente multiplicador
        ImprimirTablaMultiplicar(n, multiplicador + 1);
    }
}
