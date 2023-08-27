// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace NumerosEspecial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            if (NumeroEspecial(numero))
            {
                Console.WriteLine("El número es especial.");
            }
            else
            {
                Console.WriteLine("El número no es especial.");
            }
        }

        static bool NumeroEspecial(int num)
        {

            if (num % 5 != 0)
            {
                return false;
            }

            if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }

            int sumaDigitos = 0;
            int numero = num;
            while (numero > 0)
            {
                sumaDigitos += numero % 10;
                numero /= 10;
            }

            if (sumaDigitos > 10)
            {
                return true;
            }

            return false;
        }
    }
}
