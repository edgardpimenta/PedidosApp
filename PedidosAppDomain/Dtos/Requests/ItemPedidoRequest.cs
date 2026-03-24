using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PedidosApp.Domain.Dtos.Requests
{
    public class ItemPedidoRequest
    {
        [Required(ErrorMessage = "Por favor, informe o id do pedido.")]
        public Guid? PedidoId { get; set; }

        [Required(ErrorMessage = "Por favor, informe o id do produto.")]
        public Guid? ProdutoId { get; set; }

        [Required(ErrorMessage = "Por favor, informe a quantidade.")]
        public int? Quantidade { get; set; }
    }
}