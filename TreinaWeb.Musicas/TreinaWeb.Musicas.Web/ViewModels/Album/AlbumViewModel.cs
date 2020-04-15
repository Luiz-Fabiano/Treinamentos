using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TreinaWeb.Musicas.Web.Annotations;

namespace TreinaWeb.Musicas.Web.ViewModels.Album
{
    public class AlbumViewModel
    {
        [Required(ErrorMessage = "O ID do álbum é obrigatório")]
        public int ID { get; set; }

        [Display(Name = "Nome do álbum")]
        [Required(ErrorMessage = "O nome do álbum é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do álbum poderá ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Ano do álbum")]
        [Required(ErrorMessage = "O nome do álbum é obrigatório")]
        public int Ano { get; set; }

        [Display(Name = "Observações")]
        [Required(ErrorMessage = "As observações do álbum é obrigatório")]
        [MaxLength(1000, ErrorMessage = "As observações do álbum poderá ter no máximo 1000 caracteres")]
        public string Observacoes { get; set; }

        [Display(Name = "E-mail de contato")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O e-mail de contato é obrigatório")]
        [MaxLength(50, ErrorMessage = "O e-mail de contato poderá ter no máximo 50 caracteres")]
        [EmailTreinaWeb (ErrorMessage = "O e-mail tem que ser @treinaweb")]
        public string Email { get; set; }
    }
}