namespace GeneradorTablasMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generador de Tablas de Multiplicar");

            Console.Write("Ingrese el número inicial de la tabla de multiplicar:");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número final de la tabla de multiplicar:");
            int final = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = inicio; i <= final; i++)
            {
                Console.WriteLine($"Tabla del {i}:");
                int multiOculto = random.Next(1, 11);
                int resultadoEsperado = i * multiOculto;

                for (int j = 1; j <= 10; j++)
                {
                    if (j == multiOculto)
                    {
                        Console.WriteLine($"{i} x ? = {i * j}");
                    }
                    else
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                    }
                }
                int intentos = 2;
                while (intentos > 0)
                {
                    Console.Write("Ingrese la respuesta: ");
                    int respuesta = int.Parse(Console.ReadLine());
                    if (respuesta == multiOculto)
                    {
                        Console.WriteLine("¡Respuesta correcta!");
                        break;
                    }
                    else
                    {
                        intentos--;
                        if (intentos > 0)
                        {
                            Console.WriteLine($"Respuesta incorrecta!. Quedan {intentos} intentos.");
                        }
                        else
                        {
                            Console.WriteLine($"Respuesta incorrecta. El número correcto era {multiOculto}.");
                        }
                    }
                }
            }
        }
    }
}