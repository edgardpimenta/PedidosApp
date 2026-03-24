using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PedidosAppDomain.Dtos.Requests
{
    public class ClienteRequest
    {
        [MinLength(6, ErrorMessage = "Informe o nome do cliente com pelo menos {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do cliente.")]
        public  string ? Nome { get; set; }


        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Informe o CPF com exatamente 11 números.")]
        [Required(ErrorMessage = "Por favor, informe o cpf do cliente.")]
        public string ? Cpf { get; set; }
    }
}
