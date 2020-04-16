using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.LinqSQL
{
    class Program
    {
        private static AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();
        static void Main(string[] args)
        {
            #region 1º Código 
            //AdventureWorks dc = new AdventureWorks(@"Data Source=NOTE-FABIANO\SQLDEVELOPER;Initial Catalog=AdventureWorks;Integrated Security=SSPI");

            //var result = from pc in dc.ProductCategories
            //             orderby pc.Name
            //             select pc;

            ////Em sintaxe de método ficaria da seguinte forma:
            ////var result = dc.ProductCategories.OrderBy(pc => pc.Name);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Console.ReadKey();
            #endregion

            #region 2º Código 
            //var result = from pc in dc.ProductCategories
            //             orderby pc.Name
            //             select new { Nome = pc.Name, SubCategorias = pc.ProductSubcategories };

            ////Em sintaxe de método ficaria da seguinte forma:
            ////var result = dc.ProductCategories.OrderBy(pc => pc.Name).Select(pc => new {Nome = pc.Name, SubCategorias = pc.ProductSubcategories });

            //foreach (var item in result)
            //{
            //    Console.WriteLine("******************************");
            //    Console.WriteLine("Subcategorias de {0}:", item.Nome);
            //    foreach (var sub in item.SubCategorias)
            //    {
            //        Console.WriteLine("{0}", sub.Name);
            //    }
            //    Console.WriteLine("******************************");
            //    Console.WriteLine("");
            //}

            //Console.ReadKey();
            #endregion

            #region 3º Código 
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();

            //dc.Log = Console.Out;

            //var result = from pc in dc.ProductCategories
            //             orderby pc.Name
            //             select pc;

            ////Em sintaxe de método ficaria da seguinte forma:
            ////var result = dc.ProductCategories.OrderBy(pc => pc.Name);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Console.ReadKey();
            #endregion

            #region 4º Código 
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();

            //dc.Log = Console.Out;

            //var result = from pc in dc.ProductCategories
            //             orderby pc.Name
            //             select pc;

            ////Em sintaxe de método ficaria da seguinte forma:
            ////var result = dc.ProductCategories.OrderBy(pc => pc.Name);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //    // Exibo quantas SubCategorias estão associadas
            //    Console.WriteLine(item.ProductSubcategories.Count());
            //}

            //Console.ReadKey();
            #endregion

            #region 5º Código 
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();

            //dc.Log = Console.Out;

            //DataLoadOptions options = new DataLoadOptions();
            //options.LoadWith<ProductCategory>(pc => pc.ProductSubcategories);
            //dc.LoadOptions = options;

            //var result = from pc in dc.ProductCategories
            //             orderby pc.Name
            //             select pc;

            ////Em sintaxe de método ficaria da seguinte forma:
            ////var result = dc.ProductCategories.OrderBy(pc => pc.Name);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //    // Exibo quantas SubCategorias estão associadas
            //    Console.WriteLine(item.ProductSubcategories.Count());
            //}

            //Console.ReadKey();
            #endregion

            #region 6º Código 
            //dc.DeferredLoadingEnabled = false;
            //int op = 1;
            //while (op != 0)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Dentre as alternativas abaixo:");
            //    Console.WriteLine("1 - Consultar");
            //    Console.WriteLine("2 - Incluir");
            //    Console.WriteLine("3 - Alterar");
            //    Console.WriteLine("4 - Excluir");
            //    Console.WriteLine("5 - Incluir Valor nulo");
            //    Console.WriteLine("6 - Efetivar alterações no banco");
            //    Console.WriteLine("0 - Sair");
            //    Console.WriteLine("Selecione uma opcao:");
            //    if (!Int32.TryParse(Console.ReadLine().ToString(), out op))
            //        op = -1;

            //    switch (op)
            //    {
            //        case 1:
            //            RealizarConsulta();
            //            break;
            //        case 2:
            //            RealizarInclusao();
            //            break;
            //        case 3:
            //            RealizarAlteracao();
            //            break;
            //        case 4:
            //            RealizarExclusao();
            //            break;
            //        case 5:
            //            RealizarInclusaoNula();
            //            break;
            //        case 6:
            //            EfetivarAlteracoes();
            //            break;
            //        case 0:
            //            Console.WriteLine("Bye!");
            //            break;
            //        default:
            //            Console.WriteLine("Opcao invalida!\n\n");
            //            Console.ReadKey();
            //            break;
            //    }
            //}
            #endregion

            #region 7º Código 
            //AdventureWorks dc = new AdventureWorks(@"Data Source=NOTE-FABIANO\SQLDEVELOPER;Initial Catalog=AdventureWorks;Integrated Security=SSPI");
            //IMultipleResults result = dc.GetCategory(1);
            //Console.WriteLine("Categorias:");
            //foreach (var item in result.GetResult<CodeFirst.ProductCategory>())
            //{
            //    Console.WriteLine("{0} - {1}", item.ProductCategoryID, item.Name);
            //}
            //Console.ReadKey();
            #endregion

            #region 8º Código 
            //AdventureWorks dc = new AdventureWorks(@"Data Source=NOTE-FABIANO\SQLDEVELOPER;Initial Catalog=AdventureWorks;Integrated Security=SSPI");
            //IMultipleResults result = dc.GetCategory(2);
            //Console.WriteLine("Categorias:");
            //foreach (var item in result.GetResult<CodeFirst.ProductSubcategory>())
            //{
            //    Console.WriteLine("{0} - {1}", item.ProductSubcategoryID, item.Name);
            //}
            //Console.ReadKey();
            #endregion

            #region 9º Código 
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();
            //var result = from pc in dc.usp_GetCategory(1)
            //             orderby pc.Name
            //             select pc;

            ////Em sintaxe de método ficaria da seguinte forma:
            ////var result = dc.usp_GetCategory(1).OrderBy(pc => pc.Name);

            //Console.WriteLine("Categorias:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine("{0} - {1}", item.ProductCategoryID, item.Name);
            //}
            //Console.ReadKey();
            #endregion

            #region 10º Código 
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();
            //var result = from pc in dc.usp_GetCategory(2)
            //             orderby pc.Name
            //             select pc;

            ////Em sintaxe de método ficaria da seguinte forma:
            ////var result = dc.usp_GetCategory(2).OrderBy(pc => pc.Name);

            //Console.WriteLine("Categorias:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine("{0} - {1}", item.ProductCategoryID, item.Name);
            //}
            //Console.ReadKey();
            #endregion

            #region 11º Código
            //try
            //{
            //    AdventureWorks dc = new AdventureWorks(@"Data Source=NOTE-FABIANO\SQLDEVELOPER;Initial Catalog=AdventureWorks;Integrated Security=SSPI");

            //    var result = from p in dc.FindSubcategories("bike")
            //                 orderby p.Name descending
            //                 select new { p.Name, p.ProductSubcategoryID, MaxPrice = dc.MaxPriceBySubcategory(p.ProductSubcategoryID) };

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var result = dc.FindSubcategories("bike").OrderByDescending(pc => pc.Name).Select(p => new { p.Name, p.ProductSubcategoryID, MaxPrice = dc.MaxPriceBySubcategory(p.ProductSubcategoryID) });

            //    Console.WriteLine("Subcategorias com bike no nome:");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine("{0} - {1} - {2}", item.ProductSubcategoryID, item.Name, item.MaxPrice.GetValueOrDefault(0).ToString("C"));
            //    }
            //    Console.ReadKey();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}            
            #endregion

            #region 12º Código
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();
            //var result = from pc in dc.FindProductSubcategoriesByName("Shorts")
            //             orderby pc.Name
            //             select new { pc.Name, pc.ProductSubcategoryID, MaxPrice = dc.GetMaxPriceBySubcategory(pc.ProductSubcategoryID) };

            ////Em sintaxe de método ficaria da seguinte forma:
            ////var result = dc.FindProductSubcategoriesByName("Shorts").OrderByDescending(pc => pc.Name).Select(p => new { p.Name, p.ProductSubcategoryID, MaxPrice = dc.GetMaxPriceBySubcategory(p.ProductSubcategoryID) });

            //Console.WriteLine("Subcategorias com shorts no nome:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine("{0} - {1} - {2}", item.ProductSubcategoryID, item.Name, item.MaxPrice.GetValueOrDefault(0).ToString("C"));
            //}
            //Console.ReadKey();
            #endregion

            #region 13º Código
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();
            //Table<ProductSubcategory> ProductSubcategories = dc.GetTable<ProductSubcategory>();

            //var query = CompiledQuery.Compile(
            //                    (DataContext context, string filterName) =>
            //                    from p in ProductSubcategories
            //                    where p.Name.Contains(filterName)
            //                    select new { p.Name, p.ProductSubcategoryID });

            //Console.WriteLine("Subcategorias com Bike no nome:");
            //foreach (var item in query(dc, "Bike"))
            //{
            //    Console.WriteLine("{0} - {1}", item.ProductSubcategoryID, item.Name);
            //}

            //Console.WriteLine("\n\nSubcategorias com Shorts no nome:");
            //foreach (var item in query(dc, "Shorts"))
            //{
            //    Console.WriteLine("{0} - {1}", item.ProductSubcategoryID, item.Name);
            //}
            //Console.ReadKey();
            #endregion

            #region 14º Código
            AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();

            var result = dc.ExecuteQuery<ProductSubcategory>(@"SELECT TOP(50)PERCENT ProductSubcategoryID, Name, rowguid, ModifiedDate FROM Production.ProductSubcategory");

            Console.WriteLine("50% das subcategorias cadastradas:");
            foreach (var item in result)
            {
                Console.WriteLine("{0} - {1}", item.ProductSubcategoryID, item.Name);
            }

            Console.ReadKey();
            #endregion
        }

        static void RealizarInclusao()
        {
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();
            string categoria;

            Console.WriteLine("Informe uma categoria:");
            categoria = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(categoria))
            {
                ProductCategory pc = new ProductCategory();
                pc.Name = categoria;
                pc.rowguid = Guid.NewGuid();
                pc.ModifiedDate = DateTime.Now;

                dc.ProductCategories.InsertOnSubmit(pc);
                //dc.SubmitChanges();

                Console.WriteLine("O registro {0}, incluído com sucesso\n", pc.ProductCategoryID);
            }
        }

        static void RealizarConsulta()
        {
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();

            var result = from pc in dc.ProductCategories
                         orderby pc.Name
                         select pc;

            //Em sintaxe de método ficaria da seguinte forma:
            //var result = dc.ProductCategories.OrderBy(pc => pc.Name);

            Console.WriteLine("Categorias:");
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void RealizarAlteracao()
        {
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();
            string categoria;
            int id;

            Console.Clear();
            Console.Write("Informe o id categoria que será alterada:");
            if (Int32.TryParse(Console.ReadLine(), out id))
            {
                ProductCategory pc = dc.ProductCategories.Single(p => p.ProductCategoryID == id);

                //Em sintaxe de pesquisa ficaria da seguinte forma:
                //
                //ProductCategory pc2 = (from p in dc.ProductCategories
                //                       where p.ProductCategoryID == id
                //                       select p).Single();

                Console.WriteLine("\n\nInforme um novo nome para a categoria {0}:", pc.Name);
                categoria = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(categoria))
                {
                    pc.Name = categoria;
                    pc.ModifiedDate = DateTime.Now;

                    //dc.SubmitChanges();

                    Console.WriteLine("O registro {0}, alterado com sucesso\n", pc.ProductCategoryID);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void RealizarExclusao()
        {
            //AdventureWorksByToolDataContext dc = new AdventureWorksByToolDataContext();
            int id;

            Console.Clear();
            Console.Write("Informe o id categoria que será excluida:");
            if (Int32.TryParse(Console.ReadLine(), out id))
            {
                ProductCategory pc = dc.ProductCategories.Single(p => p.ProductCategoryID == id);

                //Em sintaxe de pesquisa ficaria da seguinte forma:
                //
                //ProductCategory pc2 = (from p in dc.ProductCategories
                //                       where p.ProductCategoryID == id
                //                       select p).Single();

                dc.ProductCategories.DeleteOnSubmit(pc);
                //dc.SubmitChanges();

                Console.WriteLine("Registro excluído com sucesso\n");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void RealizarInclusaoNula()
        {
            Console.Clear();
            ProductCategory pc = new ProductCategory();
            //pc.Nome não é informado
            pc.rowguid = Guid.NewGuid();
            pc.ModifiedDate = DateTime.Now;

            dc.ProductCategories.InsertOnSubmit(pc);

            Console.WriteLine("O registro nulo, incluido com sucesso da memória\n");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void EfetivarAlteracoes()
        {
            dc.Connection.Open();
            using (dc.Transaction = dc.Connection.BeginTransaction())
            {
                try
                {
                    dc.SubmitChanges();
                    dc.Transaction.Commit();
                    Console.WriteLine("Dados salvos no banco!");
                }
                catch (Exception ex)
                {
                    dc.Transaction.Rollback();
                    Console.WriteLine("Ocorreu o seguinte erro:");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
