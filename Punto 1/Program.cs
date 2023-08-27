// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Calculadora
{
    class Program
    {
        static string ultimaOperacion = "";

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("1. Realizar Operación");
                Console.WriteLine("2. Mostrar la última operación realizada");
                Console.WriteLine("3. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RealizarOperacion();
                        break;
                    case 2:
                        MostrarUltimaOperacion();
                        break;
                    case 3:
                        Console.WriteLine("Salir");
                        break;
                }
            } while (opcion != 3);
        }

        static void RealizarOperacion()
        {
            Console.WriteLine("Ingrese el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el operador (+ para suma, - para resta, % para dividir, * la multiplicación):");
            char operador = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0.0;
            string operacion = "";

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    operacion = $"{num1} + {num2} = {resultado}";
                    break;
                case '-':
                    resultado = num1 - num2;
                    operacion = $"{num1} - {num2} = {resultado}";
                    break;

                case '*':
                    resultado = num1 * num2;
                    operacion = $"{num1} * {num2} = {resultado}";

                    break;

                case '%':
                    resultado = num1 % num2;
                    operacion = $"{num1} % {num2} = {resultado}";

                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");
            ultimaOperacion = operacion;

            if (num2 == 0)
            {
                Console.WriteLine("¡Error, No se puede dividir por cero!");

            }
            else
            {
                resultado = num1 % num2;
                Console.WriteLine("La division es:");
            }
        }

        static void MostrarUltimaOperacion()
        {
            if (!string.IsNullOrEmpty(ultimaOperacion))
            {
                Console.WriteLine("Última operación realizada:");
                Console.WriteLine(ultimaOperacion);
            }
            else
            {
                Console.WriteLine("No hay operaciones registradas.");
            }
        }
    }
}
