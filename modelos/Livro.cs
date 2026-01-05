namespace Biblioteca.Modelos;

internal class Livro : IEntidadeComId
{
    private static int proximoID = 1;

    public Livro( string titulo, string autor)
    {
        Id = proximoID;
        proximoID++;

        Titulo = titulo;
        Autor = autor;
        Emprestado = false;
    }

    public int Id {get;}
    public string Titulo { get;  }
    public string Autor { get; }
    public bool Emprestado { get; set; }

    public static List<Livro> livros = new();

    public static void AdicionarLivro(Livro li)
    {
        livros.Add(li);
    }
}