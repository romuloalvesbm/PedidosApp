using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PedidosApp.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return StatusCode(501); //Not Implemented
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id)
        {
            return StatusCode(501); //Not Implemented
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return StatusCode(501); //Not Implemented
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return StatusCode(501); //Not Implemented
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return StatusCode(501); //Not Implemented
        }
    }
}

