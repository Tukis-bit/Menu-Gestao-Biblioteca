namespace Biblioteca.Menus;

internal class MenuUsuario : Menu
{

    public override void Executar(Database db)
    {

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuCadstrarUsuario());
        opcoes.Add(2, new MenuListarUsuarios());
        opcoes.Add(3, new MenuBuscarUsuarioId());
        opcoes.Add(4, new MenuDeletarUsuario());

        void ExibirMenu()
        {


            ExibirNomeOpcao("Menu de Usuarios");

            Console.WriteLine(@"
1 - Cadastrar um novo usuario
2 - Listar Usuarios
3 - Buscar um usuario por ID
4 - Apagar um usuario
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
