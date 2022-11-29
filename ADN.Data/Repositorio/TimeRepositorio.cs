using ADN.Domain.Domain;
using ADN.Domain.Interfaces.Repositorio;

namespace ADN.Data.Repositorio
{
    public class TimeRepositorio : ITimeRepositorio
    {
        public Task Delete(Time time)
        {
            throw new NotImplementedException();
        }

        public Task<List<Time>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Time> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Time time)
        {
            throw new NotImplementedException();
        }
    }
}
