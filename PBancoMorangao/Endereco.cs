using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Endereco
    {
        String Rua { get; set; }
        int Numero { get; set; }
        String Bairro { get; set; }
        String Cidade { get; set; }
        String Estado { get; set; }

        public Endereco()
        {

        }

        public Endereco(String rua, int numero, String bairro, String cidade, String estado)
        {
            this.Rua = rua;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
        }

        public void CadastrarEndereco()
        {
            Console.WriteLine("Rua: ");
            this.Rua = Console.ReadLine();
            Console.WriteLine("Numero: ");
            this.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Bairro: ");
            this.Bairro = Console.ReadLine();
            Console.WriteLine("Cidade: ");
            this.Cidade = Console.ReadLine();
            Console.WriteLine("Estado: ");
            this.Estado = Console.ReadLine();
        }

        public void ImprimirEndereco()
        {
            Console.WriteLine("Rua: " + this.Rua);
            Console.WriteLine("Numero: " + this.Numero);
            Console.WriteLine("Bairro: " + this.Bairro);
            Console.WriteLine("Cidade: " + this.Cidade);
            Console.WriteLine("Estado: " + this.Estado);
        }
    }
}
