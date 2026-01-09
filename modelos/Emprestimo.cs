using System.Text.Json.Serialization;

namespace Biblioteca.Modelos;

internal class Emprestimo : IEntidadeComId
{
    public static int proximoId = 0;

    public Emprestimo(int id_livro, int id_Usuario)
    {
        proximoId++;
        Id = proximoId;
        Id_livro = id_livro;
        Id_Usuario = id_Usuario;
    }

[JsonConstructor]
    public Emprestimo(int id, int id_livro, int id_Usuario)
    {
        Id = id;
        Id_livro = id_livro;
        Id_Usuario = id_Usuario;
    }

    public int Id{get;}

    public int Id_livro {get;}
    public int Id_Usuario { get; }


}