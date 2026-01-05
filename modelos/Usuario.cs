namespace Biblioteca.Modelos;

internal class Usuario : IEntidadeComId
{
    private static int  proximoId = 1;
    public int Id {get; internal set;}
    public string? Nome { get; set; }

    public Usuario(string? nome)
    {
        Id = proximoId;
        proximoId++;

        Nome = nome;
    }

    public int Idade {get; internal set;}
    public void AtribuirIdade(int idade)
    {
        for(int i = 1; i > 0; i++ )
      {  
        if(idade <= 9 || idade > 100 )
        {
            Console.Write("Idade inválida, escreva uma Idade entre 10 e 100 anos: ");
            idade = int.Parse(Console.ReadLine()!); 
            Console.WriteLine();
           
        }
        else
        {
            Idade = idade;
            break;
          
        }}
    } 

    public static List<Usuario> usuarios { get; } = new();
    public static void AdicionarUsuario(Usuario usu)
    {
        usuarios.Add(usu);
    }
}