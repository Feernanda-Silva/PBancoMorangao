using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Pessoa
    {

        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco endereco { get; set; }
        public long Telefone { get; set; }
        public long Cpf { get; set; }
        public long Rg { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(String nome, DateTime dataNascimento, long telefone, long cpf, long rg)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.endereco = new Endereco();
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Rg = rg;

        }

        public void CadastrarPessoa()
        {
            this.endereco = new Endereco();

            Console.WriteLine("Nome: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Data de nascimento");
            this.DataNascimento = DateTime.Parse(Console.ReadLine());
            endereco.CadastrarEndereco();
            Console.WriteLine("Telefone: ");
            this.Telefone = long.Parse(Console.ReadLine());
            Console.WriteLine("CPF: ");
            this.Cpf = long.Parse(Console.ReadLine());
            Console.WriteLine("Rg: ");
            this.Rg = long.Parse(Console.ReadLine());
        }

        public void ImprimirCadastro()
        {
           
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Data de nascimento: " + this.DataNascimento);
            endereco.ImprimirEndereco();
            Console.WriteLine("Telefone: " + this.Telefone);
            Console.WriteLine("CPF: " + this.Cpf);
            Console.WriteLine("Rg: " + this.Rg);
        }
    }
}

