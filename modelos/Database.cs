

using System.Runtime.CompilerServices;
using Biblioteca.Menus;
using Biblioteca.Modelos;

internal class Database
{
    public  List<Livro> Livros { get; set; } = new();
    public  List<Usuario> Usuarios { get; set; } = new();
    public List<Emprestimo> Emprestimos { get; set; } = new();

    public static void DefinirIds(Database db)
    {
      
      if(db.Livros.Count > 0)
        {
            Livro.proximoID = db.Livros.Max( l => l.Id);
        }
        
        if(db.Usuarios.Count > 0)
        {
            Usuario.proximoId = db.Usuarios.Max(u => u.Id);
        }

          if(db.Emprestimos.Count > 0)
        {
            Emprestimo.proximoId = db.Emprestimos.Max( e => e.Id);
        }
    } 
    
}