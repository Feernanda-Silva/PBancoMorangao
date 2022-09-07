using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Funcionario : Pessoa
    {
        public String Cargo { get; set; }
        public Agencia agencia { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(String nome, DateTime dataNascimento, Endereco endereco, long telefone, long cpf, long rg, String cargo, int agencia) : base(nome, dataNascimento, telefone, cpf, rg)
        {
            this.Cargo = cargo;
        }

        public void CadastrarFuncionario()
        {
            base.CadastrarPessoa();
            agencia = new Agencia();
            Console.WriteLine("Cargo (Normal / Gerente): ");
            this.Cargo = Console.ReadLine();
            // escolher entre as agencias já cadastradas agencia.CadastrarAgencia();
        }

        public void ImprimirCadastroFuncionario()
        {
            base.ImprimirCadastro();
            Console.WriteLine("Cargo: " + this.Cargo);
            //agencia.ImprimirAgencia();
        }

        public  bool VerificarTipoFuncionario(Cliente cliente, string tipoConta)
        {
            if (this.Cargo == "Gerente")
            {
                return true;
            }

            else
            {
                Console.WriteLine("Você não pode autorizar essa conta");
                return false;
            }
        }

        public string AnalisarSolicitacaoAberturaConta(Cliente cliente)
        {
            if (cliente.SolicitarAberturaConta() == true)
            {
                if (cliente.Renda <= 500 && cliente.Estudante == "Sim")
                {
                    Console.WriteLine("Conta universitária");
                    return "Conta Universitária";
                }

                else if (cliente.Renda > 500 && cliente.Renda < 1000)
                {
                    Console.WriteLine("Conta Normal");
                    return "Conta Normal";
                }

                else if (cliente.Renda >= 1000)
                {
                    Console.WriteLine("Conta Vip");
                    return "Conta Vip";
                }

                else
                {
                    Console.WriteLine("Não há solicitações de conta");
                    return "Sem solicitação";
                }
            }
            return null;
        }


        public ContaCorrente AprovarAberturaContaCC(Cliente cliente, string tipoConta, long numeroConta, int senha, double saldo, double limiteChequeEspecial) // gerente 
        { 
            ContaCorrente contaCC = new ContaCorrente(tipoConta, numeroConta, senha, saldo, limiteChequeEspecial);
            return contaCC;
        }

        public ContaPoupanca AprovarAberturaContaP(Cliente cliente, string tipoConta, long numeroConta, int senha, double saldo) // gerente 
        {
            ContaPoupanca contaP = new ContaPoupanca(tipoConta, numeroConta, senha, saldo);
            return contaP;
        }
    }
}


