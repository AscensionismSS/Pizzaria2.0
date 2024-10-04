using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Pizzaria2._0.Controllers.ApiControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly ViaCepService _viaCepService;

        public AddressController(ViaCepService viaCepService)
        {
            _viaCepService = viaCepService;
        }

        [HttpPost("BuscarEndereco")] // Define a rota para a busca de endereço
        public async Task<IActionResult> BuscarEndereco([FromBody] string cep)
        {
            var address = await _viaCepService.GetAdressByCep(cep);

            if (address == null)
            {
                return NotFound(); // Retorna 404 se o endereço não for encontrado
            }

            return Ok(address); // Retorna 200 com os dados do endereço
        }
    }
}
