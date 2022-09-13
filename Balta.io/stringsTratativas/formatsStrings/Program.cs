using System;
using System.Globalization;
using System.Text;

namespace formatsStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            TratativasString.strngBuilder();
        }

    }

    public class TratativasString
    {
        public static void TrainingGuids()
        {
            // Guid = Global unique identifier
            // espécie de id
            //pode ser passar uma string no guid em um formato valido ou gerar automaticamente

            var id = Guid.NewGuid();
            // não passado nenhum parametro inicia vazio.
            id = new Guid("0e573854-7b45-45f8-9ebd-24ff7e7dbd7c");
            Console.WriteLine(id);

            //pegar apenas os oitos primeiros caracteres
            Console.WriteLine(id.ToString().Substring(0, 8));
        }

        public static void InterpolacaoString()
        {

            var price = 10.2;

            // Concatenação de string
            var texto = "o preço do produto é " + price + " Apenas na promoção";

            //  Console.WriteLine(texto);

            // Outro jeito de interpolar
            // O valor que está entre chaves no string.Format é substituido pelo valor após a virgula

            var texto2 = string.Format("O preço do produto é {0} apenas na promoção {1}",
            price,
            true);

            //Console.WriteLine(texto2);

            // Interpolação
            // adicionando @ pode deixar quebra de linhas na string

            var texto3 = $@"o preço do 
produto é {price}";

            Console.WriteLine(texto3);
        }

        public static void ComparacaoTexto()
        {
            var texto = "Este texto é um teste";


            // compara a string retornando um int caso a string inteira seja igual
            //Console.WriteLine(texto.CompareTo("Testando"));

            //Retorna se string contem um pedaço do texto em boleano

            Console.WriteLine(texto.Contains("teste"));

            // Ignora sensitive case:  "StringComparison.OrdinalIgnoreCase", 
            Console.WriteLine(texto.Contains("teste", StringComparison.OrdinalIgnoreCase));
        }

        public static void ComecaComTerminaCom()
        {


            var texto = "Este texto é um teste";

            // verifica se o texto começa com tal palavra, caso começar retorna um true ou false

            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("texto"));

            // verifica se o texto termina com tal palavra, caso começar retorna um true ou false
            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.EndsWith("xpro"));
        }

        public static void Igual()
        {
            var texto = "Este texto é um teste";
            var teste = 33;



            //Compara o texto exatamente como é escrito retornando true ou false;
            Console.WriteLine(teste.Equals(33));
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        }

        public static void Indice()
        {
            var texto = "este texto é um teste";

            //Busca a posição do indice da primeira posição desta palavra caso conter na frase
            Console.WriteLine(texto.IndexOf("é"));

            //Busca a posição do indice da ultima posição desta palavra caso conter na frase
            Console.WriteLine(texto.LastIndexOf("s"));
        }

        public static void MaiusculoOuMinusculo()
        {
            var texto = "este texto é um teste";


            //Transforma em maiusculo
            Console.WriteLine(texto.ToUpper());

            //Transforma em minusculo
            Console.WriteLine(texto.ToLower());

            //Insere em uma posição especifica um caracter
            Console.WriteLine(texto.Insert(5, "AQUI "));

            //Remove um caracter desejado, passando a posição e a quantindade
            Console.WriteLine(texto.Remove(5, 5));

            // Quantidade de caracter que a string tem!    
            Console.WriteLine(texto.Length);
        }

        public static void ManipulandoString()
        {
            var texto = "Este texto é um teste";

            //Substitui um caracter por um novo declarado
            Console.WriteLine(texto.Replace("e", "X"));

            // split dividi o texto atraves da algum caracter transformando texto em uma lista
            var divisao = texto.Split(" ");

            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[3]);


            Console.WriteLine(divisao[4]);


            //Começa de uma posição especifica do texto
            var resultado = texto.Substring(5, 5);

            Console.WriteLine("resultado : " + resultado);

            // remove os espaços em brancos
            Console.WriteLine(texto.Trim());
        }

        public static void strngBuilder()
        {

            //string builder verifica linha a linha de forma dinamica, evitando problemas na memoria.

            var texto =  new StringBuilder();

            //criação new string builder, append ajuda a introduzir novos textos na variavel.
            //se torna um objeto do tipo string builder, converter para string
            texto.Append("Este texto é um teste");
            texto.Append("é um teste");
            texto.Append("Este text");
            texto.Append("Este um texte");
        }





    }

}
