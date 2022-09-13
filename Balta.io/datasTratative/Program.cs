using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace datasTratative
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();


            Adicionais();
        }


        public static void obtendoValores()
        {

            //apenas cria um dateTime com um valor padrão
            // var data = new DateTime();

            // pega a data atual
            // var data = DateTime.Now;

            var data = new DateTime(2020, 11, 25, 8, 14, 23);
        }

        public static void FormatandoData()
        {

            var data = DateTime.Now;

            var formated = string.Format("{0:d/M/yyyy hh:mm:ss}", data);

            //yy = year  m = month, d = day
            Console.WriteLine(formated);
        }

        public static void PadroesFormatacao()
        {

            var data = DateTime.Now;


            //short time
            var formated = string.Format("{0:t}", data);

            //LONG TIME
            var formated1 = string.Format("{0:T}", data);

            //Menor data
            var formated2 = string.Format("{0:d}", data);

            //Maior data
            var formated3 = string.Format("{0:D}", data);

            // Tostring tbm funciona para formatar uma data.
            //  Console.WriteLine(DateTime.Now.ToString("d"));


            //g e f combinam data e hora
            //r e R padrão utilizado por mts sistemas
            //s muito utilizado json
            //u time zone mt utilizado

            Console.WriteLine(formated3);
        }

        public static void adicionadoValores()
        {
            var data = DateTime.Now;

            System.Console.WriteLine(data.AddDays(12));


            System.Console.WriteLine(data.AddMonths(1));

            data.AddYears(1);
            System.Console.WriteLine(data.AddYears(1));
        }

        public static void comparandoDatas()
        {
            var data = DateTime.Now;

            if (data.Date != DateTime.Now.Date)
            {
                Console.WriteLine("é igual");
            }
            else
            {
                System.Console.WriteLine("não");
            }
        }

        public static void culturoInfo()
        {
            Console.Clear();
            // tipo de data da cultura Traduz idioma
            var pt = new CultureInfo("pt-BR");

            Console.WriteLine(DateTime.Now.ToString("D", pt));

        }

        public static void TimezoneGlobalizacao()
        {

            var data = DateTime.UtcNow;

            Console.WriteLine(data);
            Console.WriteLine(data.ToLocalTime());


            var timeZoneToquio = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            Console.WriteLine(timeZoneToquio);

            var horaToquio = TimeZoneInfo.ConvertTimeFromUtc(data, timeZoneToquio);

            Console.WriteLine(horaToquio);

        }

        public static void TimeSpans()
        {

            // unidade de medida // hora // minutos // segundos // NANOSEGUNDOS
            var timespanNanoSegundos = new TimeSpan(1);


            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 12, 8);

            var timeSpanDiaHoraMinutoSegundoMilisegundo = new TimeSpan(3, 5, 12, 8, 5);


            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilisegundo);
        }

        public static void Adicionais()
        {

            // quantos dias tem no mês, ano e mes
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));

            var date = DateTime.Now;


            var today = date.DayOfWeek;

            // se é fim de semana ou não
            if(today == DayOfWeek.Saturday || today == DayOfWeek.Sunday){
                Console.WriteLine(true);
            }
            else{
                Console.WriteLine(false);
            }

            //Horario padrão return true false

            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());            
        }

        


    }

}
