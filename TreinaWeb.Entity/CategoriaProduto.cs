using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Entity
{
    [Table("ProductCategory", Schema = "Production")]
    class CategoriaProduto
    {
        public CategoriaProduto()
        {
            this.ProductSubcategories = new HashSet<SubCategoriaProduto>();
        }

        [Key]
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual ICollection<SubCategoriaProduto> ProductSubcategories { get; set; }
        

    }
}
