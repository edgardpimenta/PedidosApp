using PedidosApp.Domain.Dtos.Requests;
using PedidosApp.Domain.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosAppDomain.Interfaces.Services
{
    public interface IPedidoService
    {
        public PedidoResponse Criar(PedidoRequest request);
        public List<PedidoResponse> ObterPorCliente(Guid ClienteId);

    }
}
