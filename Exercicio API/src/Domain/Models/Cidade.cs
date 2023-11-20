using Domain.Common;

namespace Domain.Models
{
    public class Cidade : EntityBase
    {

        //[Column("id_estado"), Required, ForeignKey("Estado"), Index("ix_cidade_nome", IsUnique = true, Order = 2)]
        public int IdEstado { get; set; }

       // [Column("nome"), Required, MaxLength(100), Index("ix_cidade_nome", IsUnique = true, Order = 1)]
        public string Nome { get; set; }

        //[Column("codigo_ibge"), Required, Index("ix_cidade_ibge", IsUnique = true)]
        public int CodigoIbge { get; set; }

        //[Column("ativo"), Required]
        public bool Ativo { get; set; } = true;
    }
}
