using System.Text.Json.Serialization;

namespace Biblioteca.Modelos;

internal class Livro : IEntidadeComId
{
    public  static int proximoID = 0;

    public Livro( string titulo, string autor)
    {
        proximoID++;
        Id = proximoID;

        Titulo = titulo;
        Autor = autor;
        Emprestado = false;
    }

    [JsonConstructor]
    public Livro(int id, string titulo,string autor, bool emprestado )
    {
      
        Id = id;

        Titulo = titulo;
        Autor = autor;
        this.Emprestado = emprestado;
    }

    public int Id {get; set;}
    public string Titulo { get;  }
    public string Autor { get; }
    public bool Emprestado { get; set; }

   
}
