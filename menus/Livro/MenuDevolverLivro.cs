using System.Data.Common;
using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuDevolverLivro : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Devolução de Livro");
        Console.Write("Informe o seu id de usuário: ");
        int id = int.Parse(Console.ReadLine()!);

        var usu = Filter.BuscarUsuarioPorId(id, db);

        if(usu == null)
        {
            Console.WriteLine("\nUsuário não identificado. Voltando ao menu");
            Thread.Sleep(1500);
            return;
        }

        Console.Write("\nInforme o id do livro que deseja devolver: ");
        int id_livro = int.Parse(Console.ReadLine()!);

        usu.DevolverLivro(id_livro,db);
        SairDoMenu();
    }
}

