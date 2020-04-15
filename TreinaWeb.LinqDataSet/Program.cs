using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace TreinaWeb.LinqDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarregaDadosDataSet();
            //CarregaDadosDataSetTipado();
            PopularObjetos();
        }

        static DataSet PopularDataSet()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=NOTE-FABIANO\SQLDEVELOPER;Initial Catalog=AdventureWorks;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Production.Product";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds, "Product");

            return ds;
        }

        static void CarregaDadosDataSet()
        {
            DataSet dsAdventure = PopularDataSet();
            DataTable dtProduto = dsAdventure.Tables["Product"];

            IEnumerable<DataRow> produtos =
                from p in dtProduto.AsEnumerable()
                where p.Field<string>("Color") == "Black"
                orderby p.Field<string>("Name") descending
                select p;

            //Em sintaxe de método ficaria da seguinte forma:
            //IEnumerable<DataRow> produtos = dtProduto.AsEnumerable().Where(p => p.Field<string>("Color") == "Black").OrderByDescending(p => p.Field<string>("Name"));

            foreach (DataRow dr in produtos)
            {
                Console.WriteLine("{0} \t- {1}", dr["ProductNumber"], dr["Name"]);
            }
            Console.ReadKey();
        }

        static dsAdventure PopularDataSetTipado()
        {
            dsAdventureTableAdapters.ProductTableAdapter da = new dsAdventureTableAdapters.ProductTableAdapter();

            dsAdventure ds = new dsAdventure();

            da.Fill(ds.Product);
            return ds;
        }

        static void CarregaDadosDataSetTipado()
        {
            dsAdventure dsAdventure = PopularDataSetTipado();
            dsAdventure.ProductDataTable dtProduto = dsAdventure.Product;

            IEnumerable<dsAdventure.ProductRow> produtos =
                from p in dtProduto.AsEnumerable()
                where !p.IsColorNull() && p.Color == "Black"
                orderby p.Name descending
                select p;

            //Em sintaxe de método ficaria da seguinte forma:
            //IEnumerable<DataRow> produtos = dtProduto.AsEnumerable().Where(p => !p.IsColorNull() && p.Color == "Black").OrderByDescending(p => p.Name));

            foreach (dsAdventure.ProductRow dr in produtos)
            {
                Console.WriteLine("{0} \t- {1}", dr.ProductNumber, dr.Name);
            }

            Console.ReadKey();
        }

        static void PopularObjetos()
        {
            dsAdventure dsAdventure = PopularDataSetTipado();
            dsAdventure.ProductDataTable dtProduto = dsAdventure.Product;

            List<Produto> produtos =
                (from p in dtProduto.AsEnumerable()
                 where !p.IsColorNull() && p.Color == "Black"
                 orderby p.Name descending
                 select new Produto
                 {
                     Id = p.ProductID,
                     Nome = p.Name,
                     Numero = p.ProductNumber
                 }).ToList();

            //Em sintaxe de método ficaria da seguinte forma:
            //List<Produto> produtos = dtProduto.AsEnumerable()
            //                                .Where(p => !p.IsColorNull() && p.Color == "Black")
            //                                .OrderByDescending(p => p.Field<string>("Name"))
            //                                .Select(p => new Produto
            //                                {
            //                                    Id = p.ProductID,
            //                                    Nome = p.Name,
            //                                    Numero = p.ProductNumber
            //                                }).ToList();

            foreach (Produto p in produtos)
            {
                Console.WriteLine("{0} \t- {1}", p.Numero, p.Nome);
            }

            Console.ReadKey();
        }
    }
}
