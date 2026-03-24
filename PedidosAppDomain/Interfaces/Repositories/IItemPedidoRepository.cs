using PedidosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Interfaces.Repositories
{
    public interface IItemPedidoRepository : IBaseRepository<ItemPedido, Guid>
    {
        List<ItemPedido> FindByPedido(Guid pedidoId);
    }
}