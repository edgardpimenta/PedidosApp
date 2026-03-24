using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Entities
{
    public class Pedido
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [BsonElement("datahora")]
        public DateTime DataHora { get; set; } = DateTime.Now;

        [BsonElement("valor")]
        public decimal Valor { get; set; }

        [BsonElement("cliente")]
        public Cliente? Cliente { get; set; }

        [BsonElement("itenspedido")]
        public List<ItemPedido>? ItensPedido { get; set; }
    }
}