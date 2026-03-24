using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Dtos.Responses
{
    public class ClienteResponse
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
    }
}