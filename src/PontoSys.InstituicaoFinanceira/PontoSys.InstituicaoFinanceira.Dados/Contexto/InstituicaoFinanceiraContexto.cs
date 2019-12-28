using Microsoft.EntityFrameworkCore;
using PontoSys.InstituicaoFinanceira.Dominio.Entidades;

namespace PontoSys.InstituicaoFinanceira.Dados.Contexto
{
    public class InstituicaoFinanceiraContexto : DbContext
    {
        public InstituicaoFinanceiraContexto(DbContextOptions<InstituicaoFinanceiraContexto> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Conta> Contas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(c => c.ClienteId);
            modelBuilder.Entity<Cliente>().Property(c => c.Nome).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Endereco).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Email).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Telefone).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Sexo).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.DataNascimento).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Deletado).IsRequired();
            modelBuilder.Entity<Cliente>().Ignore(c => c.Valida);
            modelBuilder.Entity<Cliente>().Ignore(c => c.Invalida);
            modelBuilder.Entity<Cliente>().Ignore(c => c.ValidationResult);

            modelBuilder.Entity<PessoaFisica>().Property(pf => pf.CPF).IsRequired().HasMaxLength(11);

            modelBuilder.Entity<PessoaJuridica>().Property(pj => pj.CNPJ).IsRequired().HasMaxLength(14);

            modelBuilder.Entity<Conta>().HasKey(c => c.ContaId);
            modelBuilder.Entity<Conta>().Property(c => c.NumeroConta).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Conta>().HasIndex(u => u.NumeroConta).IsUnique();
            modelBuilder.Entity<Conta>().Property(c => c.Saldo).IsRequired();
            modelBuilder.Entity<Conta>().Property(c => c.DataAbertura).IsRequired();
            modelBuilder.Entity<Conta>().Property(c => c.Senha).IsRequired().HasMaxLength(8);
            modelBuilder.Entity<Conta>().Property(c => c.Situacao).IsRequired();
            modelBuilder.Entity<Conta>().Ignore(c => c.Valida);
            modelBuilder.Entity<Conta>().Ignore(c => c.Invalida);
            modelBuilder.Entity<Conta>().Ignore(c => c.ValidationResult);

            modelBuilder.Entity<Conta>()
                .HasOne<Cliente>(c => c.Cliente)
                .WithMany(c => c.Contas)
                .HasForeignKey(c => c.ClienteId);
        }
    }
}
