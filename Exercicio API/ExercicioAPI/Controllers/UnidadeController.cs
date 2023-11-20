using Infra.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnidadeController : ControllerBase
    {
        private readonly AppDbContext _context;

    }
}
