// Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario

        Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Tabla de multiplicar del número " + numero + ":");

        for (int i = 1; i <= 12; i++)
        {
            int resultado = numero * i;
            Console.WriteLine(numero + " x " + i + " = " + resultado);
        }


