using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController: Controller
    {
        private readonly IBaseRepository<ProdutoDomain> _repo;

        public ProdutoController(IBaseRepository<ProdutoDomain> repo)
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
            var produto = _repo.BuscarPorId(id);
            return Ok(_repo.Deletar(produto));
        }

        [HttpPost]
        public IActionResult Inserir([FromBody]ProdutoDomain Produto)
        {
            return Ok(_repo.Inserir(Produto));
        }

        [HttpPut ("{id}")]
        public IActionResult Autalizar(int id)
        {
            var produto = _repo.BuscarPorId(id);
            return Ok(_repo.Atualizar(produto));
        }


        
    }
}