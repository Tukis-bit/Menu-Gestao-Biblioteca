using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuBuscarLivroNome : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Buscar livro por nome");

        Console.Write("Informe o nome do livro: ");
        string nome = Console.ReadLine()!.ToLower();

        var livros = db.Livros.Where(l => l.Titulo.ToLower().Contains(nome)).ToList();

        if (livros.Count == 0)
        {
            Console.WriteLine($"Nenhum livro encontrado com o nome \"{nome}\".");
        }
        else
        {
            Console.WriteLine($"\nLivros encontrados ({livros.Count}):");
            Console.WriteLine("ID | Título | Autor | Status");
            Console.WriteLine("---+--------+-------+--------");
            livros.ForEach(l => Console.WriteLine($"{l.Id} | {l.Titulo} | {l.Autor} | {(l.Emprestado ? "Emprestado" : "Disponível")}"));
        }

        SairDoMenu();
    }
}

