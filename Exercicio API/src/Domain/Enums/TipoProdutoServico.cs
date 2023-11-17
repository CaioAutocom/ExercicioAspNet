using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum TipoProdutoServico
    {
        [Description("Produto")]
        Produto = 0,

        [Description("Serviço")]
        Servico = 1
    }
}
