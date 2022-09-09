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

        public JogadorController(IJogadorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
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
