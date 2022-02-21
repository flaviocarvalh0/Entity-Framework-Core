using System;
using Context;
using Microsoft.EntityFrameworkCore;
using static System.Console;


namespace EFCore
{

    class Program

    {
        static void Main(string[] args)
        {
            using(var db = new LivroContext())
            {
                //faz com q o BD seja criado
                //db.Database.EnsureCreated();

                db.livros.Add(new Livros.Livro {Titulo = "Senhor dos Áneis Duas torres", Autor = "J.R.R Tolkien", AnoPublicacao = 1922});
                db.livros.Add(new Livros.Livro {Titulo = "A batalha do Apocallipse", Autor = "Eduardo Spohr", AnoPublicacao = 2005});
                db.SaveChanges();

                WriteLine("----------------- RESULTADO -----------------");
                db.livros.ForEachAsync(x =>  WriteLine($"Título: {x.Titulo} | Autor: {x.Autor} | Ano de Publicação: {x.AnoPublicacao}"));

            }
        }

    }
}