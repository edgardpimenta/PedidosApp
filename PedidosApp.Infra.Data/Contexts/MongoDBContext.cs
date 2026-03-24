using MongoDB.Driver;
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

        #endregion
    }
}
