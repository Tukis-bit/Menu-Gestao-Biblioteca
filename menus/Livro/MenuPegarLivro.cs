using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuPegarLivroEmprestado : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Emprestimo de Livros");
        Console.Write("Digite o seu ID de usuário: ");
        int id = int.Parse(Console.ReadLine()!);
        var usu = Filter.BuscarUsuarioPId(id,db);

        if(usu == null)
        { 
            Console.WriteLine("\nUsuario não encontrado. Voltando ao menu");
              Thread.Sleep(1000);
            return;
        }

        Console.Write("Informe o ID do livro que você deseja pegar emprestado: ");
        int id_livro = int.Parse(Console.ReadLine()!);

        usu.AdicionarEmprestimo(id_livro,db);
        Thread.Sleep(1500);

        SairDoMenu();
    }
}