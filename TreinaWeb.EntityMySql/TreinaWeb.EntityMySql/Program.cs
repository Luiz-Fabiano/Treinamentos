using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.EntityMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                using (EntitiesMySQLContext dc = new EntitiesMySQLContext())
                {
                    Autor autor = new Autor()
                    {
                        Nome = "Bernard Cornwell"
                    };

                    dc.Autores.Add(autor);

                    Livro livro = new Livro()
                    {
                        Nome = "A fuga de Sharpe",
                        ISBN = "8501099430"
                    };

                    dc.Livros.Add(livro);

                    livro.Autores.Add(autor);
                    autor.Livros.Add(livro);

                    dc.SaveChanges();
                }
                using (EntitiesMySQLContext dc = new EntitiesMySQLContext())
                {
                    var result = from a in dc.Autores.Include("Livros")
                                 orderby a.Nome
                                 select a;

                    //Em sintaxe de método ficaria da seguinte forma:
                    //var result1 = dc.Autores.Include("Livros").OrderBy(a => a.Nome);


                    foreach (var item in result)
                    {
                        Console.WriteLine("Os livros do autor {0}", item.Nome);
                        foreach (var livro in item.Livros)
                        {
                            Console.WriteLine("{0} - {1}", livro.ISBN, livro.Nome);
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
