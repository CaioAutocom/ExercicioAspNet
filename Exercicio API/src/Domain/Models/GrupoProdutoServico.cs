using Domain.Common;
using Domain.Enums;

namespace Domain.Models
{
    public class GrupoProdutoServico : EntityBase
    {
        //[Key, Column("id"), Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Column("id_arquigrupo_produto_servico"), ForeignKey("ArquigrupoProdutoServico")]
        public int? IdArquigrupoProdutoServico { get; set; }

        //[Column("tipo_produto_servico"), Required]
        public TipoProdutoServico TipoProdutoServico { get; set; }

        //[Column("nome"), Required, MaxLength(50)]
        public string Nome { get; set; }

        //[Column("ativo"), Required]
        public bool Ativo { get; set; } = true;
    }
}
