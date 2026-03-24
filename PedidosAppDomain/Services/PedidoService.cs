using PedidosApp.Domain.Dtos.Requests;
using PedidosApp.Domain.Dtos.Responses;
using PedidosAppDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosAppDomain.Services
{
    public class PedidoService : IPedidoService
    {
        public PedidoResponse Criar(PedidoRequest request)
        {
            throw new NotImplementedException();
        }

        public List<PedidoResponse> ObterPorCliente(Guid ClienteId)
        {
            throw new NotImplementedException();
        }
    }
}
