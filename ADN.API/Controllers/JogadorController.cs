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
            _log.LogInformation("Iniciando GetAll");
            return Ok(await _service.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Insert(JogadorInsertDTO jogadorDTO)
        {
            await _service.Insert(jogadorDTO);
            return StatusCode(201);
        }
    }
    
}
