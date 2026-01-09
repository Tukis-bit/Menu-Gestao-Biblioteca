using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuApagarLivro : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Excluir um livro");

        Console.Write("Informe o ID do livro que será deletado: ");
        int id = int.Parse(Console.ReadLine()!);

        var livro = db.Livros.FirstOrDefault(l => l.Id == id);

        if (livro == null)
        {
            Console.WriteLine("Livro não encontrado.");
            SairDoMenu();
            return;
        }

        db.Emprestimos.RemoveAll(e => e.Id_livro == livro.Id);
        db.Livros.Remove(livro);
        Console.WriteLine("Livro removido com sucesso!");

        SairDoMenu();
    }
}

