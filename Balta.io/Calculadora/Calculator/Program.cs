using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Soma ()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor armazenado : " +   v1);
            Console.WriteLine("Primeiro valor armazenado : " +  v2);


            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine("A soma dos dois são: " +  resultado);
            Console.ReadKey();
            Menu();

        }


        static void Subtracao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor armazenado : " +   v1);
            Console.WriteLine("Primeiro valor armazenado : " +  v2);


            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine("A subtração dos dois é: " +  resultado);
            Console.ReadKey();
            Menu();
        }


        static void divisao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");

            float v1  = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());


            Console.WriteLine("Primeiro valor armaazenado : " + v1);
            Console.WriteLine("Segundo valor armazenado é : " + v2);

            Console.WriteLine("");

            float resultadoDivisao = v1 / v2;

            Console.WriteLine("Resultado da divisão é : " + resultadoDivisao);
            Console.ReadKey();
            Menu();

        }

        static void multiplicacao(){
            Console.Clear();
        
            Console.WriteLine("Primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor : ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultadoMultiplacao = v1 * v2;

            Console.WriteLine("Resultado multiplicação é : " + resultadoMultiplacao);
            Console.ReadKey();
            Menu();
        }
        
        static void Menu(){
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            

            Console.WriteLine("--------------------");
            

            Console.WriteLine("Selecione uma opção");

            short res = short.Parse(Console.ReadLine());

            switch (res){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: divisao(); break;
                case 4: multiplicacao(); break;
                //System.Environment.Exit(0) -- sai da aplicação
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
    }
}
 