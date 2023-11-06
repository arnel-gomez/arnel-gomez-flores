namespace arnel_gomez_flores.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using arnel_gomez_flores.Business;
    using arnel_gomez_flores.Data.Entities;

    [Route("api/articulos")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly ArticuloService _articuloService;

        public ArticuloController(ArticuloService articuloService)
        {
            _articuloService = articuloService;
        }

        [HttpGet]
        public IActionResult ObtenerTodosLosArticulos()
        {
            var articulos = _articuloService.ObtenerTodosLosArticulos();
            return Ok(articulos);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerArticuloPorId(int id)
        {
            var articulo = _articuloService.ObtenerArticuloPorId(id);
            if (articulo == null)
            {
                return NotFound();
            }
            return Ok(articulo);
        }

        [HttpPost]
        public IActionResult AgregarArticulo([FromBody] Articulo articulo)
        {
            _articuloService.AgregarArticulo(articulo);
            return CreatedAtAction(nameof(ObtenerArticuloPorId), new { id = articulo.ArticuloID }, articulo);
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarArticulo(int id, [FromBody] Articulo articulo)
        {
            if (id != articulo.ArticuloID)
            {
                return BadRequest();
            }

            _articuloService.ActualizarArticulo(articulo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarArticulo(int id)
        {
            _articuloService.EliminarArticulo(id);
            return NoContent();
        }
    }
}
