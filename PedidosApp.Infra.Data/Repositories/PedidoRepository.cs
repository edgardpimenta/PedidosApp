using MongoDB.Driver;
using PedidosApp.Domain.Entities;
using PedidosApp.Domain.Interfaces.Repositories;
using PedidosApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;

namespace PedidosApp.Infra.Data.Repositories
{
    public class PedidoRepository : IBaseRepository<Pedido, Guid>
    {
        private readonly IMongoCollection<Pedido> _pedidos;

        public PedidoRepository(MongoDBContext context)
        {
            _pedidos = context.Pedidos;
        }

        public void Add(Pedido entity)
        {
            _pedidos.InsertOne(entity);
        }

        public void Delete(Guid id)
        {
            var filter = Builders<Pedido>.Filter.Eq(p => p.Id, id);
            _pedidos.DeleteOne(filter);
        }

        public List<Pedido> FindAll()
        {
            return _pedidos.Find(_ => true).ToList();
        }

        public Pedido? FindById(Guid id)
        {
            var filter = Builders<Pedido>.Filter.Eq(p => p.Id, id);
            return _pedidos.Find(filter).FirstOrDefault();
        }

        public void Update(Pedido entity)
        {
            var filter = Builders<Pedido>.Filter.Eq(p => p.Id, entity.Id);
            _pedidos.ReplaceOne(filter, entity);
        }
    }
}