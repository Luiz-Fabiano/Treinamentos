using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.EntityMySql
{
    public class Livro
    {
        public Livro()
        {
            Autores = new List<Autor>();
        }
        public int LivroId { get; set; }
        public string Nome { get; set; }
        public string ISBN { get; set; }

        public virtual ICollection<Autor> Autores { get; set; }
    }
}
