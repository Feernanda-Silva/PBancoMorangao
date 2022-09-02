﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Cliente : Pessoa
    {
        public double Renda { get; set; }
        public String Perfil { get; set; }
        public String Estudante { get; set; }

        public Cliente()
        {

        }

        public Cliente(String nome, DateTime dataNascimento, long telefone, long cpf, long rg, double renda, String perfil, String estudante) : base(nome, dataNascimento, telefone, cpf, rg)
        {
            this.Renda = renda;
            this.Perfil = perfil;
            this.Estudante = estudante; 
        }

      
        
        public bool SolicitarAberturaConta()
        {

            Console.WriteLine("Deseja solicitar abertura de conta (Digite Sim ou Não) ?");
            string abertura = Console.ReadLine();

            if (abertura == "Sim")
            {
                Console.WriteLine("Digite sua renda: ");
                this.Renda = double.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o perfil desejado (Universitário/ Normal/ Vip): ");
                this.Perfil = Console.ReadLine();
                Console.WriteLine("Você é estudante? (Responda: Sim ou Não) : ");
                this.Estudante = Console.ReadLine();    
                Console.WriteLine("Solicitação enviada");
                return true;
            }

            else
            {
                Console.WriteLine("Solicitação cancelada");
                return false;
            }
        }

        public bool SolicitarEmpréstimo()
        {
            Console.WriteLine("Solicitação de empréstimo enviada");
            return true;
        }

        public bool SolicitarDesbloquearCartão()
        {
            Console.WriteLine("Cartão Desbloqueado");
            return true;
        }

    }
}

