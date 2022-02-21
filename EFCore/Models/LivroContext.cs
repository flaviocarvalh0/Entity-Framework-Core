using Livros;
using Microsoft.EntityFrameworkCore;


namespace Context
{
    public class LivroContext : DbContext
    {
        public DbSet<Livro> livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
        }

        //usado para modificar como as tabelas são criadas por ex.: a a classe livro iria ser Livros na tabela do EF modificamos então para Livro. OPCIONAL

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .ToTable("Livro");

            //definindo o LivroId como chave Primaria
            modelBuilder.Entity<Livro>()
                .HasKey(p => p.LivroId);

            //com o EF será criado a propriedade Titulo com varchar(max), definimos então no modelbuilder q será de apenas varchar(50)
            modelBuilder.Entity<Livro>()
                .Property(p => p.Titulo)
                .HasColumnType("varchar(50)");
        }


    }

}