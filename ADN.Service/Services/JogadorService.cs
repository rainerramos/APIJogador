using ADN.Domain.Domain;
using ADN.Domain.Interfaces.Repositorio;
using ADN.Domain.Interfaces.Services;

namespace ADN.Service.Services
{
    public class JogadorService : IJogadorService
    {
        private readonly IJogadorRepositorio _repositorio;

        public JogadorService(IJogadorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Jogador>> GetAll()
        {
            return await _repositorio.GetAll();
        }

        public async Task Insert(Jogador jogador)
        {
            await _repositorio.Insert(jogador);
        }
    }
}
