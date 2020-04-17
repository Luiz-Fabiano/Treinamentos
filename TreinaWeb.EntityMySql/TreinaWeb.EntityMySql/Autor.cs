using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.EntityMySql
{
    public class Autor
    {
        public Autor()
        {
            Livros = new List<Livro>();
        }
        public int AutorId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
