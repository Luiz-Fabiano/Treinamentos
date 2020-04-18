using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.AppEntity.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
