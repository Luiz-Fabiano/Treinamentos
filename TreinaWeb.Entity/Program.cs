using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mapeamento manual
            //Console.WriteLine("Categorias por ferramenta!");
            //using (AdventureWorksEntities dc = new AdventureWorksEntities())
            //{
            //    foreach (var item in dc.ProductCategory)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}

            //Console.ReadKey();
            #endregion

            #region Mapeamento por código 
            //Console.WriteLine("Categorias por código!");
            //using (BancoContext dc = new BancoContext())
            //{
            //    foreach (var item in dc.Categorias)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}

            //Console.ReadKey();
            #endregion

            Console.WriteLine("Funcionarios:");
            using (TreinamentoEntity dc = new TreinamentoEntity())
            {
                foreach (var item in dc.Funcionarios.Include("Departamento"))
                {
                    Console.WriteLine("Funcionário: {0}, Departamento: {1}", item.Nome, item.Departamento.Nome);
                }
            }
            Console.ReadKey();
        }
    }
}
