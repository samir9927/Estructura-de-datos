// 6)	Crea una matriz de números reales. 

class Program
{
    static void Main(string[] args)
    {
        // Crear una matriz de 3x3
        double[,] matriz = new double[3, 3];

        // Asignar valores a la matriz
        matriz[0, 0] = 1.5;
        matriz[0, 1] = 2.7;
        matriz[0, 2] = 3.8;
        matriz[1, 0] = 4.2;
        matriz[1, 1] = 5.3;
        matriz[1, 2] = 6.1;
        matriz[2, 0] = 7.9;
        matriz[2, 1] = 8.4;
        matriz[2, 2] = 9.0;

        // Imprimir la matriz
        Console.WriteLine("Matriz de números reales:");
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
