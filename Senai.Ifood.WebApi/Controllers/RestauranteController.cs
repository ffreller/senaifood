using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class RestauranteController: Controller
    {
        private readonly IBaseRepository<RestauranteDomain> _repo;

        public RestauranteController(IBaseRepository<RestauranteDomain> repo)
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
            var restaurante = _repo.BuscarPorId(id);
            return Ok(_repo.Deletar(restaurante));
        }

        [HttpPost]
        public IActionResult Inserir([FromBody]RestauranteDomain Restaurante)
        {
            return Ok(_repo.Inserir(Restaurante));
        }

        [HttpPut ("{id}")]
        public IActionResult Autalizar(int id)
        {
            var restaurante = _repo.BuscarPorId(id);
            return Ok(_repo.Atualizar(restaurante));
        }

        [HttpGet]
        public IActionResult GetAction(){
            return Ok(_repo.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetAction(int id){
            var restaurante = _repo.BuscarPorId(id);
            if(restaurante != null) 
                return Ok(restaurante);
            else
                return NotFound();
        }


        
    }
}