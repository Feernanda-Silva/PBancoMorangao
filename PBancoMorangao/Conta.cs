using System;

namespace PBancoMorangao
{
    internal class Conta
    {
        public string TipoConta { get; set; }
        public long NumeroConta { get; set; }
        public int Senha { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {

        }

        public Conta(string tipoConta, long numeroConta, int senha, double saldo)
        {
            this.TipoConta = tipoConta;
            this.NumeroConta = numeroConta;
            this.Senha = senha;
            this.Saldo = saldo;
        }

        public void EfetuarLogin()
        {
            Console.WriteLine("Digite o numero da conta: ");
            this.NumeroConta = long.Parse(Console.ReadLine());
            Console.Write("Digite a senha: ");
            this.Senha = int.Parse(Console.ReadLine());
            //agencia 
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo: " + this.Saldo);
        }

        public virtual void Sacar()
        {
            Console.WriteLine("Digite o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());

            if (saque <= this.Saldo)
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

        public virtual void Transferir()
        {
            Console.WriteLine("Valor a ser transferido: ");
            double transferencia = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero da conta a ser realizada a transferência: ");
            long numeroConta = long.Parse(Console.ReadLine());

            if (this.Saldo >= transferencia)
            {
                this.Saldo = this.Saldo - transferencia;
                Console.WriteLine("Transferência efetuada com sucesso!");
                Console.WriteLine("Seu novo saldo é: " + this.Saldo);
            }

            else
            {
                Console.WriteLine("Você não possui saldo suficiente!");
            }
        }
    }
}
