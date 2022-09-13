using System;

namespace ClasseObjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            // objeto sempre tipo de referencia
            // -> Endereço dos dados

            // classes são moldes para criar esse objetos
            // struct são estruturas de dados armazenam valor em sí


            // acessando a classe base atraves da herança e instanciando ela
            var paymentBoleto = new paymentBoleto();
            paymentBoleto.Pagar();
            //paymentBoleto.NumeroBoleto = "123";


            var payment = new payment();

        }
    }


    // Encapsulamento
    // Reunir tudo um bloco especifico que faz sentido


    // private protected internal e public
    // MODIFICADORES DE ACESSO EM :
    // propriedade 
    // metodos 
    // classes

    // private apenas dentro da classe
    // protected  o mesmo vale pra classe só pros filhos da classe
    // internal dentro do proprio namespece
    // public para todo projeto


    // Payment é um tipo de dado complexo
    class payment
    {

        // Propriedados
        protected DateTime Vencimento;

        // Métodos
        // virtual permite o metodo ser sobre escrito quando utilizado a henraça na base
        public virtual void Pagar()
        {
            // ConsultarSaldoCartao("12341");
        }


        // Abstração para esconder as coisas / detalhes / não expor detalhes
        // Exemplo de abstração restringido apenas  na classe payment através de um modificador de acesso
        // private void ConsultarSaldoCartao(string cartao)
        // {

        // }

    }

    // através da henraça recebendo a classe acima conseguindo utilizar suas propriedas e metodos
    // tornando o payment a classe base
    class paymentBoleto : payment
    {
        private string NumeroBoleto;

        // Override permite a sobre escrita efetuada no filho
        public override void Pagar()
        {
            // Regra do boleto

        }

        void Test()
        {
            // acessando atraves da base, cujo a modificador de acesso seja protected
            // base.Vencimento;
        }
    }



    class paymentCartaoCredito : payment
    {
        public string Numero;

        // polimorfismo um metodo ou classe pode ter diversos tipos

        public override void Pagar()
        {
            // Regra do cartão de credito
        }
    }


    // Esse classe estou usando para estudar Propriedades
    class pagamento2
    {
        // construtor chamado sempre que a classe é instanciada
        public pagamento2(DateTime vencimento)
        {

        }

        //prop
        public DateTime Vencimento { get; set; }

        //get set acessores
        public DateTime DataPagamento { get; set; }


        // propfull



        private int _datapagamento;
        public int dataPagamento
        {
            get
            {
                Console.WriteLine("Lendo o valor");
                return _datapagamento;
            }
            set
            {
                Console.WriteLine("Atribuindo valor");
                _datapagamento = value;
            }
        }

        // sobreescrita e sobrecarga
        public virtual void pagar(string numero) { }

        //sobrecarga
        void pagar(string numero, DateTime vencimento) { }

    }

    class pagamentoCartao : pagamento2
    {

        // Através da herança da base recebemos o vencimento do contrutor principal
        public pagamentoCartao(DateTime vencimento) : base(vencimento)
        {

        }

        // sobreescrita de motodo
        public override void pagar(string numero)
        {

        }
    }

}
