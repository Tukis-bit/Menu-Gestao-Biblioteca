using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuListarUsuarios : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Lista de usuarios");

        if (db.Usuarios.Count == 0)
        {
            Console.WriteLine("Nenhum usuário cadastrado.");
        }
        else
        {
            Console.WriteLine("ID | Nome | Idade");
            Console.WriteLine("---+------+--------");
            db.Usuarios.ForEach(u => Console.WriteLine($"{u.Id}  | {u.Nome}  | {u.Idade} anos"));
        }

        SairDoMenu();
    }
}
