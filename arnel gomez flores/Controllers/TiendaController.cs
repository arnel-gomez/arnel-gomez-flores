namespace arnel_gomez_flores.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using arnel_gomez_flores.Business;
    using arnel_gomez_flores.Data.Entities;

    [Route("api/tiendas")]
    [ApiController]
    public class TiendaController : ControllerBase
    {
        private readonly TiendaService _tiendaService;

        public TiendaController(TiendaService tiendaService)
        {
            _tiendaService = tiendaService;
        }

        [HttpGet]
        public IActionResult ObtenerTodasLasTiendas()
        {
            var tiendas = _tiendaService.ObtenerTodasLasTiendas();
            return Ok(tiendas);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerTiendaPorId(int id)
        {
            var tienda = _tiendaService.ObtenerTiendaPorId(id);
            if (tienda == null)
            {
                return NotFound();
            }
            return Ok(tienda);
        }

        [HttpPost]
        public IActionResult AgregarTienda([FromBody] Tienda tienda)
        {
            _tiendaService.AgregarTienda(tienda);
            return CreatedAtAction(nameof(ObtenerTiendaPorId), new { id = tienda.TiendaID }, tienda);
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarTienda(int id, [FromBody] Tienda tienda)
        {
            if (id != tienda.TiendaID)
            {
                return BadRequest();
            }

            _tiendaService.ActualizarTienda(tienda);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarTienda(int id)
        {
            _tiendaService.EliminarTienda(id);
            return NoContent();
        }
    }
}
