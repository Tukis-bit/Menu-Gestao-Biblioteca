namespace Biblioteca.Menus;

internal class MenuUsuario : Menu
{

    public override void Executar(Database db)
    {

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuCadastrarUsuario());
        opcoes.Add(2, new MenuListarUsuarios());
        opcoes.Add(3, new MenuBuscarUsuarioId());
        opcoes.Add(4, new MenuApagarUsuario());
        opcoes.Add(5, new MenuListarEmprestimosUsuario());

        void ExibirMenu()
        {


            ExibirNomeOpcao("Menu de Usuários");

            Console.WriteLine(@"
1 - Cadastrar um novo usuário
2 - Listar Usuários
3 - Buscar um usuário por ID
4 - Apagar um usuário
5 - Listar empréstimos de um usuário
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
                Thread.Sleep(1000);
            }

            ExibirMenu();
        }

        ExibirMenu();
    }


}

