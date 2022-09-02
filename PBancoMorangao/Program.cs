using System;

namespace PBancoMorangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Cliente cliente = new Cliente();
            Funcionario funcionario = new Funcionario();
            Agencia agencia = new Agencia();
            ContaCorrente contaCC = new ContaCorrente();
            ContaPoupanca contaP = new ContaPoupanca();

            MenuInicial();

            void MenuInicial()
            {
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("1-Cliente\n 2-Funcionário");
                int opcao = int.Parse(Console.ReadLine());
                MenuOpcoes(opcao);
            }

            void MenuOpcoes(int opcao)
            {
                if (opcao == 1)
                {
                    Console.WriteLine("Menu cliente");
                    Console.WriteLine("Selecione a opção desejada: ");
                    Console.WriteLine("1-Cadastrar Cliente\n2-Imprimir Cadastro do Cliente\n3-Solicitar abertura \n4-Verificar solicitação de abertura de conta");
                    int menuCliente = int.Parse(Console.ReadLine());

                    switch (menuCliente)
                    {
                        case 1:
                            cliente.CadastrarPessoa();
                            break;
                        case 2:
                            cliente.ImprimirCadastro();
                            break;
                        case 3:
                            cliente.SolicitarAberturaConta();
                            break;
                        case 4:
                            // funcionario.VerificarTipoConta(cliente);
                            break;

                    }
                }

                else
                {
                    Console.WriteLine("Menu funcionario");
                    Console.WriteLine("Selecione a opção desejada: ");
                    Console.WriteLine("1-Cadastrar Funcionario\n2-Imprimir Cadastro do Funcionário\n3-Analisar solicitação de abertura de conta");
                    int menuFuncionario = int.Parse(Console.ReadLine());

                    switch (menuFuncionario)
                    {
                        case 1:
                            cliente.CadastrarPessoa();
                            funcionario.CadastrarFuncionario();
                            break;
                        case 2:
                            cliente.ImprimirCadastro();
                            break;
                        case 3:
                            
                            break;
                        case 4:
                            // funcionario.VerificarTipoConta(cliente);
                            break;

                    }
                }
            }
        }
    }
}
