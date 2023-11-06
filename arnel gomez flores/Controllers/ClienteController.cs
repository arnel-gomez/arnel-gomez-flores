namespace arnel_gomez_flores.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using arnel_gomez_flores.Business;
    using arnel_gomez_flores.Data.Entities;

    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult ObtenerTodosLosClientes()
        {
            var clientes = _clienteService.ObtenerTodosLosClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerClientePorId(int id)
        {
            var cliente = _clienteService.ObtenerClientePorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult AgregarCliente([FromBody] Cliente cliente)
        {
            _clienteService.AgregarCliente(cliente);
            return CreatedAtAction(nameof(ObtenerClientePorId), new { id = cliente.ClienteID }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarCliente(int id, [FromBody] Cliente cliente)
        {
            if (id != cliente.ClienteID)
            {
                return BadRequest();
            }

            _clienteService.ActualizarCliente(cliente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarCliente(int id)
        {
            _clienteService.EliminarCliente(id);
            return NoContent();
        }
    }
}
