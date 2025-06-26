using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int numeroSecreto = rand.Next(1, 101);
            int intento;
            int intentos = 0;

            Console.WriteLine("🎯 ¡Adivina el número del 1 al 100!");

            do
            {
                Console.Write("👉 Escribe tu número: ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out intento))
                {
                    Console.WriteLine("⚠️ Eso no es un número válido.");
                    continue;
                }

                intentos++;

                if (intento < numeroSecreto)
                    Console.WriteLine("🔻 Muy bajo...");
                else if (intento > numeroSecreto)
                    Console.WriteLine("🔺 Muy alto...");
                else
                    Console.WriteLine($"\n🎉 ¡Correcto! Lo lograste en {intentos} intentos.");
            }
            while (intento != numeroSecreto);

            Console.WriteLine("Gracias por jugar 👋");
        }
    }
}
