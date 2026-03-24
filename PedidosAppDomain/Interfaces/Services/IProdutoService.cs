using PedidosApp.Domain.Dtos.Responses;
using PedidosAppDomain.Dtos.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosAppDomain.Interfaces.Services
{
    public interface IProdutoService
    {
        public ProdutoResponse Criar(ProdutoRequest request);
        public ProdutoResponse ObterPorId(Guid Id);
    }
}
