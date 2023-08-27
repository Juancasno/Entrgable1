namespace AdivinanzaFraseOculta
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseOriginal = "Los ninos juegan a las escondidas en el parque";
            string[] palabrasOcultas = { "ninos", "juegan", "escondidas", "parque" };

            string fraseOculta = GenerarFraseOculta(fraseOriginal, palabrasOcultas);

            Console.WriteLine("Juego de Adivinanza de Frase Oculta!");
            Console.WriteLine("Adivina las palabras ocultas en la siguiente frase:");
            Console.WriteLine(fraseOculta);

            int intentosRestantes = 10;
            List<string> palabrasAdivinadas = new List<string>();

            while (intentosRestantes > 0)
            {
                Console.Write("Ingresa una palabra: ");
                string palabraIngresada = Console.ReadLine().ToLower();

                if (Array.Exists(palabrasOcultas, palabra => palabra == palabraIngresada) && !palabrasAdivinadas.Contains(palabraIngresada))
                {
                    Console.WriteLine("¡Has adivinado una palabra!.");
                    palabrasAdivinadas.Add(palabraIngresada);

                    if (palabrasAdivinadas.Count == palabrasOcultas.Length)
                    {
                        Console.WriteLine("¡Has adivinado todas las palabras!.");
                        Console.WriteLine("La frase es: " + fraseOriginal);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto. Intenta de nuevo.");
                    intentosRestantes--;
                    Console.WriteLine("Intentos restantes: " + intentosRestantes);
                }
            }

            if (intentosRestantes == 0)
            {
                Console.WriteLine("¡Se agotarón todos tus intentos! La frase era: " + fraseOriginal);
            }
        }

        static string GenerarFraseOculta(string fraseOriginal, string[] palabrasOcultas)
        {
            foreach (string palabra in palabrasOcultas)
            {
                fraseOriginal = fraseOriginal.Replace(palabra, new string('_', palabra.Length));
            }
            return fraseOriginal;
        }
    }
}