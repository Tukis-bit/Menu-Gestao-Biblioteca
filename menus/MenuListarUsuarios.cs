using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuListarUsuarios : Menu
{
    public override void Executar()
    {
        ExibirNomeOpcao("Lista de usuarios");
        Usuario.usuarios.ForEach(u => Console.WriteLine($"{u.Id} - {u.Nome} - {u.Idade}"));
        SairDoMenu();
    }
}