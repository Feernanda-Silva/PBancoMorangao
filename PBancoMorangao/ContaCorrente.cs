using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class ContaCorrente: Conta
    {
        public double LimiteChequeEspecial { get; set; }

        public ContaCorrente()
        {

        }

        public ContaCorrente(string tipoConta, long numeroConta, int senha, double saldo, double limiteChequeEspecial) : base (tipoConta, numeroConta, senha, saldo)
        {   

            this.LimiteChequeEspecial = limiteChequeEspecial;
            
            
        }

        public void ConsultarLimiteChequeEspecial()
        {
           Console.WriteLine("Limite cheque especial: "+this.LimiteChequeEspecial);
        }


        public override void Sacar()
        {
            Console.WriteLine("Sacar"); 
                base.Sacar();   
        }

    }
}
