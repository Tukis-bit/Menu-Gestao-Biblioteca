using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuApagarUsuario : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Excluir um usuário");

        Console.Write("Informe o ID do usuário que será excluído: ");
        int id = int.Parse(Console.ReadLine()!);

        var usuario = db.Usuarios.FirstOrDefault(u => u.Id == id);


        if (usuario == null)
        {
            Console.WriteLine("Usuário não encontrado.");
             SairDoMenu();
             return;
        }

        db.Emprestimos.RemoveAll(e => e.Id_Usuario == usuario.Id);
        db.Usuarios.Remove(usuario);
        Console.WriteLine("Usuário removido com sucesso!");

        SairDoMenu();

    }
}

