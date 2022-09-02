﻿using System;
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

        public string Gerente { get; set; }


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
            agencia.CadastrarAgencia();
        }

        public void VerificarTipoFuncionario()
        {
            if (this.Cargo == "Normal")
            {
                Console.WriteLine("Você não pode autorizar essa conta");
            }

            else
            {
                AprovarAberturaConta();
            }

        }

        public void AprovarAberturaConta()
        {
            Console.WriteLine("O gerente autorizou sua conta");
        }

        Cliente cliente = new Cliente();
        public void VerificarEmprestimo(Cliente cliente) //funcionario verifica empréstimo
        {
            if (cliente.SolicitarEmpréstimo() == true)
            {
                //Critérios de empréstimo
            }
        }

       

        /*  public void AnalisarSolicitacaoAberturaConta(Cliente cliente)
          {
              int tipoConta = 1;
              if(cliente.Renda < 300 &&
              {

              }*/
    }
}


