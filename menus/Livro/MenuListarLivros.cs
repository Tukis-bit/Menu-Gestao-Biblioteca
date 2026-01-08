using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuListarLivros : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Lista de livros");
        
        if (db.Livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado.");
        }
        else
        {
            Console.WriteLine("ID | Título | Autor | Status");
            Console.WriteLine("---+--------+-------+--------");
            db.Livros.ForEach(l => Console.WriteLine($"{l.Id} | {l.Titulo} | {l.Autor} | {(l.Emprestado ? "Emprestado" : "Disponível")}"));
        }
        
        SairDoMenu();
    }
}

