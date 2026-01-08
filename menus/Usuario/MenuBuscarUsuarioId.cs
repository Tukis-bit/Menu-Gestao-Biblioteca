using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuBuscarUsuarioId : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Busca de usuario por id");

        Console.Write("Me informe o id do usuario para que eu faça a busca: ");
        int id = int.Parse(Console.ReadLine()!);
        Console.WriteLine("\nBuscando....\n");
        Thread.Sleep(1500);

        var ListaDeUsuarios = db.Usuarios;

        var usuario =  Filter.BuscarUsuarioPId(id,ListaDeUsuarios);

        if(usuario == null)
        {
            Console.WriteLine("Usuario não encontrado na lista");
        }
        else
        {
            Console.WriteLine($"Nome: {usuario.Nome}");
            Console.WriteLine($"Idade: {usuario.Idade}");


        }

       SairDoMenu();
    }
}