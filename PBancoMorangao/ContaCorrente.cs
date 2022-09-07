using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class ContaCorrente : Conta
    {
        public double LimiteChequeEspecial { get; set; }

        public ContaCorrente()
        {

        }

        public ContaCorrente(string tipoConta, long numeroConta, int senha, double saldo, double limiteChequeEspecial) : base(tipoConta, numeroConta, senha, saldo)
        {
            this.LimiteChequeEspecial = limiteChequeEspecial;

        }

        public void ConsultarLimiteChequeEspecial()
        {
            Console.WriteLine("Limite cheque especial: " + this.LimiteChequeEspecial);
        }

        public override void Sacar()
        {
            double limite;
            Console.WriteLine("Digite o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());

            if (saque > this.Saldo && this.LimiteChequeEspecial >= saque)
            {
                Console.WriteLine("Deseja usar o limite do cheque especial? Sim ou Não ");
                string resp = Console.ReadLine();

                if (resp == "Sim")
                {
                    limite = this.Saldo + this.LimiteChequeEspecial;
                    double saldoAtual = limite - saque;
                    Console.WriteLine("Saque efetuado com sucesso!");
                    Console.WriteLine("Seu novo saldo é: " + saldoAtual);
                }

                else
                {
                    Console.WriteLine("Operação cancelada");
                }
            }

            else if (saque <= this.Saldo)
            {
                this.Saldo = this.Saldo - saque;
                Console.WriteLine("Saque efetuado com sucesso!");
                Console.WriteLine("Seu novo saldo é: " + this.Saldo);

            }

            else
            {
                Console.WriteLine("Saldo insuficiente");
            }

        }

        public override void Transferir()
        {
            double limite;
            Console.WriteLine("Digite o valor da transferencia: ");
            double transferencia = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero da conta a ser realizada a transferência: ");
            long numeroConta = long.Parse(Console.ReadLine());

            if (transferencia > this.Saldo && this.LimiteChequeEspecial >= transferencia)
            {
                Console.WriteLine("Deseja usar o limite do cheque especial? 1-Sim / 2-Não ");
                int resp = int.Parse(Console.ReadLine());

                if (resp == 1)
                {
                    limite = this.Saldo + this.LimiteChequeEspecial;
                    double saldoAtual = limite - transferencia;
                    Console.WriteLine("Saque efetuado com sucesso!");
                    Console.WriteLine("Seu novo saldo é: " + saldoAtual);
                }

                else
                {
                    Console.WriteLine("Operação cancelada");
                }
            }

            else if (transferencia <= this.Saldo)
            {
                this.Saldo = this.Saldo - transferencia;
                Console.WriteLine("Saque efetuado com sucesso!");
                Console.WriteLine("Seu novo saldo é: " + this.Saldo);

            }

            else
            {
                Console.WriteLine("Saldo insuficiente");
            }

        }
    }
}
