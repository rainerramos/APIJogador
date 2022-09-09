using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ADN.Domain.Domain
{
    public class Jogador
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string Id { get; set; }
        public string Nome { get; set; }
        public int Altura { get; set; }
        public decimal Peso { get; set; }
        public string Posicao { get; set; }
    }
}
