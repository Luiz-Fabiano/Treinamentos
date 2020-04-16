namespace TreinaWeb.EntityQuery
{
    public class Funcionarios
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        //public virtual Departamentos Departamento { get; set; }
        public Departamentos Departamento { get; set; }
    }
}
