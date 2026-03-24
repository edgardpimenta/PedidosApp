using PedidosApp.Domain.Entities;
using PedidosApp.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Infra.Data.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        public void Add(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<Pedido> FindByCliente(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Pedido? FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Pedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
