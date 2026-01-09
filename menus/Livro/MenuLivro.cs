namespace Biblioteca.Menus;

internal class MenuLivro : Menu
{
    public override void Executar(Database db)
    {

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuCadastrarLivro());
        opcoes.Add(2, new MenuListarLivros());
        opcoes.Add(3, new MenuBuscarLivroId());
        opcoes.Add(4, new MenuBuscarLivroNome());
        opcoes.Add(5, new MenuPegarLivroEmprestado());
        opcoes.Add(6, new MenuDevolverLivro());
        opcoes.Add(7, new MenuApagarLivro());

        void ExibirMenu()
        {


            ExibirNomeOpcao("Menu de Livros");

            Console.WriteLine(@"
1 - Cadastrar um novo Livro
2 - Listar Livros
3 - Buscar um Livro por ID
4 - Buscar um Livro por Nome
5 - Pegar Livro Emprestado
6 - Devolver Livro
7 - Apagar Livro
0 - Sair
");

            Console.Write("\nEscreva a opção que você deseja: ");
            int escolha = int.Parse(Console.ReadLine()!);
            Thread.Sleep(1500);


            if (opcoes.ContainsKey(escolha))
            {
                Menu menuEscolhido = opcoes[escolha];
                menuEscolhido.Executar(db);
            }
            else if (escolha == 0)
            {
                Console.WriteLine("Saindo......");
                return;
            }
            else
            {
                Console.WriteLine("Opção inválida, voltando ao menu");
            }

            ExibirMenu();
        }

        ExibirMenu();
    }
    }
