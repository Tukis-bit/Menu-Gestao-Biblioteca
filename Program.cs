using Biblioteca.Menus;

var db = JsonStorage.Carregar();
Database.DefinirIds(db);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1,new MenuUsuario());
opcoes.Add(2, new MenuLivro());

Console.Clear();
ExibirMenu();


 void ExibirMenu()
{
    Console.Clear();
    
Console.WriteLine(@"
1 - Usuarios
2 - Livros
3 - Emprestimos
0 - Salvar e Sair");

Console.Write("\nEscreva a opção que você deseja: ");
int escolha = int.Parse(Console.ReadLine()!);
Thread.Sleep(1500);


if(opcoes.ContainsKey(escolha))
{
    Menu menuEscolhido = opcoes[escolha];
    menuEscolhido.Executar(db);
}
else if( escolha == 0)
{
        JsonStorage.Salvar(db);
    Console.WriteLine("Dados salvos com sucesso.");
    Console.WriteLine("Saindo......");
    return;
}
else
{
    Console.WriteLine("Opção inválida, voltando ao menu");
}

ExibirMenu();
}

