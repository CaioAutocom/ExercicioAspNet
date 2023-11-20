using Domain.Models;
using Infra.Persistence;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExercicioAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrupoProdutoServicoController : ControllerBase
    {
        private readonly IGrupoProdutoServicoRepository _grupoProdutoServicoRepository;

        public GrupoProdutoServicoController(IGrupoProdutoServicoRepository grupoProdutoServicoRepository)
        {
            _grupoProdutoServicoRepository = grupoProdutoServicoRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<GrupoProdutoServico>> GetAllGruposProdutosServicosAsync()
        {
            return await _grupoProdutoServicoRepository.ObterTodos();
        }

        [HttpGet("{id:int}")]
        public async Task<GrupoProdutoServico> GetByIdGruposProdutosServicosAsync(int id)
        {
            return await _grupoProdutoServicoRepository.ObterPorId(id);
        }

        [HttpPost]
        public async Task<int> AddGrupoProdutoServicoAsync([FromBody] GrupoProdutoServico grupoProdutoServico)
        {
            await _grupoProdutoServicoRepository.Adicionar(grupoProdutoServico);
            await _grupoProdutoServicoRepository.SaveChanges();
            return grupoProdutoServico.Id;
        }

        [HttpPut]
        public async Task UpdateGrupoProdutoServico([FromBody] GrupoProdutoServico grupoProdutoServico)
        {
            await _grupoProdutoServicoRepository.Atualizar(grupoProdutoServico);
            await _grupoProdutoServicoRepository.SaveChanges();
        }

        [HttpDelete]
        public async Task DeleteGrupoProdutoServico(int id)
        {
            await _grupoProdutoServicoRepository.Remover(id);
            await _grupoProdutoServicoRepository.SaveChanges();
        }
    }
}
