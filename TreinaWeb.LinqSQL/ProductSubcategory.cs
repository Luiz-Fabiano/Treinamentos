using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace TreinaWeb.LinqSQL.CodeFirst
{
    [Table(Name = "Production.ProductSubcategory")]
    class ProductSubcategory
    {
        [Column(IsPrimaryKey = true)]
        public int ProductSubcategoryID { get; set; }

        [Column]
        public int ProductCategoryID { get; set; }

        [Column]
        public string Name { get; set; }

        [Column(Name = "rowguid")]
        public Guid guid { get; set; }

        [Column]
        public DateTime ModifiedDate { get; set; }

        private EntityRef<ProductCategory> _ProductCategory;

        [Association(Storage = "_ProductCategory", ThisKey = "ProductCategoryID", IsForeignKey = true)]
        public ProductCategory ProductCategory
        {
            get { return this._ProductCategory.Entity; }
            set { this._ProductCategory.Entity = value; }
        }
    }
}
