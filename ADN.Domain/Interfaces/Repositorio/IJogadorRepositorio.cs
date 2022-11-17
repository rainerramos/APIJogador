using ADN.Domain.Domain;

namespace ADN.Domain.Interfaces.Repositorio
{
    public interface IJogadorRepositorio
    {
        Task<Jogador> GetById(string id);
        Task<List<Jogador>> GetAll();
        Task Insert(Jogador jogador);
        Task Delete(Jogador jogador);
    }
}
