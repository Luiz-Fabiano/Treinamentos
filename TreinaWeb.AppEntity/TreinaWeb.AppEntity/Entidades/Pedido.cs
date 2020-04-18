using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.AppEntity.Entidades
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string NrPedido { get; set; }
        public DateTime Data { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
