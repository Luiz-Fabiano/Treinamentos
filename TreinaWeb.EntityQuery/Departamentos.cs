using System.Collections.Generic;

namespace TreinaWeb.EntityQuery
{
    public class Departamentos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        //public virtual ICollection<Funcionarios> Funcionarios { get; set; }
        public ICollection<Funcionarios> Funcionarios { get; set; }
    }
}
