using Biblioteca.Menus;


Dictionary<int, Menu> opcoes = new();
opcoes.Add(1,new MenuCadstrarUsuario());
opcoes.Add(2, new MenuListarUsuarios());
Console.Clear();

 void ExibirMenu()
{
    Console.Clear();
    
Console.WriteLine(@"
1 - Cadastrar um novo usuario
2 - Listar Usuarios
0 - Salvar e Sair");

Console.Write("\nEscreva a opção que você deseja: ");
int escolha = int.Parse(Console.ReadLine()!);
Thread.Sleep(1500);


if(opcoes.ContainsKey(escolha))
{
    Menu menuEscolhido = opcoes[escolha];
    menuEscolhido.Executar();
}
else if( escolha == 0)
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