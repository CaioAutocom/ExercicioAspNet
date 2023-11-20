using Domain.Models;
using Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class GrupoProdutoServicoRepository : RepositoryBase<GrupoProdutoServico>, IGrupoProdutoServicoRepository
    {
        public GrupoProdutoServicoRepository(AppDbContext db) : base(db)
        {
        }
    }
}
