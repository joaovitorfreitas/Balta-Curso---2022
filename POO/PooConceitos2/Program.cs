using System;

namespace PooConceitos2
{
    class Program
    {
        static void Main(string[] args)
        {
            // using abre e fecha automaticamente alguma conexão ou objeto
            using (var pagamento = new pagamento())
            {
                Console.WriteLine("Processando pagamento");
            }



            // classe filha tbm pode ser uma classe pai
            // upcasting 
            var Pessoa = new Pessoa();

            Pessoa = new PessoaFisica();
            Pessoa = new PessoaJuridica();

            // Downcasting
            var PessoaFisica = new PessoaFisica();
            PessoaFisica = (PessoaFisica)Pessoa;


            //Comparando objetos ;
            var PessoaA = new Pessoa("A");
            var PessoaB = new Pessoa("A");

            // Fazendo a comparação através do Equals
            Console.WriteLine(PessoaA.Equals(PessoaB));





        }
    }

    public class pagamento : IDisposable
    {
        // IDisposable item para destruir um objeto aberto
        // interface passada como herança
        public pagamento()
        {
            Console.WriteLine("Iniciando o pagamento");
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizando o pagamento");
        }

    }

    // selaed impossibilita herança
    public sealed class pagamneto2
    {

    }

    // Interface é um contrato que vai definir como deve ser seguido uma regra
    public interface IPaymente
    {
        DateTime Vencimento { get; set; }

        void Pagar(double valor);

    }


    // classe recebe uma interface e trabalha em cima disso.
    public class Paymente : IPaymente
    {
        public DateTime Vencimento { get; set; }

        public virtual void Pagar(double valor)
        {
            throw new NotImplementedException();
        }
    }

    // abstract impossibilita a classe ser instanciado
    public abstract class PaymenteCartao : Paymente
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public class PaymenteBoleto : Paymente
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public class PaymenteApple : Paymente
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    // Implementa interface de comparação
    public class Pessoa : IEquatable<Pessoa>
    {
        public string Nome { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        // implementando pela interface Equals que faz a comparação
        public bool Equals(Pessoa other)
        {
           return Nome == other.Nome;
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }

    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }

    }
}
