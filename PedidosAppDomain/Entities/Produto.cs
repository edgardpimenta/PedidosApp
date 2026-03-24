using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Entities
{
    public class Produto
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [BsonElement("nome")]
        public string? Nome { get; set; }

        [BsonElement("preco")]
        public decimal Preco { get; set; }

        [BsonElement("itenspedido")]
        public List<ItemPedido>? ItensPedido { get; set; }
    }
}