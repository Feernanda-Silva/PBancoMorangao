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
            agencia = new Agencia();
            Console.WriteLine("Cargo (Normal / Gerente): ");
            this.Cargo = Console.ReadLine();
            // escolher entre as agencias já cadastradas agencia.CadastrarAgencia();
        }

        public void ImprimirCadastroFuncionario()
        {
            Console.WriteLine("Cargo: " + this.Cargo);
            //agencia.ImprimirAgencia();
        }

        public void VerificarTipoFuncionario(Cliente cliente, string tipoConta, ContaCorrente contaCC, ContaPoupanca contaP)
        {
            if (this.Cargo == "Gerente")
            {
                AprovarAberturaConta(cliente, tipoConta, contaCC, contaP);
               
            }

            else
            {

                Console.WriteLine("Você não pode autorizar essa conta");

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

                else if (cliente.Renda > 500 && cliente.Renda <1000)
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

        public void AprovarAberturaConta(Cliente cliente, string tipoConta, ContaCorrente contaCC, ContaPoupanca contaP) // gerente 
        {
            Console.WriteLine("Deseja aprovar abertura da conta? (Sim / Não: ");
            string abertura = Console.ReadLine();

            if (abertura =="Sim")
            {
                Console.WriteLine("Sua conta foi aprovada!"); 
                cliente.Status = "Aprovada";
                Console.WriteLine("Digite o numero da conta: ");
                long numeroConta = long.Parse(Console.ReadLine());
                Console.WriteLine("Digite a senha de 4 digitos: ");
                int senha = int.Parse(Console.ReadLine());
                double saldo = 0;
                Console.WriteLine("Digite o limite do cheque especial: ");
                double limiteChequeEspecial = double.Parse(Console.ReadLine()); 
                contaCC.NumeroConta = numeroConta;  
                contaCC.Saldo = saldo;  
                contaCC.LimiteChequeEspecial = limiteChequeEspecial;    
                contaCC.TipoConta = tipoConta;
                contaP.NumeroConta = numeroConta;
                contaP.Saldo = saldo;
                contaP.Senha = senha; 
             
            }

            else
            {
                Console.WriteLine("Sua conta não foi aprovada");
              
            }
            
        } 

    }
}


