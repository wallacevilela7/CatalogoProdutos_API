using CatalogoProdutos_api.Models;
using CatalogoProdutos_api.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoProdutos_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_produtoService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var produto = _produtoService.FindById(id);
            if (produto == null) return NotFound();

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            if (produto == null) return BadRequest();

            return Ok(_produtoService.Create(produto));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Produto produto)
        {
            if (produto == null) return BadRequest();

            return Ok(_produtoService.Update(produto));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _produtoService.Delete(id);
            return NoContent();
        }
    }
}
