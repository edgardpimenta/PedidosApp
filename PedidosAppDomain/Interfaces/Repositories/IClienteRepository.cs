using PedidosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Interfaces.Repositories
{
    public interface IClienteRepository : IBaseRepository<Cliente, Guid>
    {
        Cliente FindByCpf(string cpf);
    }
}