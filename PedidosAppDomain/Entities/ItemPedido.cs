using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Entities
{
    public class ItemPedido
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid PedidoId { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid ProdutoId { get; set; }

        [BsonElement("quantidade")]
        public int Quantidade { get; set; }

        [BsonElement("pedido")]
        public Pedido? Pedido { get; set; }

        [BsonElement("produto")]
        public Produto? Produto { get; set; }
    }
}
