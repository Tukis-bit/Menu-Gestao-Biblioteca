namespace Biblioteca.Modelos;

internal class Filter
{
    public static Usuario? BuscarUsuarioPId (int id, List<Usuario> usuarios)
    {
        foreach(Usuario usu in usuarios)
        {
            if(usu.Id == id)
            {
                return usu;
            }
        }
        return null;
    }
}