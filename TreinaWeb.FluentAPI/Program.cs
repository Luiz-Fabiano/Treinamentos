using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.FluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BancoCodeFirst dc = new BancoCodeFirst())
            {
                var destinos = dc.Destinos.Include("Hospedagens");

                foreach (var item in destinos)
                {
                    Console.WriteLine("Hospedagens do destino {0} em {1}", item.Nome, item.Pais);
                    foreach (var hospedagem in item.Hospedagens)
                    {
                        Console.WriteLine("{0}\nDono:{1}", hospedagem.Nome, hospedagem.Dono);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
