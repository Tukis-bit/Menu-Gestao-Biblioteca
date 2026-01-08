using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal class MenuCadstrarUsuario : Menu
{
    public override void Executar(Database db)
    {
        ExibirNomeOpcao("Cadastrar Usuario");

        Console.Write("Informe o nome do usuário: ");
        string nome = Console.ReadLine()!;
        Usuario usu = new(nome);

        Console.Write("Informe a sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);
        usu.AtribuirIdade(idade); 

        db.Usuarios.Add(usu);
        

        Console.WriteLine($"Usuário cadastrado. ID : {usu.Id}");
        SairDoMenu();
    }
}