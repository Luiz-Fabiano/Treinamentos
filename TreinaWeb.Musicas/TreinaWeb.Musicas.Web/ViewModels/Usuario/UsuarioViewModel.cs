using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreinaWeb.Musicas.Web.ViewModels.Usuario
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "O Email é obrigatório")]
        [MaxLength(30, ErrorMessage = "O Email não pode ter mais do que 30 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória")]
        [DataType(DataType.Password)]        
        public string Senha { get; set; }
    }
}