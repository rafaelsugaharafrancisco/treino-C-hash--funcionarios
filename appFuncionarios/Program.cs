using System;

using appFuncionarios.Classes;
using appFuncionarios.Enum;

namespace appFuncionarios
{
    class Program
    {
        static int id = 0;
        static FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
        static void Main(string[] args)
        {
            string opcaoEscolhida = "";

            do
            {
                Console.WriteLine("\n== MENU ==");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Remover");
                Console.WriteLine("4 - Alterar");
                Console.WriteLine("X - Sair");
                Console.WriteLine("Digite a opção desejada:");
                opcaoEscolhida = Console.ReadLine();

                switch (opcaoEscolhida.ToUpper())
                {
                    case "1":
                        Formulario form = Formulario("CADASTRO");
                        Cadastrar(form);
                        id++;
                        break;
                    case "2":
                        Listar();
                        break;
                    case "3":
                        Remover();
                        break;
                    case "4":
                        Alterar();
                        break;
                    case "X": break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcaoEscolhida.ToUpper() != "X");
        }

        private static void Cadastrar(Formulario form)
        {
            Funcionario funcionario = new Funcionario(id, form.Nome, form.Email, form.Telefone,
                                                      form.DataNascimento, form.TipoDeCargo, form.Salario);

            repositorio.Inserir(funcionario);

            Console.WriteLine(Environment.NewLine + $"*** Funcionário { form.Nome } cadastrado com sucesso!");
        }

        private static void Listar()
        {
            if (repositorio.Listar().Count != 0)
            {
                foreach (Funcionario funcionario in repositorio.Listar())
                {
                    Console.WriteLine("== LISTA DE FUNCIONÁRIOS ==");
                    Console.WriteLine(funcionario);
                }
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "*** Lista vazia ***");
            }
        }
        private static void Remover()
        {
            Console.WriteLine(Environment.NewLine + "Digite o id do funcionário:");
            string idDigitado = Console.ReadLine();

            if (repositorio.RetornarPorId(Int16.Parse(idDigitado)) != null )
            {
                repositorio.Excluir(Int16.Parse(idDigitado));
                Console.WriteLine(Environment.NewLine + $"Funcionario { idDigitado } excluído com sucesso!");
            } else
            {
                Console.WriteLine(Environment.NewLine + $"Funcionario { idDigitado } não encontrado");
            }
        }

        private static void Alterar()
        {
            Console.WriteLine(Environment.NewLine + "Digite o id do funcionário:");
            string idDigitado = Console.ReadLine();

            int id = Int16.Parse(idDigitado);
            Funcionario funcionario = repositorio.RetornarPorId(id);

            if (funcionario != null)
            {
                Formulario form = Formulario("ALTERA");
                funcionario.SetNome(form.Nome);
                funcionario.SetEmail(form.Email);
                funcionario.SetTelefone(form.Telefone);
                funcionario.SetDataNascimento(form.DataNascimento);
                funcionario.SetTipoDeCargo(form.TipoDeCargo);
                funcionario.SetSalario(form.Salario);

                repositorio.Alterar(id, funcionario);

            }
        }

        public static Formulario Formulario(string modulo)
        {
            Formulario form = new Formulario();

            Console.WriteLine();
            Console.WriteLine($"== { modulo } ==");
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o e-mail:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o telefone:");
            string telefone = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento:");
            string dataNascimento = Console.ReadLine();
            Console.WriteLine("Selecione o cargo:");
            Console.WriteLine("1 - GERENTE");
            Console.WriteLine("2 - ENCARREGADO");
            Console.WriteLine("3 - VENDEDOR");
            string tipoDeCargo = Console.ReadLine();
            Console.WriteLine("Digite o salário:");
            string salario = Console.ReadLine();

            form.Nome = nome;
            form.Email = email;
            form.Telefone = telefone;
            if (Int16.Parse(tipoDeCargo) == 1)
            {
                form.TipoDeCargo = Cargo.GERENTE;
            }
            else if (Int16.Parse(tipoDeCargo) == 2)
            {
                form.TipoDeCargo = Cargo.ENCARREGADO;
            }
            else
            {
                form.TipoDeCargo = Cargo.MOTORISTA;
            }
            form.DataNascimento = DateTime.Parse(dataNascimento);
            form.Salario = Decimal.Parse(salario);

            return form;
        }

    }
}
