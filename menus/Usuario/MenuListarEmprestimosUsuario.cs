using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuListarEmprestimosUsuario : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Empréstimos por Usuário");

        Console.Write("Digite o ID do usuário: ");
        int idUsuario = int.Parse(Console.ReadLine()!);

        var usuario = db.Usuarios.Find(u => u.Id == idUsuario);

        if (usuario == null)
        {
            Console.WriteLine($"\nUsuário com ID {idUsuario} não encontrado.");
        }
        else
        {
            Console.WriteLine($"\nEmpréstimos do usuário: {usuario.Nome}");
            Console.WriteLine();

            var emprestimosDoUsuario = db.Emprestimos
                .Where(e => e.Id_Usuario == idUsuario)
                .ToList();

            if (emprestimosDoUsuario.Count == 0)
            {
                Console.WriteLine("Este usuário não tem empréstimos.");
            }
            else
            {
                Console.WriteLine("ID | Livro");
                Console.WriteLine("---+--------");
                foreach (var emp in emprestimosDoUsuario)
                {
                    var livro = db.Livros.Find(l => l.Id == emp.Id_livro);
                    string nomeLivro = livro != null ? livro.Titulo : "Livro não encontrado";
                    Console.WriteLine($"{emp.Id} | {nomeLivro}");
                }
            }
        }

        SairDoMenu();
    }
}

