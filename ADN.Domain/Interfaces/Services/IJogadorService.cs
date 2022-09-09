using ADN.Domain.Domain;

namespace ADN.Domain.Interfaces.Services
{
    public interface IJogadorService
    {
        Task<List<Jogador>> GetAll();
        Task Insert(Jogador jogador);
    }
}
