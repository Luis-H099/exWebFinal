using exWeb001.Data.Mapeamento;
using exWeb001.Models;
using Microsoft.EntityFrameworkCore;

namespace exWeb001.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapeamento());
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Aluno> Aluno { get; set; }

    }
}
