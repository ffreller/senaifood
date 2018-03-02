using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController: Controller
    {
        private readonly IBaseRepository<UsuarioDomain> _repo;

        public UsuarioController(IBaseRepository<UsuarioDomain> repo)
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
            var usuario = _repo.BuscarPorId(id);
            return Ok(_repo.Deletar(usuario));
        }

        [HttpPost]
        public IActionResult Inserir([FromBody]UsuarioDomain Usuario)
        {
            return Ok(_repo.Inserir(Usuario));
        }

        [HttpPut ("{id}")]
        public IActionResult Autalizar(int id)
        {
            var usuario = _repo.BuscarPorId(id);
            return Ok(_repo.Atualizar(usuario));
        }


        
    }
}