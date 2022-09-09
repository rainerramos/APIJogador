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

        public async Task<List<Jogador>> GetAll()   
        {
            var result = await _collection.FindAsync(c => true);
            return result.ToList();
        }

        public async Task Insert(Jogador jogador)
        {
            await _collection.InsertOneAsync(jogador);
        }
    }
}
