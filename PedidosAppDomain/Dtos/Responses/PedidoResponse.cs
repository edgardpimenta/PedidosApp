using PedidosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Dtos.Responses
{
    public class PedidoResponse
    {
        public Guid Id { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Valor { get; set; }
        public ClienteResponse? Cliente { get; set; }
    }
}