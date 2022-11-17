using ADN.Domain.Domain;
using ADN.Domain.DTO.Settings;
using ADN.Domain.Interfaces.Repositorio;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ADN.Data.Repositorio
{
    public class JogadorRepositorio : IJogadorRepositorio
    {
        private readonly IMongoCollection<Jogador> _collection;

        public JogadorRepositorio(IOptions<MongoDBJogadorSettings> mongoJogadorSettings)
        {
            var mongoClient = new MongoClient(mongoJogadorSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoJogadorSettings.Value.DatabaseName);
            _collection = mongoDatabase.GetCollection<Jogador>(mongoJogadorSettings.Value.CollectionName);
        }
        
        public async Task<List<Jogador>> GetAll() => await _collection.Find(c => true).ToListAsync();

        public async Task<Jogador> GetById(string id)
        {
            var retorno = await _collection.FindAsync(c => c.Id == id);
            return retorno.ToList().FirstOrDefault();
        }
        public async Task Insert(Jogador jogador) => await _collection.InsertOneAsync(jogador);

        public async Task Delete(Jogador jogador) => await _collection.DeleteOneAsync(x => x.Id == jogador.Id);                
    }
}
