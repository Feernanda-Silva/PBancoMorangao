using System;

namespace PBancoMorangao
{
    internal class Conta
    {
        public int TipoConta { get; set; }
        public long NumeroConta { get; set; }
        public long Senha { get; set; }
        public long CartaoCredito { get; set; }

        public double Saldo { get; set; }


        public Conta()
        {

        }

        public void ConsultarSaldo()
        {


        }

        public void ConsultarExtrato()
        {
            //lista dos saques, depositos, transferencias
        }

        public void Sacar()
        {

            Console.WriteLine("Digite o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());


            if (saque >= this.Saldo)
            {
                this.Saldo = this.Saldo - saque;
                Console.WriteLine("Saque efetuado com sucesso!");
                Console.WriteLine("Seu novo saldo é: " + this.Saldo);
            }

            else
            {
                Console.WriteLine("Você não possui saldo suficiente!");
            }

        }

        public void Depositar()
        {
            Console.WriteLine("Digite o valor do deposito: ");
            double deposito = double.Parse(Console.ReadLine()); 
            this.Saldo = this.Saldo + deposito;
            Console.WriteLine("Deposito efetuado com sucesso!");
            Console.WriteLine("Seu novo saldo é: " + this.Saldo);

        }






    }
}
