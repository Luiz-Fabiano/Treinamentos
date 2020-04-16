using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.LinqSQL
{
    class AdventureWorks : DataContext
    {
        public AdventureWorks(string connection) : base(connection) { }

        public Table<CodeFirst.ProductCategory> ProductCategories
        {
            get { return this.GetTable<CodeFirst.ProductCategory>(); }
        }

        public Table<CodeFirst.ProductSubcategory> ProductSubcategories
        {
            get { return this.GetTable<CodeFirst.ProductSubcategory>(); }
        }

        [Function(Name = "usp_GetCategory", IsComposable = false)]
        [ResultType(typeof(CodeFirst.ProductCategory))]
        [ResultType(typeof(CodeFirst.ProductSubcategory))]
        public IMultipleResults GetCategory(int resultType)
        {
            IExecuteResult executeResult = ExecuteMethodCall(this, (MethodInfo)(MethodInfo.GetCurrentMethod()), resultType);
            IMultipleResults result = (IMultipleResults)executeResult.ReturnValue;
            return result;
        }

        [Function(Name = "ufnFindProductSubcategoriesByName", IsComposable = true)]
        [ResultType(typeof(CodeFirst.ProductSubcategory))]
        public IQueryable<CodeFirst.ProductSubcategory> FindSubcategories([Parameter(Name = "name")] string category)
        {
            IExecuteResult executeResult = ExecuteMethodCall(this, (MethodInfo)(MethodInfo.GetCurrentMethod()), category);
            IQueryable<CodeFirst.ProductSubcategory> result = (IQueryable<CodeFirst.ProductSubcategory>)executeResult.ReturnValue;
            return result;
        }

        [Function(Name = "ufnGetMaxPriceBySubcategory", IsComposable = true)]
        public decimal? MaxPriceBySubcategory(int productSubcategoryID)
        {
            IExecuteResult executeResult = ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), productSubcategoryID);
            decimal? result = (decimal?)executeResult.ReturnValue;
            return result;
        }

    }
}
