using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreinaWeb.Musicas.Web.ViewModels.Album
{
    public class AlbumExibicaoViewModel
    {
        public int ID { get; set; }

        [Display(Name = "Nome do álbum")]
        public string Nome { get; set; }

        [Display(Name = "Ano do álbum")]
        public int Ano { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        [Display(Name = "E-mail de contato")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}