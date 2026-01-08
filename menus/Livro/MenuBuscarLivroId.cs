using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuBuscarLivroId : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Buscar livro por ID");

        Console.Write("Informe o ID do livro: ");
        int id = int.Parse(Console.ReadLine()!);

        var livro = db.Livros.FirstOrDefault(l => l.Id == id);

        if (livro == null)
        {
            Console.WriteLine($"Livro com ID {id} não encontrado.");
        }
        else
        {
            Console.WriteLine($"ID: {livro.Id}");
            Console.WriteLine($"Título: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
            Console.WriteLine($"Status: {(livro.Emprestado ? "Emprestado" : "Disponível")}");
        }

        SairDoMenu();
    }
}

