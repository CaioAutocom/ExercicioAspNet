using Domain.Models;
using Infra.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExercicioAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController
    {
        private readonly AppDbContext _appDbContext;

        public CidadeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Cidade>> GetAllGruposProdutosServicosAsync()
        {
            return await _appDbContext.Cidades.ToListAsync();
        }
    }


}
