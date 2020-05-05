﻿using System.ComponentModel.DataAnnotations;
using TreinaWeb.WebApi.Api.HATEOAS;

namespace TreinaWeb.WebApi.Api.DTOs
{
    public class AlunoDTO : RestResource
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "O nome do aluno é obrigatório")]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "O nome do aluno deve conter entre 2 e 20 caracteres.")]
        public string Nome { get; set; }

        [MaxLength(100, ErrorMessage = "O endereço deve conter até 100 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "A mensalidade do aluno é obrigatória.")]
        [Range(0.01, 9999.99, ErrorMessage = "A mensalidade deve estar entre R$ 0,01 e R$ 9999,99.")]
        public decimal Mensalidade { get; set; }
    }
}