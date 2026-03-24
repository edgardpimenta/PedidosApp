using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Dtos.Responses
{
    public class ItemPedidoResponse
    {
        public PedidoResponse? Pedido { get; set; }
        public ProdutoResponse? Produto { get; set; }
        public int Quantidade { get; set; }
    }
}