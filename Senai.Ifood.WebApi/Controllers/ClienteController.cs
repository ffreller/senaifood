using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;

namespace Senai.Ifood.WebApi.Controllers
{   
    [Route("api/[controller]")]
    public class ClienteController: Controller
    {
        private readonly IBaseRepository<ClienteDomain> _repo;

        public ClienteController(IBaseRepository<ClienteDomain> repo)
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
            var cliente = _repo.BuscarPorId(id);
            return Ok(_repo.Deletar(cliente));
        }

        [HttpPost]
        public IActionResult Inserir([FromBody]ClienteDomain cliente)
        {
            return Ok(_repo.Inserir(cliente));
        }

        [HttpPut ("{id}")]
        public IActionResult Autalizar(int id)
        {
            var cliente = _repo.BuscarPorId(id);
            return Ok(_repo.Atualizar(cliente));
        }


        
    }
}