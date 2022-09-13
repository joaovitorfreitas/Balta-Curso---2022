using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace editorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("---------------");
            Start();
        }

        public static void Start()
        {

            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-------------------------");


            Console.WriteLine(" Deseja salvar o arquivo ? (sim ou não)");

            string option = Console.ReadLine();


            while (option.ToLower() != "não" && option.ToLower() != "sim")
            {
                Console.WriteLine("salvar sim ou não?");
                option = Console.ReadLine();
            }

            if (option.ToLower() == "sim")
            {
                save(file.ToString());
                Menu.show();
            }
            else if (option.ToLower() == "não")
            {
                Menu.show();
            }
        }

        public static void save(string text)
        {
            var path = "C:\\" + "teste" + "\\tipo.txt";


            // utilizando using ele abre sem a necessidade de fechar algo.
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo: {path} com sucesso!");

            Console.ReadLine();

        }

    }
}
