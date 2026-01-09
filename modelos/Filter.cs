using System.Net;

namespace Biblioteca.Modelos;

internal class Filter
{
    public static Usuario? BuscarUsuarioPId (int id, Database db)
    {
        foreach(Usuario usu in db.Usuarios)
        {
            if(usu.Id == id)
            {
                return usu;
            }
        }
        return null;
    }

    public static Emprestimo? BuscarEmprestimoLivro(Livro livro, Database db)
    {
        var Emprestimo = db.Emprestimos.FirstOrDefault(e => e.Id_livro == livro.Id);

        if(Emprestimo == null)
        {
            return null;
        }
        return Emprestimo;
    }

    public static Emprestimo? BuscarEmprestimoLivroUsuario(int id_livro, int id_usuario, Database db)
    {
        return db.Emprestimos.FirstOrDefault(e => e.Id_livro == id_livro && e.Id_Usuario == id_usuario);
    }
}
