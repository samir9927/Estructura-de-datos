//Crea una matriz de números aleatorios de tamaño 100x100

class Program
{
    static void Main()
    {
        // Semilla para generar números aleatorios
        Random rnd = new Random();

        // Tamaño de la matriz
        int filas = 100;
        int columnas = 100;

        // Crear la matriz
        int[,] matriz = new int[filas, columnas];

        // Llenar la matriz con números aleatorios
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = rnd.Next(1, 101); // Números aleatorios entre 1 y 100
            }
        }

        // Imprimir algunos elementos para verificar
        Console.WriteLine("Algunos elementos de la matriz:");
        Console.WriteLine("Matriz[0,0]: " + matriz[0, 0]);
        Console.WriteLine("Matriz[50,50]: " + matriz[50, 50]);
        Console.WriteLine("Matriz[99,99]: " + matriz[99, 99]);

        // Puedes hacer cualquier otra operación con la matriz aquí...
    }
}
