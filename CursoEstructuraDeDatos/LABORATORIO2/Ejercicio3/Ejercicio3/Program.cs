//3)	Pide la base y la altura de un triángulo al usuario y calcula su área.

Console.WriteLine("Ingrese la base del triángulo:");
double baseTriangulo = Convert.ToDouble(Console.ReadLine());

// Solicitar la altura del triángulo al usuario
Console.WriteLine("Ingrese la altura del triángulo:");
double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

// Calcular el área del triángulo
double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

// Mostrar el resultado
Console.WriteLine("El área del triángulo es: " + areaTriangulo);