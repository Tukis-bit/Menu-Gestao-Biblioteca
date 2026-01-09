using System.Data.Common;
using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuDevolverlivro : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Devolvolução de Livro");
        Console.Write("Informe o seu id de usuario: ");
        int id = int.Parse(Console.ReadLine()!);

        var usu = Filter.BuscarUsuarioPId(id,db);

        if(usu == null)
        {
            Console.WriteLine("\n Usuario não identificado. Voltando ao menu");
            Thread.Sleep(1500);
            return;
        }

        Console.Write("\nInforme o id do livro que deseja devolver: ");
        int id_livro = int.Parse(Console.ReadLine()!);

        usu.DevolverLivro(id_livro,db);
        SairDoMenu();
    }
}