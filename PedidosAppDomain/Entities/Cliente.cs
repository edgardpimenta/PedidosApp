using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Entities
{
    public class Cliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [BsonElement("nome")]
        public string? Nome { get; set; }

        [BsonElement("cpf")]
        public string? Cpf { get; set; }

        [BsonElement("pedidos")]
        public List<Pedido>? Pedidos { get; set; }
    }
}
