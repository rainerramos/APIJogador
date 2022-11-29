using ADN.Domain.Domain;

namespace ADN.Domain.Interfaces.Services
{
    public interface ITimeService
    {
        Task<List<Time>> GetAll();
        Task<Time> GetById(int id);
        Task Insert(Time time);
        Task Delete(Time time);
    }
}
