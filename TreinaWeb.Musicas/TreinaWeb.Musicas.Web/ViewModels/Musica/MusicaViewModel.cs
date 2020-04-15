using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreinaWeb.Musicas.Web.ViewModels.Musica
{
    public class MusicaViewModel
    {
        [Required(ErrorMessage = "O ID é obrigatório")]
        public int ID { get; set; }

        [Required(ErrorMessage = "O nome da música é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome da música pode ter no máximo 50 caracteres")]
        [Display(Name = "Nome da Música")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Selecione um álbum válido")]
        [Display(Name = "Álbum")]
        public string IDAlbum { get; set; }
    }
}