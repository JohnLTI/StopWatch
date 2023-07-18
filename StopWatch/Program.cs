using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        static void start()
        {
            int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++; //INCREMENTO DA VARIÁVEL
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //FUNÇÃO QUE PAUSA A APLICAÇÃO NO TEMPO INFORMADO NO PARÂMETRO
            }
        }
    }
}
