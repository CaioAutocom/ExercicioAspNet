using Domain.Models;
using Infra.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExercicioAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrupoProdutoServicoController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public GrupoProdutoServicoController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IEnumerable<GrupoProdutoServico>> GetAllGruposProdutosServicosAsync()
        {
            return await _dbContext.GruposProdutoServico.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<GrupoProdutoServico> GetByIdGruposProdutosServicosAsync(int id)
        {
            return await _dbContext.GruposProdutoServico.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<int> AddGrupoProdutoServicoAsync([FromBody] GrupoProdutoServico grupoProdutoServico)
        {
            await _dbContext.GruposProdutoServico.AddAsync(grupoProdutoServico);
            await _dbContext.SaveChangesAsync();
            return grupoProdutoServico.Id;
        }

        [HttpPut]
        public async Task UpdateGrupoProdutoServico([FromBody] GrupoProdutoServico grupoProdutoServico)
        {
            _dbContext.Entry(grupoProdutoServico).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        [HttpDelete]
        public async Task DeleteGrupoProdutoServico(int id)
        {
            var grupo = await _dbContext.GruposProdutoServico.FirstOrDefaultAsync(x => x.Id == id);
            _dbContext.Entry(grupo).State = EntityState.Deleted;

            await _dbContext.SaveChangesAsync();
        }
    }
}
