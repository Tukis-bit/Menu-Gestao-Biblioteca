using System.Diagnostics;
using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuCadastrarLivro : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Cadastrar Novo Livro");

        Console.Write("Iforme o nome do livro: ");
        string titulo = Console.ReadLine()!;

        Console.Write("\nInforme o nome do autor do livro: ");
        string nome = Console.ReadLine()!;

        Livro livro = new(titulo, nome);
        db.Livros.Add(livro);

        Thread.Sleep(1000);
        Console.WriteLine($"\nAdicionado livro {livro.Titulo} com o ID {livro.Id}");

        SairDoMenu();
    }
}

