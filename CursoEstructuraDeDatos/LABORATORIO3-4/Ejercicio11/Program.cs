//11)	Multiplica una matriz por un número. 

class Program
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int multiplicador = 2; // El número por el que multiplicar la matriz

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int[,] resultado = new int[filas, columnas];

        // Multiplicar cada elemento de la matriz por el número dado
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz[i, j] * multiplicador;
            }
        }

        Console.WriteLine("Matriz resultante de la multiplicación por " + multiplicador + ":");

        // Mostrar la matriz resultante
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(resultado[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
