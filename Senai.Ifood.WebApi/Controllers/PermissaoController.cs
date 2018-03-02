using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PermissaoController: Controller
    {
        private readonly IBaseRepository<PermissaoDomain> _repo;

        public PermissaoController(IBaseRepository<PermissaoDomain> repo)
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
            var permissao = _repo.BuscarPorId(id);
            return Ok(_repo.Deletar(permissao));
        }

        [HttpPost]
        public IActionResult Inserir([FromBody]PermissaoDomain Permissao)
        {
            return Ok(_repo.Inserir(Permissao));
        }

        [HttpPut ("{id}")]
        public IActionResult Autalizar(int id)
        {
            var permissao = _repo.BuscarPorId(id);
            return Ok(_repo.Atualizar(permissao));
        }


        
    }
}