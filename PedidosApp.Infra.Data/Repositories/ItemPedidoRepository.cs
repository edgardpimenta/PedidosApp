using PedidosApp.Domain.Entities;
using PedidosApp.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Infra.Data.Repositories
{
    public class ItemPedidoRepository : IBaseRepository<ItemPedido, Guid>
    {
        public void Add(ItemPedido entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ItemPedido> FindAll()
        {
            throw new NotImplementedException();
        }

        public ItemPedido? FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(ItemPedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
