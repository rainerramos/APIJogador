using ADN.Domain.Domain;

namespace ADN.Domain.Interfaces.Repositorio
{
    public interface IJogadorRepositorio
    {
        Task<List<Jogador>> GetAll();
        
    }
}
