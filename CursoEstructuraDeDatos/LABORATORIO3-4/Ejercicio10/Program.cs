// 10)	Suma dos matrices de diferentes tamaños. 

class Program
{
    static void Main()
    {
        int[,] matriz1 = {
            {1, 2, 3},
            {4, 5, 6}
        };

        int[,] matriz2 = {
            {7, 8},
            {9, 10}
        };

        int filas = Math.Min(matriz1.GetLength(0), matriz2.GetLength(0));
        int columnas = Math.Min(matriz1.GetLength(1), matriz2.GetLength(1));

        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        Console.WriteLine("Matriz resultante de la suma:");

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
