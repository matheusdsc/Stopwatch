using System;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm') multiplier = 60;

            if (time == 0) System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.WriteLine("C = Ordem crescente");
            Console.WriteLine("D = Ordem Decrescente");
            string data = Console.ReadLine().ToLower();
            if (data != "c" || data != "d")
            {
                Console.WriteLine("Digite um número válido!");
                PreStart(time);
            }
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!!!");
            Thread.Sleep(2000);
            if (data == "c") Crescente(time);
            else if (data == "d") Decrescente(time);


        }

        static void Crescente(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...");
            Thread.Sleep(2000);
            Menu();
        }

        static void Decrescente(int time)
        {
            int currentTime = time;

            while (currentTime != 0)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime--;
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...");
            Thread.Sleep(2000);
            Menu();
        }

    }
}