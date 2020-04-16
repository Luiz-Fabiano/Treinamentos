using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.FluentAPI
{
    public class Hospedagem
    {
        public int HospedagemId { get; set; }
        public string Nome { get; set; }
        public string Dono { get; set; }
        public bool IsResort { get; set; }

        public Destino Destino { get; set; }
    }
}
