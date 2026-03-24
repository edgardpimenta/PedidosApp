using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PedidosAppDomain.Dtos.Requests
{
    public class ProdutoRequest
    {
        [MinLength(6, ErrorMessage = "Informe o nome do produto com pelo menos {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do Produto.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do Preço do Produto.")]
        public decimal Preco { get; set; }
    }
}
