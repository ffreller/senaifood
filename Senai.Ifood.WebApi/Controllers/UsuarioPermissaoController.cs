using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioPermissaoController: Controller
    {
        private readonly IBaseRepository<UsuarioPermissaoDomain> _repo;

        public UsuarioPermissaoController(IBaseRepository<UsuarioPermissaoDomain> repo)
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
            var usuarioPermissao = _repo.BuscarPorId(id);
            return Ok(_repo.Deletar(usuarioPermissao));
        }

        [HttpPost]
        public IActionResult Inserir([FromBody]UsuarioPermissaoDomain UsuarioPermissao)
        {
            return Ok(_repo.Inserir(UsuarioPermissao));
        }

        [HttpPut ("{id}")]
        public IActionResult Autalizar(int id)
        {
            var usuarioPermissao = _repo.BuscarPorId(id);
            return Ok(_repo.Atualizar(usuarioPermissao));
        }


        
    }
}