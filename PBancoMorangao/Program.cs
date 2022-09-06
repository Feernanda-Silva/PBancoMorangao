using System;

namespace PBancoMorangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cliente cliente = new Cliente();
            Funcionario funcionario = new Funcionario();
            Agencia agencia = new Agencia();
            ContaCorrente contaCC = new ContaCorrente(); 
            ContaPoupanca contaP = new ContaPoupanca();

            MenuInicial();

            void MenuInicial()
            {
                Console.Clear();
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("1-Cliente");
                Console.WriteLine("2-Funcionário");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    MenuCliente();
                }

                else
                {
                    MenuFuncionario();
                }

            }

            void MenuCliente()
            {
                int opcCliente;
                do
                {
                    Console.WriteLine("Menu cliente");
                    Console.WriteLine("Selecione a opção desejada:");
                    Console.WriteLine("0-Sair");
                    Console.WriteLine("1-Voltar ao Menu Inicial");
                    Console.WriteLine("2-Solicitar Abertura de conta");
                    Console.WriteLine("3-Efetuar login");

                    opcCliente = int.Parse(Console.ReadLine());

                    switch (opcCliente)
                    {
                        case 1:
                            MenuInicial();
                            break;
                        case 2:
                            Console.WriteLine("Solicitação enviada!");
                            cliente.SolicitarAberturaConta();
                            break;
                        case 3:
                           contaCC.EfetuarLogin(cliente);
                            Console.Clear();
                            Console.WriteLine("Escolha o tipo de conta: ");
                            Console.WriteLine("1-Conta Corrente");
                            Console.WriteLine("2-Conta Poupança");
                            int opc = int.Parse(Console.ReadLine());

                            if (opc == 1)
                            {
                                AcessoContaCorrente();
                            }

                            else
                            {
                                AcessoContaP();
                            }
                            break;
                    }
                } while (opcCliente != 0);
            }


            void MenuFuncionario()
            {
                
                int menuFuncionario;

                do
                {
                    string tipoConta = ""; 
                    Console.WriteLine("Menu funcionario");
                    Console.WriteLine("Selecione a opção desejada: ");
                    Console.WriteLine("0-Sair");
                    Console.WriteLine("1-Voltar ao menu inicial");
                    Console.WriteLine("2-Cadastrar Cliente");
                    Console.WriteLine("3-Imprimir Cadastro de Cliente");
                    Console.WriteLine("4-Cadastar Funcionário");
                    Console.WriteLine("5-Imprimir Cadastro de Funcionário");
                    Console.WriteLine("6-Analisar Solicitação de abertura de conta(Funcionario)");
                    Console.WriteLine("7-Aprovar Abertura de Conta(Gerente)");

                    menuFuncionario = int.Parse(Console.ReadLine());

                    switch (menuFuncionario)
                    {
                        case 1:
                            MenuInicial();
                            break;
                        case 2:
                            cliente.CadastrarPessoa();
                            cliente.CadastroCliente();
                            break;
                        case 3:
                            cliente.ImprimirCadastro();
                            break;
                        case 4:
                            funcionario.CadastrarPessoa();
                            funcionario.CadastrarFuncionario();
                            break;
                        case 5:
                            funcionario.ImprimirCadastro();
                            funcionario.ImprimirCadastroFuncionario();
                            break;
                        case 6:
                            tipoConta = funcionario.AnalisarSolicitacaoAberturaConta(cliente);
                            break;
                        case 7:
                            funcionario.VerificarTipoFuncionario(cliente, tipoConta, contaCC, contaP);
                            break;

                    }
                } while (menuFuncionario != 0);
            }

            void AcessoContaCorrente()
            {
                Console.Clear();
                int opcaoCC;

                do
                {
                 
                    Console.WriteLine("0-Sair");
                    Console.WriteLine("1-Voltar ao Menu Inicial");
                    Console.WriteLine("2-Consultar Saldo");
                    Console.WriteLine("3-Consultar Limite Cheque Especial"); 
                    Console.WriteLine("4-Sacar");
                    Console.WriteLine("5-Depositar");
                    Console.WriteLine("6-Transferir");
                    
                    opcaoCC = int.Parse(Console.ReadLine());


                    switch (opcaoCC)
                    {
                        case 1:
                            MenuInicial();
                            break;
                        case 2:
                            contaCC.ConsultarSaldo();
                            break;
                        case 3:
                            contaCC.ConsultarLimiteChequeEspecial();
                            break;
                        case 4:  
                            contaCC.Sacar();
                            break;
                        case 5:
                            contaCC.Depositar();
                            break;
                        case 6:
                            contaCC.Transferir();
                            break;

                    }

                } while (opcaoCC != 0);
            }

            void AcessoContaP()
            {
                Console.Clear();
                int opcaoP;
                do
                {
                    Console.WriteLine("0-Sair");
                    Console.WriteLine("1-Consultar Saldo");
                    Console.WriteLine("2-Sacar");
                    Console.WriteLine("3-Depositar");
                    Console.WriteLine("4-Transferir");
                    opcaoP = int.Parse(Console.ReadLine());

                    switch (opcaoP)
                    {
                        case 0:
                            break;
                        case 1:
                            contaP.ConsultarSaldo();
                            break;
                        case 2:
                            contaP.Sacar();
                            break;
                        case 3:
                            contaP.Depositar();
                            break;
                        case 4:
                            contaP.Transferir();
                            break;
                    }

                } while (opcaoP != 0);

            }
        }

    }
}




