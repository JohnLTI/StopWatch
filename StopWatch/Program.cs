using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            start(6);
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 Segundos");
            Console.WriteLine("M = Minuto => 1m = 1 Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // CONVERSÃO PARA STRING E COM FUNÇÃO TOLOWER QUE CONVERTE TUDO PARA MINÚSCULO
            char type = char.Parse(data.Substring(data.Length - 1, 1)); //DATA.LENGTH CONTA OS NÚMEROS DE CARACTERES QUE POSSUI O TEXTO INFORMADO

        }
        static void start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++; //INCREMENTO DA VARIÁVEL
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //FUNÇÃO QUE PAUSA A APLICAÇÃO NO TEMPO INFORMADO NO PARÂMETRO
            }
            Console.Clear();
            Console.WriteLine("StopWatch finalizado!");
            Thread.Sleep(2500);
        }
    }
}
