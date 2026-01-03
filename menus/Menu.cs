using System.ComponentModel;
using Biblioteca.Modelos;

namespace Biblioteca.Menus;

internal abstract class Menu
{
    
    public abstract void Executar();

    public virtual void ExibirNomeOpcao(string nome)
    {
        int numeroLetras = nome.Length;

        string asteriscos = string.Empty.PadLeft(numeroLetras,'*');
        Console.Clear();

        Console.WriteLine(asteriscos);
        Console.WriteLine(nome);
        Console.WriteLine(asteriscos);
        Console.WriteLine();


    }

}