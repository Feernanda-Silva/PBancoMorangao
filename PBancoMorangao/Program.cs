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
            Conta conta = new Conta();
            ContaCorrente contaCC = new ContaCorrente();
            ContaPoupanca contaP = new ContaPoupanca();

            MenuInicial();

            void MenuInicial()
            {
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("1-Cliente\n2-Funcionário");
                int opcao = int.Parse(Console.ReadLine());
                MenuOpcoes(opcao);
            }

            void MenuOpcoes(int opcao)
            {
                if (opcao == 1)
                {
                    Console.WriteLine("Menu cliente");
                    Console.WriteLine("Selecione a opção desejada:");
                    Console.WriteLine("1-Cadastrar Cliente\n2-Imprimir Cadastro do Cliente" +
                        "\n3-Solicitar abertura \n4-Verificar solicitação de abertura de conta" +
                        "\n5-Login");
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
                        case 5:
                            conta.EfetuarLogin(cliente);
                            AcessoConta();
                           
                            void AcessoConta ()
                            {
                                Console.WriteLine("Digite a conta que deseja: ");
                                Console.WriteLine("1-Conta Corrente");
                                Console.WriteLine("2-Conta Poupança");
                                int opcaoConta = int.Parse(Console.ReadLine());

                                if (opcaoConta == 1)
                                {
                                    int opcaoCC;

                                    do
                                    {
                                        Console.WriteLine("0-Sair");
                                        Console.WriteLine("1-Consultar Saldo");
                                        Console.WriteLine("2-Consultar Extrato");
                                        Console.WriteLine("3-Sacar");
                                        Console.WriteLine("4-Depositar");
                                        Console.WriteLine("5-Transferir");
                                        Console.WriteLine("6-Realizar Pagamentos");
                                        Console.WriteLine("7-Realizar Empréstimos");
                                        Console.WriteLine("8-Consultar Empréstimos");
                                        opcaoCC = int.Parse(Console.ReadLine());

                                        switch (opcaoCC)
                                        {
                                            case 1:
                                                contaCC.ConsultarSaldo();
                                                break;
                                            case 2:
                                                contaCC.ConsultarExtrato();
                                                break;
                                            case 3:
                                                contaCC.Sacar();
                                                break;
                                            case 4:
                                                contaCC.Depositar();
                                                break;
                                            case 5:
                                                contaCC.Transferir();
                                                break;
                                            case 6: //contaCC.RealizarPagamentos();
                                                break;
                                            case 7: //contaCC.RealizarEmprestimo();
                                                break;
                                            case 8: //contaCC.ConsultarEmprestimo(); 
                                                break;
                                        }

                                    } while (opcaoCC != 0);
                                }

                                else
                                {
                                    do
                                    {
                                        Console.WriteLine("0-Sair");
                                        Console.WriteLine("1-Consultar Saldo");
                                        Console.WriteLine("2-Consultar Extrato");
                                        Console.WriteLine("3-Sacar");
                                        Console.WriteLine("4-Depositar");
                                        Console.WriteLine("5-Transferir");
                                        int opcaoP = int.Parse(Console.ReadLine());

                                        switch (opcaoP)
                                        {
                                            case 1:
                                                contaP.ConsultarSaldo();
                                                break;
                                            case 2:
                                                contaP.ConsultarExtrato();
                                                break;
                                            case 3:
                                                contaP.Sacar();
                                                break;
                                            case 4:
                                                contaP.Depositar();
                                                break;
                                            case 5:
                                                contaP.Transferir();
                                                break;

                                        }

                                    } while (opcao != 0);

                                }
                            }
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Menu funcionario");
                    Console.WriteLine("Selecione a opção desejada: ");
                    Console.WriteLine("1-Cadastrar Funcionario\n2-Imprimir Cadastro do Funcionário\n3-Analisar solicitação de abertura de conta(Gerente)");
                    int menuFuncionario = int.Parse(Console.ReadLine());

                    switch (menuFuncionario)
                    {
                        case 1:
                            cliente.CadastrarPessoa();
                            funcionario.CadastrarFuncionario();
                            break;
                        case 2:
                            funcionario.ImprimirCadastro();
                            break;
                        case 3:
                            funcionario.VerificarTipoFuncionario();
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

