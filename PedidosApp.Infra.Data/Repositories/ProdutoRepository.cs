using MongoDB.Driver;
using PedidosApp.Domain.Entities;
using PedidosApp.Domain.Interfaces.Repositories;
using PedidosApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;

namespace PedidosApp.Infra.Data.Repositories
{
    public class ProdutoRepository : IBaseRepository<Produto, Guid>
    {
        private readonly IMongoCollection<Produto> _produtos;

        public ProdutoRepository(MongoDBContext context)
        {
            _produtos = context.Produtos;
        }

        public void Add(Produto entity)
        {
            _produtos.InsertOne(entity);
        }

        public void Delete(Guid id)
        {
            var filter = Builders<Produto>.Filter.Eq(p => p.Id, id);
            _produtos.DeleteOne(filter);
        }

        public List<Produto> FindAll()
        {
            return _produtos.Find(_ => true).ToList();
        }

        public Produto? FindById(Guid id)
        {
            var filter = Builders<Produto>.Filter.Eq(p => p.Id, id);
            return _produtos.Find(filter).FirstOrDefault();
        }

        public void Update(Produto entity)
        {
            var filter = Builders<Produto>.Filter.Eq(p => p.Id, entity.Id);
            _produtos.ReplaceOne(filter, entity);
        }
    }
}