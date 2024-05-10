// 12)	Calcula la media de los elementos de una matriz. 

class Program
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Suma de todos los elementos de la matriz
        int suma = 0;

        // Calcular la suma de los elementos de la matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
        }

        // Calcular la media de los elementos de la matriz
        double media = (double)suma / (filas * columnas);

        Console.WriteLine("La media de los elementos de la matriz es: " + media);
    }
}

