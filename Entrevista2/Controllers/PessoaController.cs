using Entrevista2.Data;
using Entrevista2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entrevista2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaContext _context;

        public PessoaController(PessoaContext context)
        {
            _context = context;
        }

        [HttpGet] //Retorna todas as pessoas
        public ActionResult<IEnumerable<Pessoa>> Get()
        {
            return _context.Pessoas.AsNoTracking().ToList() ; 
        }

        [HttpGet("pessoasComPet")] //Seleciona todas as pessoas com Pet
        public ActionResult<IEnumerable<Pessoa>> GetPessoaPet()
        {
            return _context
                    .Pessoas
                    .Where(p => p.Pets.Any())
                    .ToList();
        }

        [HttpGet("pessoasComFilhosSemPet")] //Seleciona as pessoas com filho sem Pet
        public ActionResult<IEnumerable<Pessoa>> GetPessoaFilhoSemPet()
        {
            return _context
                    .Pessoas
                    .Where(p => p.QtdFilhos > 0)
                    .Where(p => p.Pets.All(x => x.PessoaId == null))
                    .ToList(); 
        }
    }
}