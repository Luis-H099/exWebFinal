using exWeb001.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exWeb001.Data.Mapeamento
{
    public class ProfessorMapeamento : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Nome).HasColumnType("varchar(100)");
            builder.Property(t => t.Email).HasColumnType("varchar(100)");
            builder.Property(t => t.Disciplina).HasColumnType("varchar(100)");
        }
    }
}
