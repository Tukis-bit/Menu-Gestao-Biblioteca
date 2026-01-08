using System.Data.Common;

using System.Text.Json.Serialization;

namespace Biblioteca.Modelos;

internal class Usuario : IEntidadeComId
{
    public static int  proximoId = 0;
    public int Id {get; set;}
    public string? Nome { get; set; }

    public Usuario(string? nome)
    {
        proximoId++;
        Id = proximoId;

        Nome = nome;
        Idade = 0;
    }

    [JsonConstructor]
    public Usuario(int id, string? nome, int idade)
    {
        Id = id;
        Nome = nome;
        Idade = idade;
    }


    public int Idade {get;set;}
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
            this.Idade = idade;
            break;
          
        }}
    }

}
