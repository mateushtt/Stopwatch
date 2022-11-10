using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Deseja contar em minutos ou segundos?");
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("Quanto tempo deseja contar?");
            // Toda string lida será convertida para letras minúsculas 
            string data = Console.ReadLine().ToLower();
            // O método Substring pega uma parte da cadeia de caracteres, neste caso vai começar a contar da
            // última posição do Array, e pegará o primeiro caractere
            // data.Length conta quantos caracteres o usuário digitou
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }
        static void Start(int time)
        {
            int currentTime = 1;

            while (currentTime <= time)
            {
                // Sempre que o whyle retorna, a tela será limpanda, ou seja, apagando o número anterior.
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime++;
                // Será feito uma pausa de 1 segundo antes do próximo valor ser exibido na tela.
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("O Stopwatch foi finalizado!");
            Thread.Sleep(3000);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!");
            Thread.Sleep(2500);

            Start(time);
        }
    }
}

