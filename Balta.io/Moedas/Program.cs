using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            ArredondarValor();
        }


        public static void Moeda()
        {

            //decimal valor = 10.2m;
            //Console.WriteLine(valor);


            //Qual melhor tipo pra usar moeda ?
            // Utilizado mt o decimal por causa precisão
        }

        public static void Formatando()
        {
            decimal valor = 10.2m;
            //G generico numerico padrão
            //C padrão moeda
            //E04 Formatos grandes
            //F Precisão maior
            //N Tranforma tbm, porem sem o cifrão
            //P Porcetagem
            var valueFormated = valor.ToString("C",
            CultureInfo.CreateSpecificCulture("pt-BR"));
            Console.WriteLine(valueFormated);



        }

        public static void ArredondarValor()
        {
            decimal valor = 103443.32m;

            // Arrendonda o valor
            Console.WriteLine(Math.Round(valor));

            // Arredonda um valor maior
            Math.Ceiling(valor);

            // Arredonda um valor menor
            Math.Floor(valor);
        }
    }
}
