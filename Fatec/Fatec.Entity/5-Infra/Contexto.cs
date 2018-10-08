using Fatec.Entity._4_Dto;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Fatec.Entity._5_Infra
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }

        public Contexto() : base("FatecConnectionString")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            // Cliente
            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);

            modelBuilder.Entity<Cliente>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Cliente>().Property(c => c.Nome).HasMaxLength(100);
            modelBuilder.Entity<Cliente>().Property(c => c.Cpf).HasMaxLength(30);
            modelBuilder.Entity<Cliente>().Property(c => c.Endereco).HasMaxLength(100);
            modelBuilder.Entity<Cliente>().Property(c => c.Cidade).HasMaxLength(70);
            modelBuilder.Entity<Cliente>().Property(c => c.DataNascimento);


            // Usuario
            modelBuilder.Entity<Usuario>().HasKey(p => p.Id);

            modelBuilder.Entity<Usuario>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Usuario>().Property(p => p.Nome).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(p => p.Login).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(p => p.Autorizacao);
            modelBuilder.Entity<Usuario>().Property(p => p.Senha).HasMaxLength(50);


            // Vendas
            modelBuilder.Entity<Venda>().HasKey(x => x.Id);

            modelBuilder.Entity<Venda>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Venda>().Property(x => x.IdCliente);
            modelBuilder.Entity<Venda>().Property(x => x.IdProduto);
            modelBuilder.Entity<Venda>().Property(x => x.DataVenda);

            modelBuilder.Entity<Venda>()
                .HasRequired(x => x.Cliente)
                .WithMany(x => x.Vendas)
                .HasForeignKey(x => x.IdCliente);

            modelBuilder.Entity<Venda>()
                .HasRequired(x => x.Cliente)
                .WithMany(x => x.Vendas)
                .HasForeignKey(x => x.IdCliente)
                .WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);
        }
    }
}
