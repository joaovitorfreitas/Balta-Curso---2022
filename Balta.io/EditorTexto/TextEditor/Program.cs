using System;
using System.Diagnostics;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("O que você deseja fazer ? ");
            Console.WriteLine("1 - abrir arquivo");
            Console.WriteLine("2 - criar arquivo");
            Console.WriteLine("0 - sair");

            short option = short.Parse(Console.ReadLine());

            switch(option){
                case 0 : System.Environment.Exit(0); break;
                case 1 :  Abrir(); break;
                case 2 :  Editar(); break;
                default:  Menu(); break;
            }
        }

        static void Abrir(){
            Console.Clear();

            Console.WriteLine("Qual caminho do arquivo?");

            var path = Console.ReadLine();

            using(var file = new StreamReader(path)){
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();

            Menu();


        }

        static void Editar(){
            Console.Clear();
            
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-------------------");

            string text = "";

            // Console ReadKey Verifica se usuario pressionou  tecla
            do{
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(text);

            Console.WriteLine("saiuuu");

            Salvar(text);
        }

        static void Salvar(string text){
            Console.Clear();

            Console.WriteLine("Qual caminho para Pasta o caminho?");
            var Folder = Console.ReadLine();

            var path = "C:\\" + Folder + "\\tipo.txt";
    

            // utilizando using ele abre sem a necessidade de fechar algo.
            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo: {path} com sucesso!");
            
            Console.ReadLine();

            Menu();

        }
    }
}
