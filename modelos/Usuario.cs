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

    public void AdicionarEmprestimo(int id_livro,Database db)
    {
        var livro = db.Livros.FirstOrDefault(l => l.Id == id_livro);

        if (livro is not null && !livro.Emprestado)
        {
            Emprestimo novoEmprestimo = new(id_livro,this.Id);
            db.Emprestimos.Add(novoEmprestimo);
            livro.Emprestado = true;

            Console.WriteLine($"\nEmpréstimo do livro {livro.Titulo} Para usuário {this.Nome} realizado com sucesso");
        }
        else
        {
            Console.WriteLine("\nLivro não pode ser emprestado");
            Console.WriteLine();
        }

    }

    public void DevolverLivro(int id_livro,Database db)
    {
        var livro = db.Livros.FirstOrDefault(l => l.Id == id_livro);

        if (livro is null)
        {
            Console.WriteLine("\nLivro não existe");
            Console.WriteLine();
            return;
        }

        if (!livro.Emprestado)
        {
            Console.WriteLine("\nLivro não está emprestado");
            Console.WriteLine();
            return;
        }

        var emprestimo = Filter.BuscarEmprestimoLivroUsuario(id_livro, this.Id, db);

        if (emprestimo is null)
        {
            Console.WriteLine("\nLivro não foi emprestado para este usuário");
            Console.WriteLine();
            return;
        }

        livro.Emprestado = false;
        db.Emprestimos.Remove(emprestimo);

        Console.WriteLine($"\nLivro {livro.Titulo} devolvido com sucesso");    
    }

}

