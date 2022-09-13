using System;
using System.ComponentModel.Design;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0s = sair");

            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1 ,1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int mulitplier = 1;


            if(type == 'm')
                mulitplier = 60;

            if(time ==  0)
            System.Environment.Exit(0);

            preStart(time * mulitplier);
            
        }

        static void preStart(int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            start(time);


        }

        static void start(int time){

            int currentTime = 0;

            while(currentTime != time )
            {

                Console.Clear();

                currentTime ++;

                Console.WriteLine(currentTime);

                // Faz com que processador demore 1 segundo até ir para o próximo Numero Looping
                Thread.Sleep(1000);

            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }

    }
}
