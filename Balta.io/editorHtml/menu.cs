using System;

namespace editorHtml
{
    public static class Menu
    {

        public static void show()
        {
            Console.Clear();

            //  Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;

            DrawnScreen(30, 10);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);


        }

        private static void DrawnLine(int valueLine, string item)
        {
            Console.Write(item);

            for (int i = 0; i <= valueLine; i++)
            {

                if (string.IsNullOrWhiteSpace(item))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-");
                }

            }
            Console.Write(item);
        }

        private static void DrawnColum(int columnLine, int Line)
        {
            Console.Write("\n");

            for (int lines = 0; lines <= columnLine; lines++)
            {
                Console.Write("|");

                DrawnLine(Line - 2, " ");

                Console.Write("|");

                Console.Write("\n");
            }
        }

        private static void DrawnScreen(int NumberLine, int NumberColumn)
        {

            DrawnLine(NumberLine, "+");


            DrawnColum(NumberColumn, NumberLine);

            DrawnLine(NumberLine, "+");
        }


        public static void WriteOptions()
        {

            // Posição especifica do cursor a ser inserida Informação
            Console.SetCursorPosition(3, 2);

            Console.WriteLine("Editor html");

            Console.SetCursorPosition(3, 3);

            Console.WriteLine("===========================");

            Console.SetCursorPosition(3, 4);

            Console.WriteLine("Selecione uma opção abaixo");

            Console.SetCursorPosition(3, 6);

            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(3, 8);

            Console.WriteLine("2 - Abrir");

            Console.SetCursorPosition(3, 10);

            Console.WriteLine("0 - Sair");


            Console.SetCursorPosition(3, 13);
        }


        public static void HandleMenuOption(short option){
            switch(option) {
                case 1: Editor.Show(); break;
                case 2: Viewer.ShowView(); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                } break;
                default: show(); break;
            }
        }
    }
}