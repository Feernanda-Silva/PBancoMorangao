using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Agencia
    {
        public int NumeroAgencia { get; set; }
        public Endereco endereco { get; set; }

        public Agencia()
        {

        }

        public void CadastrarAgencia()
        {   
            this.endereco = new Endereco();
            Console.WriteLine("Informe o numero da agência: ");
            this.NumeroAgencia = int.Parse(Console.ReadLine());
            endereco.CadastrarEndereco(); 

        }

        public void ImprimirAgencia()
        {
            Console.WriteLine("Numero Agencia: " + this.NumeroAgencia);
            endereco.ImprimirEndereco();
        }
    }
}
