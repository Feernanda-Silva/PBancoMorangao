using System;
using System.Collections.Generic;

namespace PBancoMorangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Funcionario> funcionarios = new List<Funcionario>();
            List<Agencia> agencias = new List<Agencia>();
            List<ContaCorrente> contasCC = new List<ContaCorrente>();
            List<ContaPoupanca> contasP = new List<ContaPoupanca>();

            MenuInicial();

            void MenuInicial()
            {
                Console.Clear();
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("1-Cliente");
                Console.WriteLine("2-Funcionário");
                Console.WriteLine("3- Agencia");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    MenuCliente();
                }

                else if (opcao == 2)
                {
                    MenuFuncionario();
                }

                else
                {
                    MenuAgencia();
                }

            }

            Funcionario EncontrarFuncionario()
            {
                Console.WriteLine("Digite o cpf do funcionario: ");
                long cpf = long.Parse(Console.ReadLine());
                Funcionario encontrouFuncionario = funcionarios.Find(funcionario => funcionario.Cpf == cpf);
                return encontrouFuncionario;
            }

            Cliente EncontrarCliente()
            {
                Console.WriteLine("Digite o cpf do cliente: ");
                long cpf = long.Parse(Console.ReadLine());
                Cliente encontrouCliente = clientes.Find(cliente => cliente.Cpf == cpf);
                return encontrouCliente;
            }
            void MenuAgencia()
            {
                int opcAgencia;
                do
                {

                    Console.WriteLine("Menu Agencia");
                    Console.WriteLine("Selecione a opcao desejada: ");
                    Console.WriteLine("0-Sair");
                    Console.WriteLine("1-Voltar ao Menu Inicial");
                    Console.WriteLine("2-Cadastrar Agência");
                    Console.WriteLine("3-Consultar Agência");
                    opcAgencia = int.Parse(Console.ReadLine());
                    switch (opcAgencia)
                    {
                        case 0:
                            break;
                        case 1:
                            MenuInicial();
                            break;
                        case 2:
                            Agencia agencia = new Agencia();
                            agencia.CadastrarAgencia();
                            agencias.Add(agencia);
                            break;
                        case 3:
                            foreach (Agencia consultarAgencia in agencias)
                            {
                                consultarAgencia.ImprimirAgencia();
                            }
                            break;

                    }
                } while (opcAgencia != 0);

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
                            Cliente encontrouCliente = EncontrarCliente();

                            if (encontrouCliente == null)
                            {
                                Console.WriteLine("Cliente não cadastrado");
                            }

                            else
                            {
                                encontrouCliente.SolicitarAberturaConta();
                                Console.WriteLine("Solicitação enviada!");
                            }


                            break;
                        case 3:
                            Console.WriteLine("Digite o numero da conta: ");
                            long numeroConta = long.Parse(Console.ReadLine());
                            ContaCorrente encontrouConta = contasCC.Find(contasCC => contasCC.NumeroConta == numeroConta);
                            ContaPoupanca encontrouContaP = contasP.Find(contasP => contasP.NumeroConta == numeroConta);
                            if (encontrouConta == null)
                            {
                                Console.WriteLine("Não possui conta");
                            }
                            else
                            {
                                encontrouConta.EfetuarLogin();
                            }

                            Console.Clear();
                            Console.WriteLine("Escolha o tipo de conta: ");
                            Console.WriteLine("1-Conta Corrente");
                            Console.WriteLine("2-Conta Poupança");
                            int opc = int.Parse(Console.ReadLine());

                            if (opc == 1)
                            {
                                AcessoContaCorrente(encontrouConta);
                            }

                            else
                            {
                                AcessoContaP(encontrouContaP);
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
                            Cliente cliente = new Cliente();
                            cliente.CadastrarCliente();
                            clientes.Add(cliente);
                            break;
                        case 3:
                            Cliente encontrouCliente = EncontrarCliente();

                            if (encontrouCliente == null)
                            {
                                Console.WriteLine("Cliente não encontrado");
                            }

                            else
                            {
                                encontrouCliente.ImprimirCadastroCliente();
                            }

                            break;
                        case 4:
                            Funcionario funcionario = new Funcionario();
                            foreach (Agencia consultarAgencia in agencias)
                            {
                                consultarAgencia.ImprimirAgencia();
                            }
                            Console.WriteLine("Digite o numero da agencia: ");
                            int numeroagencia = int.Parse(Console.ReadLine());
                            Agencia encontrouAgencia = agencias.Find(agencia => agencia.NumeroAgencia == numeroagencia);
                            funcionario.CadastrarFuncionario(encontrouAgencia);
                            funcionarios.Add(funcionario);
                            break;
                        case 5:

                            Funcionario encontrouFuncionario = EncontrarFuncionario();

                            if (encontrouFuncionario == null)
                            {
                                Console.WriteLine("Cliente não encontrado");
                            }

                            else
                            {
                                encontrouFuncionario.ImprimirCadastroFuncionario();
                            }

                            break;
                        case 6:
                            Funcionario encontrouFuncionario2 = EncontrarFuncionario();
                            Cliente encontrarCliente = EncontrarCliente();
                            tipoConta = encontrouFuncionario2.AnalisarSolicitacaoAberturaConta(encontrarCliente);

                            break;
                        case 7:
                            Funcionario encontrouFuncionario3 = EncontrarFuncionario();
                            Cliente encontrarCliente2 = EncontrarCliente();
                            bool tipoFuncionario = encontrouFuncionario3.VerificarTipoFuncionario(encontrarCliente2, tipoConta);
                            if (tipoFuncionario == true)
                            {
                                Console.WriteLine("Sua conta foi aprovada!");
                                encontrarCliente2.Status = "Aprovada";
                                Console.WriteLine("Digite o numero da conta: ");
                                long numeroConta = long.Parse(Console.ReadLine());
                                Console.WriteLine("Digite a senha de 4 digitos: ");
                                int senha = int.Parse(Console.ReadLine());
                                double saldo = 0;
                                Console.WriteLine("Digite o limite do cheque especial: ");
                                double limiteChequeEspecial = double.Parse(Console.ReadLine());

                                ContaCorrente novaContacc = encontrouFuncionario3.AprovarAberturaContaCC(encontrarCliente2, tipoConta, numeroConta, senha, saldo, limiteChequeEspecial);
                                contasCC.Add(novaContacc);
                                ContaPoupanca novaContaP = encontrouFuncionario3.AprovarAberturaContaP(encontrarCliente2, tipoConta, numeroConta, senha, saldo);
                                contasP.Add(novaContaP);
                            }
                            break;
                    }

                } while (menuFuncionario != 0);
            }

            void AcessoContaCorrente(ContaCorrente contaCC)
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

            void AcessoContaP(ContaPoupanca contaP)
            {
                Console.Clear();
                int opcaoP;

                do
                {
                    Console.WriteLine("0-Sair");
                    Console.WriteLine("1- Voltar ao Menu Inicial");
                    Console.WriteLine("2-Consultar Saldo");
                    Console.WriteLine("3-Sacar");
                    Console.WriteLine("4-Depositar");
                    Console.WriteLine("5-Transferir");
                    opcaoP = int.Parse(Console.ReadLine());

                    switch (opcaoP)
                    {
                        case 0:
                            break;
                        case 1:
                            MenuInicial();
                            break;
                        case 2:
                            contaP.ConsultarSaldo();
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

                } while (opcaoP != 0);
            }
        }
    }
}




