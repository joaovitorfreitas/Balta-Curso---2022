using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace MultiTeste
{

    /// VALOR ADICIONAL
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new  Product(1, "Mouse gamer", 299, EProductType.Product);
            var manutencaoEletrica = new  Product(2, "Manuteção Eletrica", 200, EProductType.Service);


            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);            
            Console.WriteLine(mouse.Type);
        }
    }


    // Aulas Fundamentos de C# Armazenando Conteudo
    public class AulasFundamentos
    {
        public static void TiposVariaveis()
        {

            // NUMEROS INTEIROS 
            // Definido com " U " na frente não aceita negativo dobra a quantidade de caracteres aceito.

            // Short - ushort
            // int  - uint
            // long - ulong


            short short1 = 1;
            int int1 = 23434;
            long long1 = 232424242;


            //NUMEROS REAIS

            // Float
            // Double
            // Decimal

            float float1 = 1.2400f;
            double double1 = 12.2300;
            decimal decimal1 = 23.2300m;


            // BOLEANAS 

            bool usuarioCadastrado = false;
            bool pagamentorecebibo = true;
            var usuarioExpirado = false;

            // CHAR Unicode Aceita somente 1 caracter aspa simples :  ' '

            char primeiraletra = 'C';
            char segundaletra = 'D';

            // STRING armazena uma cadeia de caracter, ou seja uma lista de caracter

            string _primeiraletra = "C";
            string texto = "Meu texto";
            var documento = "123456.78";

            // VAR é dado atraves do primeiro tipo que é atribuido para ele. Ex : STRING,BOOL, INT etc...

            var idade = 21;



            // Object um tipo objeto, não possue intelisense nenhuma. pode ser qualquer coisa

            object _idade = 25;
            object nome = "joao";
            object vazio;

            // Void sem retorno nenhum, null retorna vazio, com interrogação na frente quando for non-nullabel

            int? __idade = null;
        }

        public static void Alias() 
        {
            // APELIDO para escrever alguma variavel.
            Int32 idade = 25; //tipo
            int _idade = 25; // Alias
        }

        public static void Conversao()
        {
            //conversão implicita

            float valor = 25.5f;
            int outro = 25;

            valor = outro;


            //conversão explicita

            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro;


            // Transcrever para um tipo
            //PARSE,Converter caracter ou string para um tipo qualquer
            // É uma extensão
            int inteiroo = int.Parse("100");

            //CONVERT Similar ao parse
            // porem permite converter varios tipo de valor não só string
            // Classe que faz conversão

            int inteirooo = Convert.ToInt32("100");
        }

        public static void ConvertendoTipos()
        {
            // Continuação da aula de Conversão

            int inteiro = 100;
            float real = 25.8f;

            // --------> Conversão implicita ||  real = inteiro; // 100.0f
            // executando conversão explicita inteiro = (int)real;
            // string valoreal = real.ToString();
            // inteiro = int.Parse(valoreal);

            inteiro = Convert.ToInt32(real);



            System.Console.WriteLine(inteiro);
            System.Console.WriteLine(Convert.ToBoolean(1));
        }


        public static void OperadoresAritmeticos()

        {
            int soma = 25 + 22;
            int subtracao = 22 - 22;
            int divisao = 25 * 25;
            int multiplicacao = 22 / 5;
        }


        public static void UsandoOperadoresAritmeticos()
        {
            double x = 2;
            x += 3;
            System.Console.WriteLine(x);
        }

        public static void EstruturaCondicionalIF()
        {

            int idade = 18;
            int maioridade = 21;
            //int idadeMaxima = 65;

            if(idade >= maioridade)
            {
                System.Console.WriteLine("É Diferente");
            }
            else if(idade > 25){ 

                System.Console.WriteLine("É Igual");
            }
            else if(idade > 32){ 

                System.Console.WriteLine("É Igual");
            }
            else{ 

                System.Console.WriteLine("É Igual");
            }
            System.Console.WriteLine("Finalizou o programa");
        }

        public static void EstruturaCondicionalSwitchCase()
        {
            string valor = "andre";
            switch(valor)
            {
                case "joao": System.Console.WriteLine("Não é o cara!"); break;
                case "marcelo": System.Console.WriteLine("Não é o cara!"); break;
                case "andre": System.Console.WriteLine("É este o cara!"); break;
                default: System.Console.WriteLine("Não Encontrei"); break;
            }

            bool? valor1 = true; //? significa nullType ou seja um numero pode ser nulo 
            switch(valor1)
            {
                case true: System.Console.WriteLine("Verdadeiro"); break;
                case false: System.Console.WriteLine("Falso"); break;
                default : System.Console.WriteLine("valor pode vir nulo"); break;
            }
        }

        public static void EstruturadeRepeticaoFOR()
        {            
                for(int i = 0; i <= 5; i++){
                    Console.WriteLine(i);
                }
        }


        public static void EstruturaDeRepeticaoWHILE() 
        {
            int valor = 0;

            while(valor <= 5){
                Console.WriteLine("oi");


                valor++;
            }
        } 

        public static void EstruturaDeRepeticaoDOWHILE()
        {
            var valor = 0;
            do
            {
                Console.WriteLine(valor);
                valor++;
            }
            while(valor <= 5);
        }

        public static void MetodosEFuncoes()
        {
            // Explicativa sobre metodos e funções

            //Criando Função void
            static void MeuMetodo(string parametro)
            {
                Console.WriteLine(parametro);
            }


            //No main

            string mensage = "Testando mensagem";

            MeuMetodo(mensage);

            // uma função que retorna uma string
            static string RetornaNome(string nome, string sobreNome)
            {   
                return nome + " " + sobreNome;
            }      

            RetornaNome("Gugu", "Gonsalves");
        }
    }

            // Usando para fornecer uma melhor visualização do código
            // Substituem o uso de inteiros
            // Usado em listas curtas
            // usado em dados fixos
             public enum EProductType
            {
                Product = 1,
                Service = 2
            }

        // Defino metodos ou propriedades
        // Só chama instanciando
        // Diferença de struct é um reference types
        // E Class é um value types
        public struct Product
        {

            public Product(int id, string name, double price, EProductType type)
            {
                Id = id;
                Name = name;
                Price = price;
                Type = type;
            }

            public int Id;
            public string Name;
            public double Price;
            public EProductType Type;

            public double PriceInDolar(double dolar)
            {
                return Price * dolar;
            }  
                    
        }

 


    // 
}