using PedidosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Interfaces.Repositories
{
    public interface IPedidoRepository : IBaseRepository<Pedido, Guid>
    {
        List<Pedido> FindByCliente(Guid clienteId);
    }
}