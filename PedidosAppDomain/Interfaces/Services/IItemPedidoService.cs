using PedidosApp.Domain.Dtos.Requests;
using PedidosApp.Domain.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosAppDomain.Interfaces.Services
{
    public interface IItemPedidoService
    {
        public ItemPedidoResponse Criar(ItemPedidoRequest request);
        public List<ItemPedidoResponse> ObterPorPedido(ItemPedidoRequest request);
    }
}
