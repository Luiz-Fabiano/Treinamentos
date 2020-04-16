using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.FluentAPI
{
    public class Destino
    {
        public int DestinoId { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Descricao { get; set; }

        public List<Hospedagem> Hospedagens { get; set; }
    }
}
