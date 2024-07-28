using Microsoft.EntityFrameworkCore;
using WinFormsApp.Itens;
using WinFormsApp.Modelos;

namespace WinFormsApp.BancoDeDados
{
    internal class BancoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<FuncaoFuncionario> FuncaoFuncionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Datasource=banco.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<FuncaoFuncionario>()
                .HasMany(ff => ff.Funcionarios)
                .WithOne(f => f.FuncaoFuncionario)
                .HasForeignKey(f => f.idFuncaoFuncionario);
                

            base.OnModelCreating(modelBuilder);
        }

    }
}
