using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mapping
{
    public class GrupoProdutoServicoMap : IEntityTypeConfiguration<GrupoProdutoServico>
    {
        public void Configure(EntityTypeBuilder<GrupoProdutoServico> builder)
        {
            builder.ToTable("grupo_produto_servico");
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.IdArquigrupoProdutoServico).HasColumnName("id_arquigrupo_produto_servico");
            builder.Property(x => x.TipoProdutoServico).HasColumnName("tipo_produto_servico");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Ativo).HasColumnName("ativo");
        }
    }
}
