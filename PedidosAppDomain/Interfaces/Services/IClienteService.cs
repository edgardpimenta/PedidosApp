using PedidosApp.Domain.Dtos.Responses;
using PedidosAppDomain.Dtos.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosAppDomain.Interfaces.Services
{
    public interface IClienteService
    {
        public ClienteResponse Criar(ClienteRequest request);
        public ClienteResponse ObterPorCpf(ClienteRequest request);

    }
}
