using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuDeletarUsuario : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Excluir um usuario");

        Console.Write("Informe o ID do usuario que será deletado: ");
        int id = int.Parse(Console.ReadLine()!);

        var usuario = db.Usuarios.FirstOrDefault(u => u.Id == id);


        if (usuario == null)
        {
            Console.WriteLine("Usuário não encontrado.");
             SairDoMenu();
             return;
        }

        db.Usuarios.Remove(usuario);
        Console.WriteLine("Usuário removido com sucesso!");

        SairDoMenu();

    }
}
