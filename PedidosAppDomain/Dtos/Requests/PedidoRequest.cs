using PedidosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PedidosApp.Domain.Dtos.Requests
{
    public class PedidoRequest
    {
        [Required(ErrorMessage = "Por favor, informe a data e hora do pedido.")]
        public DateTime? DataHora { get; set; }

        [Required(ErrorMessage = "Por favor, informe o valor do pedido.")]
        public decimal? Valor { get; set; }

        [Required(ErrorMessage = "Por favor, informe o cliente do pedido.")]
        public Guid? ClienteId { get; set; }
    }
}