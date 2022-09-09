using ADN.Domain.Domain;
using ADN.Domain.DTO.Jogador;
using ADN.Domain.Interfaces.Repositorio;
using ADN.Domain.Interfaces.Services;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ADN.Service.Services
{
    public class JogadorService : IJogadorService
    {
        private readonly IJogadorRepositorio _repositorio;
        private readonly IMapper _mapper;
        private readonly ILogger<JogadorService> _log;

        public JogadorService(IJogadorRepositorio repositorio,
                              IMapper mapper, 
                              ILogger<JogadorService> logger)
        {
            _repositorio = repositorio;
            _mapper = mapper;
            _log = logger;
        }

        public async Task<List<Jogador>> GetAll()
        {
            _log.LogInformation("Buscando jogadores no service");
            return await _repositorio.GetAll();
        }

        public async Task Insert(JogadorInsertDTO jogadorDTO)
        {
            try
            {
                _log.LogInformation($"Salvando jogador {JsonConvert.SerializeObject(jogadorDTO)} no banco de dados");
                Jogador jogador = _mapper.Map<Jogador>(jogadorDTO);

                _log.LogInformation($"Jogador mapeado com sucesso {JsonConvert.SerializeObject(jogador)}es");
                await _repositorio.Insert(jogador);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Erro ao salvar jogador");
                throw;
            }
        }
    }
}
