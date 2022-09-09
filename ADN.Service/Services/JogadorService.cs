using ADN.Domain.Domain;
using ADN.Domain.DTO.Jogador;
using ADN.Domain.Interfaces.Repositorio;
using ADN.Domain.Interfaces.Services;
using AutoMapper;

namespace ADN.Service.Services
{
    public class JogadorService : IJogadorService
    {
        private readonly IJogadorRepositorio _repositorio;
        private readonly IMapper _mapper;

        public JogadorService(IJogadorRepositorio repositorio,
                              IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public async Task<List<Jogador>> GetAll()
        {
            return await _repositorio.GetAll();
        }

        public async Task Insert(JogadorInsertDTO jogadorDTO)
        {
            Jogador jogador = _mapper.Map<Jogador>(jogadorDTO);
            await _repositorio.Insert(jogador);
        }
    }
}
