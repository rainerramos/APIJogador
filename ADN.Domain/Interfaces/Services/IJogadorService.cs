using ADN.Domain.Domain;
using ADN.Domain.DTO.Jogador;

namespace ADN.Domain.Interfaces.Services
{
    public interface IJogadorService
    {
        Task<Jogador> GetById (string id); 
        Task<List<Jogador>> GetAll();
        Task Insert(JogadorInsertDTO jogadorDTO);
        Task Delete(string id);
    }
}
