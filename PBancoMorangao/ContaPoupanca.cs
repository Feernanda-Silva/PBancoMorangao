using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class ContaPoupanca : Conta
    {

        public ContaPoupanca()
        {

        }

        public ContaPoupanca(string tipoConta, long numeroConta, int senha, double saldo) : base(tipoConta, numeroConta, senha,saldo)
        {

        }
    }
}
