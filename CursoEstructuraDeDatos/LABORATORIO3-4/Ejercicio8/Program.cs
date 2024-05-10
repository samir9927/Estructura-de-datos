// 8)	Crea una matriz de matrices. 
class Program
{
    static void Main(string[] args)
    {
        // Crear una matriz de matrices de enteros
        int[][] matrizDeMatrices = new int[2][];

        // Asignar matrices individuales a cada elemento de la matriz principal
        matrizDeMatrices[0] = new int[] { 1, 2, 3 };
        matrizDeMatrices[1] = new int[] { 4, 5, 6, 7 };

        // Imprimir la matriz de matrices
        Console.WriteLine("Matriz de matrices de enteros:");
        ImprimirMatrizDeMatrices(matrizDeMatrices);
    }

    static void ImprimirMatrizDeMatrices(int[][] matrizDeMatrices)
    {
        for (int i = 0; i < matrizDeMatrices.Length; i++)
        {
            Console.Write("Matriz " + i + ": ");
            for (int j = 0; j < matrizDeMatrices[i].Length; j++)
            {
                Console.Write(matrizDeMatrices[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

