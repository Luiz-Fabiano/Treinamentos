using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.EntitySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityConnection conn = new EntityConnection("name=AdventureWorksEntities");
            ObjectContext context = new ObjectContext(conn);

            //String EntitySQLCmd = "SELECT VALUE productCategory FROM AdventureWorksEntities.ProductCategory AS productCategory ";

            //String EntitySQLCmd = "SELECT VALUE prod FROM AdventureWorksEntities.ProductCategory AS prod "
            //               + " WHERE COUNT(SELECT VALUE DISTINCT(prodsub.ProductSubcategoryID) FROM prod.ProductSubcategory AS prodsub ) > 1 ";

            //ObjectQuery<ProductCategory> result = context.CreateQuery<ProductCategory>(EntitySQLCmd);

            //foreach (var item in result)
            //{
            //    Console.WriteLine("{0} - {1}", item.ProductCategoryID, item.Name);
            //}


            //String EntitySQLCmd = "SELECT prod.ProductCategoryID, prod.Name FROM AdventureWorksEntities.ProductCategory AS prod "
            //            + " WHERE COUNT(SELECT VALUE DISTINCT(prodsub.ProductSubcategoryID) FROM prod.ProductSubcategory AS prodsub ) > 1 ";

            //ObjectQuery<DbDataRecord> result = context.CreateQuery<DbDataRecord>(EntitySQLCmd);
            //foreach (var item in result)
            //{
            //    Console.WriteLine("{0} - {1}", item["ProductCategoryID"], item["Name"]);
            //}

            //String EntitySQLCmd = "SELECT prod.ProductCategoryID, prod.Name, subprod.Name As SubCategory  FROM AdventureWorksEntities.ProductCategory AS prod "
            //                + " JOIN AdventureWorksEntities.ProductSubCategory AS subprod ON subprod.ProductCategoryID = prod.ProductCategoryID "
            //                + " WHERE COUNT(SELECT VALUE DISTINCT(prodsub.ProductSubcategoryID) FROM prod.ProductSubcategory AS prodsub ) > 1 ";

            //ObjectQuery<DbDataRecord> result = context.CreateQuery<DbDataRecord>(EntitySQLCmd);

            //foreach (var item in result)
            //{
            //    Console.WriteLine("{0} - {1} - {2}", item["ProductCategoryID"], item["Name"], item["SubCategory"]);
            //}


            //using (AdventureWorksEntities dc = new AdventureWorksEntities())
            //{
            //    var result = dc.GetCategory(1);
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorksEntities dc = new AdventureWorksEntities())
            //{
            //    var result = dc.FindProductSubcategoriesByName("bike");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorksEntities dc = new AdventureWorksEntities())
            //{
            //    var result = dc.Database.SqlQuery<ProductSubcategory>("SELECT TOP(50)PERCENT ProductSubcategoryID, Name, rowguid, ModifiedDate, ProductCategoryID FROM Production.ProductSubcategory");
            //    Console.WriteLine("50% das subcategorias cadastradas:");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine("{0} - {1}", item.ProductSubcategoryID, item.Name);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorksEntities dc = new AdventureWorksEntities())
            //{
            //    var result = dc.Database.SqlQuery<ProductSubcategory>("EXEC usp_GetCategory {0}", 2);
            //    Console.WriteLine("Subcategorias cadastradas:");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine("{0} - {1}", item.ProductSubcategoryID, item.Name);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorksEntities dc = new AdventureWorksEntities())
            //{
            //    var result = from c in dc.ProductSubcategory
            //                 orderby c.Name
            //                 select new { ProductSubcategoryID = c.ProductSubcategoryID, Name = c.Name };

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var result = dc.ProductSubcategory.OrderBy(c => c.Name).Select(c => new { ProductSubcategoryID = c.ProductSubcategoryID, Name = c.Name });

            //    Console.WriteLine("Subcategorias cadastradas:");
            //    foreach (var item in result)
            //    {
            //        var maxPrice = dc.Database.SqlQuery<decimal>("SELECT dbo.ufnGetMaxPriceBySubcategory({0})", item.ProductSubcategoryID);
            //        Console.WriteLine("{0} - {1} - \t{2}", item.ProductSubcategoryID, item.Name, maxPrice.Single().ToString("C"));
            //    }

            //    Console.ReadKey();
            //}

            using (AdventureWorksEntities dc = new AdventureWorksEntities())
            {
                SqlParameter pName = new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50);
                pName.Value = "Books";

                SqlParameter pRowGuid = new SqlParameter("@rowguid", System.Data.SqlDbType.UniqueIdentifier);
                pRowGuid.Value = Guid.NewGuid();

                SqlParameter pModifiedDate = new SqlParameter("@ModifiedDate", System.Data.SqlDbType.DateTime);
                pModifiedDate.Value = DateTime.Now;

                var rowsAffected = dc.Database.ExecuteSqlCommand("INSERT INTO Production.ProductCategory VALUES (@Name, @rowguid, @ModifiedDate)", pName, pRowGuid, pModifiedDate);

                Console.WriteLine("Alteração realizada com sucesso, {0} linhas foram afetadas", rowsAffected);

                var result = from c in dc.ProductCategory
                             orderby c.Name
                             select new { ProductCategoryID = c.ProductCategoryID, Name = c.Name };

                //Em sintaxe de método ficaria da seguinte forma:
                //var result = dc.ProductCategory.OrderBy(c => c.Name).Select(c => new { ProductCategoryID = c.ProductCategoryID, Name = c.Name });


                Console.WriteLine("Categorias cadastradas:");
                foreach (var item in result)
                {
                    Console.WriteLine("{0} - {1}", item.ProductCategoryID, item.Name);
                }

                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
