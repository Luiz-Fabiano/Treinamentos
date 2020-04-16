using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreinaWeb.Entity
{
    [Table("Funcionarios")]
    class Funcionario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int FuncionarioId { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public virtual Departamentos Departamento { get; set; }
    }
}
