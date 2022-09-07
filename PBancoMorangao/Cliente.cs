using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Cliente : Pessoa
    {
        public double Renda { get; set; }
        public String Estudante { get; set; }
        public String Status { get; set; } = "Não aprovado";

        public Cliente()
        {

        }

        public Cliente(String nome, DateTime dataNascimento, long telefone, long cpf, long rg, double renda, String estudante) : base(nome, dataNascimento, telefone, cpf, rg)
        {
            this.Renda = renda;
            this.Estudante = estudante;
        }

        public void CadastrarCliente()
        {
            base.CadastrarPessoa();
            Console.WriteLine("Digite sua renda: ");
            this.Renda = double.Parse(Console.ReadLine());
            Console.WriteLine("Você é estudante? (Responda: Sim ou Não) : ");
            this.Estudante = Console.ReadLine();

        }

        public void ImprimirCadastroCliente()
        {
            base.ImprimirCadastro(); 
            Console.WriteLine("Renda: " + this.Renda);
            Console.WriteLine("Estudante: " + this.Estudante); 
        }

        public bool SolicitarAberturaConta()
        {
            return true;
        }
    }
}


