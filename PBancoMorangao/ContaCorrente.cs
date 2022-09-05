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
        public double SaldoCC { get; set; }

        public long LimiteContaCorrente { get; set; }

        public ContaCorrente()
        {

        }
        public ContaCorrente (long limiteChequeEspecial, long saldo, long limiteContaCorrente)
        {
            this.LimiteChequeEspecial = limiteChequeEspecial;
            this.SaldoCC = saldo;
            this.LimiteContaCorrente = limiteContaCorrente; 
        }

        public void ConsultarLimiteChequeEspecial()
        {
            //com base nos criterios de conta 
        }

        public void RealizarPagamentos()
        {

        }

        public void RealizarEmprestimos()
        {

        }

        public void ConsultarEmprestimo()
        {

        }

    }
}
