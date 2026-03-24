using MongoDB.Driver;
using PedidosApp.Domain.Entities;
using PedidosApp.Domain.Interfaces.Repositories;
using PedidosApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IMongoCollection<Cliente> _clientes;

        public ClienteRepository(MongoDBContext context)
        {
            _clientes = context.Clientes;
        }

        public void Add(Cliente entity)
        {
            _clientes.InsertOne(entity);
        }

        public void Delete(Guid id)
        {
            var filter = Builders<Cliente>.Filter.Eq(c => c.Id, id);
            _clientes.DeleteOne(filter);
        }

        public List<Cliente> FindAll()
        {
            return _clientes.Find(_ => true).ToList();
        }

        public Cliente FindByCpf(string cpf)
        {
            var filter = Builders<Cliente>.Filter.Eq(c => c.Cpf, cpf);
            return _clientes.Find(filter).FirstOrDefault();
        }

        public Cliente? FindById(Guid id)
        {
            var filter = Builders<Cliente>.Filter.Eq(c => c.Id, id);
            return _clientes.Find(filter).FirstOrDefault();
        }

        public void Update(Cliente entity)
        {
            var filter = Builders<Cliente>.Filter.Eq(c => c.Id, entity.Id);
            _clientes.ReplaceOne(filter, entity);
        }
    }
}
