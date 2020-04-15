using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Musicas.Dominio
{
    public class Musica
    {
        public long ID { get; set; }
        public string Nome { get; set; }

        public virtual Album Album { get; set; }
        public int IDAlbum { get; set; }
    }
}
