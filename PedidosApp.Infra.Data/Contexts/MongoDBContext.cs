using MongoDB.Driver;
using PedidosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Infra.Data.Contexts
{
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database;

        public MongoDBContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("bd-pedidos");
        }

        #region Mapear as collections do MongoDB

        public IMongoCollection<Cliente> Clientes => _database.GetCollection<Cliente>("clientes");

        public IMongoCollection<Produto> Produtos => _database.GetCollection<Produto>("produtos");

        public IMongoCollection<Pedido> Pedidos => _database.GetCollection<Pedido>("pedidos");

        public IMongoCollection<ItemPedido> ItensPedido => _database.GetCollection<ItemPedido>("itenspedido");

        #endregion
    }
}
