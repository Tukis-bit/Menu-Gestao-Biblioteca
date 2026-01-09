using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuBuscarUsuarioId : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Busca de usuário por id");

        Console.Write("Me informe o id do usuário para que eu faça a busca: ");
        int id = int.Parse(Console.ReadLine()!);
        Console.WriteLine("\nBuscando....\n");
        Thread.Sleep(1500);


        var usuario =  Filter.BuscarUsuarioPorId(id, db);

        if(usuario == null)
        {
            Console.WriteLine("Usuário não encontrado na lista");
        }
        else
        {
            Console.WriteLine($"Nome: {usuario.Nome}");
            Console.WriteLine($"Idade: {usuario.Idade}");


        }

       SairDoMenu();
    }
}

