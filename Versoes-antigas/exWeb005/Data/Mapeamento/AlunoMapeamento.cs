using exWeb001.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace exWeb001.Data.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Matricula).HasColumnType("varchar(50)");
            builder.Property(t => t.Nome).HasColumnType("varchar(100)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(100)");
            builder.Property(t => t.Data_De_Nascimento).HasColumnType("date");
            builder.Property(t => t.Cep).HasColumnType("varchar(10)");
            builder.Property(t => t.Endereco).HasColumnType("varchar(100)");
            builder.Property(t => t.Bairro).HasColumnType("varchar(50)");
            builder.Property(t => t.Cidade).HasColumnType("varchar(100)");
            builder.Property(t => t.Numero).HasColumnType("int");
        }
    }
}