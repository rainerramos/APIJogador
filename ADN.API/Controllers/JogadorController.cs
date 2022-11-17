using ADN.Domain.Domain;
using ADN.Domain.DTO.Jogador;
using ADN.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorService _service;
        private readonly ILogger<JogadorController> _log;

        public JogadorController(IJogadorService service,
                                 ILogger<JogadorController> log)
        {
            _service = service;
            _log = log;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _log.LogInformation("Buscando lista de jogadores");
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            _log.LogInformation("Buscando cadastro de jogador por Id");

            var result = await _service.GetById(id);

            if (result is not null)
                return Ok(result);

            return NotFound();

        }

        [HttpPost]
        public async Task<IActionResult> Insert(JogadorInsertDTO jogadorDTO)
        {
            try
            {
                _log.LogInformation("Salvando cadastro de jogador");
                await _service.Insert(jogadorDTO);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Erro ao salvar cadastro de jogador");
                return StatusCode(500, "Erro ao salvar cadastro, contate o administrativo");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            await _service.Delete(id);
            return NoContent();            
        }
    }
    
}
