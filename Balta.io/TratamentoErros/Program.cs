using System;

namespace TratamentoErros
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.dispararErros();
        }

        public static void errosException()
        {
            var oi = new int[3] { 2, 3, 4 };



            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(oi[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Passou do index");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Deu errado");
                Console.WriteLine(ex.Message);
            }


        }

        public static void dispararErros()
        {
            try
            {
                Salvar("");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("falha ao cadastrar arquivo");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops deu merda");
            }
            finally{
                Console.WriteLine("Chegou ao fim");
            }
        }

        public static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                //  throw new Exception("O texto não pode ser nulo ou vazio");  

                // Tipo especifico de erro
                throw new ArgumentException("O texto não pode ser nulo ou vazio");

            }
        }

        public static void metodoFinally()
        {
           //finally
           // Executa de qualquer jeito. verificar se tiver alguma conexão aberta (recomendado)
        }
    }
}
