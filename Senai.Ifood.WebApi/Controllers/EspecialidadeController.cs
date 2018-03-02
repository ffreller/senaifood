using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EspecialidadeController: Controller
    {
        private readonly IBaseRepository<EspecialidadeDomain> _repo;

        public EspecialidadeController(IBaseRepository<EspecialidadeDomain> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_repo.Listar());
        }

        [HttpGet ("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            return Ok(_repo.BuscarPorId(id));
        }

        [HttpDelete ("{id}")]
        public IActionResult Deletar(int id)
        {
            var Especialidade = _repo.BuscarPorId(id);
            return Ok(_repo.Deletar(Especialidade));
        }

        [HttpPost]
        public IActionResult Inserir([FromBody]EspecialidadeDomain Especialidade)
        {
            return Ok(_repo.Inserir(Especialidade));
        }

        [HttpPut ("{id}")]
        public IActionResult Autalizar(int id)
        {
            var especialidade = _repo.BuscarPorId(id);
            return Ok(_repo.Atualizar(especialidade));
        }


        
    }
}