using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace editorHtml
{
    public static class Viewer
    {
        public static void show(string text)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Modo VISUALIZAÇÃO");
            Console.WriteLine("---------------");
            Replace(text);
            Console.WriteLine("---------------");
            Console.ReadKey();
            Menu.show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
                            )
                        )
                    );

                    Console.Write(" ");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }

        public static void View()
        {

            string path = "C:\\" + "teste" + "\\tipo.txt";

            using (var file = new StreamReader(path))
            {
                var PieceFile = file.ReadToEnd();

                Replace(PieceFile);
            }



        }

        public static void ShowView()
        {
            Console.Clear();

            Console.WriteLine("VISUALIZANDO TEXTO !");



            for (int i = 0; i <= 2; i++)
            {
                Thread.Sleep(1000);

                Console.Clear();
                string point = ".";

                Console.WriteLine(point);
                Thread.Sleep(600);

                point += ".";

                Console.Clear();
                Console.WriteLine(point);

                Thread.Sleep(600);
                point += ".";
                Console.Clear();

                Console.WriteLine(point);


            }

            Console.Clear();

            Thread.Sleep(500);


            Console.WriteLine("==========================");
            View();

            Console.ForegroundColor = ConsoleColor.Red;


            Console.ReadKey();




            Menu.show();
        }




    }
}