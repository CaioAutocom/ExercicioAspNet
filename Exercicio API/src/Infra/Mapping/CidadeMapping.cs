using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mapping
{
    public class CidadeMapping : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> cidade)
        {
            cidade.ToTable("cidade");
            cidade.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd().IsRequired();
            cidade.HasKey(x => x.Id);

            cidade.Property(x => x.IdEstado).HasColumnName("id_estado").IsRequired();
            cidade.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            cidade.Property(x => x.CodigoIbge).HasColumnName("codigo_ibge").HasMaxLength(32).IsRequired();
            cidade.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();
        }
    }
}
