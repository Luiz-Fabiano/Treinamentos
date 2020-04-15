using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. Obter a fonte de dados
            //int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //// 2. Criar a Consulta
            //var query = from num in numeros
            //                //where (num % 2) == 0
            //                //where (num % 2) == 0 && (num % 4) == 0
            //            where (num % 2) == 0 || (num % 3) == 0
            //            orderby num descending
            //            select num;

            //// 3. Executar a consulta
            //foreach (int item in query)
            //{
            //    Console.WriteLine(item);
            //}

            //// Para a execução para visualizar o resultado
            //Console.ReadKey();


            //Dictionary<string, int> pessoas = new Dictionary<string, int>();
            //pessoas.Add("Pedro", 50);
            //pessoas.Add("Maria", 40);
            //pessoas.Add("Thiago", 30);
            //pessoas.Add("José", 40);
            //pessoas.Add("João", 30);
            //pessoas.Add("Roberta", 50);


            //var pessoasPorIdade = from p in pessoas
            //                      group p by p.Value;

            //foreach (var idade in pessoasPorIdade)
            //{
            //    Console.WriteLine("Pessoas com {0} anos:", idade.Key);
            //    foreach (var pessoa in idade)
            //    {
            //        Console.WriteLine(pessoa.Key);
            //    }
            //    Console.WriteLine();
            //}

            //// Para a execução para visualizar o resultado
            //Console.ReadKey();


            //Dictionary<int, string> clientes = new Dictionary<int, string>();
            //clientes.Add(1, "Thiago");
            //clientes.Add(2, "Pedro");
            //clientes.Add(3, "Maria");
            //clientes.Add(4, "José");
            //clientes.Add(5, "Diego");

            //Dictionary<string, int> pedidos = new Dictionary<string, int>();
            //pedidos.Add(Guid.NewGuid().ToString(), 1);
            //pedidos.Add(Guid.NewGuid().ToString(), 5);
            //pedidos.Add(Guid.NewGuid().ToString(), 5);
            //pedidos.Add(Guid.NewGuid().ToString(), 3);
            //pedidos.Add(Guid.NewGuid().ToString(), 2);
            //pedidos.Add(Guid.NewGuid().ToString(), 1);
            //pedidos.Add(Guid.NewGuid().ToString(), 2);
            //pedidos.Add(Guid.NewGuid().ToString(), 4);
            //pedidos.Add(Guid.NewGuid().ToString(), 4);

            //var result = from c in clientes
            //             join p in pedidos on c.Key equals p.Value
            //             select new
            //             {
            //                 Cliente = c.Value,
            //                 Pedido = p.Key
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine("Cliente {0} \t- Pedido {1}",
            //                                            item.Cliente, item.Pedido);
            //}

            //// Para a execução para visualizar o resultado
            //Console.ReadKey();


            //int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var query = from n in numeros
            //            where (n % 2) == 0
            //            select n;

            //var method = numeros.Where(n => n % 2 == 0);

            //Console.WriteLine("Filtro - Sintaxe de Consulta");
            //ExibeResultado(query);

            //Console.WriteLine("Filtro - Sintaxe de Método");
            //ExibeResultado(method);

            //var query2 = from n in numeros
            //             where (n % 2) == 0
            //             orderby n descending
            //             select n;

            //var method2 = numeros.Where(n => n % 2 == 0).OrderByDescending(n => n);

            //Console.WriteLine();
            //Console.WriteLine("Filtro/OrderBy - Sintaxe de Consulta");
            //ExibeResultado(query2);

            //Console.WriteLine("Filtro/OrderBy - Sintaxe de Método");
            //ExibeResultado(method2);

            //Console.ReadKey();


            //List<Cliente> clientes = CriarClientes();

            //IEnumerable<Cliente> resultado;

            //resultado = from c in clientes
            //            orderby c.Nome descending
            //            select c;

            ////Em sintaxe de método ficaria da seguinte forma:
            ////resultado = clientes.OrderByDescending(c => c.Nome);

            //Console.WriteLine("Ordenação:");
            //ExibirResultado(resultado.ToList());

            //resultado = from c in clientes
            //            where c.Email.Contains("treinaweb")
            //            select c;

            ////Em sintaxe de método ficaria da seguinte forma:
            ////resultado = clientes.Where(c => c.Email.Contains("treinaweb"));

            //Console.WriteLine("Filtro:");
            //ExibirResultado(resultado.ToList());

            //Console.ReadKey();


            //List<Cliente> clientes = CriarClientes();
            //List<Pedido> pedidos = CriarPedidos();

            //var result = from c in clientes
            //             join p in pedidos
            //             on c.ID equals p.IdCliente
            //             into clientesComPedidos
            //             select new
            //             {
            //                 c.Nome,
            //                 TotalDePedidos = clientesComPedidos.Count()
            //             };

            ////Em sintaxe de método ficaria da seguinte forma:
            ////var result = clientes.Join(pedidos, c => c.ID, p => p.IdCliente, (cliente, pedido) => new { cliente, pedido }).GroupBy(a => a.cliente.Nome).Select(g => new { Nome = g.Key, TotalDePedidos = g.Count() });

            //foreach (var item in result)
            //{
            //    Console.WriteLine("*******************************");
            //    Console.WriteLine(item);
            //    Console.WriteLine("*******************************");
            //}

            //Console.ReadKey();


            string diretorio = System.Environment.SystemDirectory;
            Console.WriteLine(diretorio);

            DirectoryInfo dirInfo = new DirectoryInfo(diretorio);

            var arquivos = dirInfo.GetFiles("*.*").ToList();

            var agrupado = from a in arquivos
                           group a by a.Extension into fgroup
                           orderby fgroup.Key
                           select fgroup;

            //Em sintaxe de método ficaria da seguinte forma:
            //var agrupado = arquivos.GroupBy(a => a.Extension).OrderBy(a => a.Key);

            foreach (var filegroup in agrupado)
            {
                Console.WriteLine("{0} – {1} arquivo(s)", filegroup.Key, filegroup.Count());

                foreach (var file in filegroup)
                {
                    Console.WriteLine(file.Name);
                }

                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        static void ExibeResultado(IEnumerable<int> items)
        {
            foreach (int item in items)
            {
                Console.WriteLine(item);
            }
        }

        static List<Cliente> CriarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(
                            new Cliente()
                            {
                                ID = 1,
                                Nome = "Felipe Mourato",
                                Sexo = Cliente.SexoEnum.Masculino,
                                Nascimento = new DateTime(1980, 12, 1),
                                Email = "felipe@contoso.com"
                            }
                        );

            clientes.Add(
                            new Cliente()
                            {
                                ID = 2,
                                Nome = "Mauro Mauricio",
                                Sexo = Cliente.SexoEnum.Masculino,
                                Nascimento = new DateTime(1970, 6, 12),
                                Email = "mauro@treinaweb.com.br"
                            }
                        );

            clientes.Add(
                            new Cliente()
                            {
                                ID = 3,
                                Nome = "Suzan Suzi",
                                Sexo = Cliente.SexoEnum.Feminino,
                                Nascimento = new DateTime(1992, 2, 25),
                                Email = "suzan@treinaweb.com.br"
                            }
                        );

            clientes.Add(
                            new Cliente()
                            {
                                ID = 4,
                                Nome = "Claudia Rodrigues",
                                Sexo = Cliente.SexoEnum.Feminino,
                                Nascimento = new DateTime(1990, 4, 3),
                                Email = "claudia@treinaweb.com.br"
                            }
                        );

            return clientes;
        }

        static List<Pedido> CriarPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            pedidos.Add(new Pedido()
            {
                ID = 1,
                IdCliente = 1,
                Data = DateTime.Now,
                Preco = 40.0
            });
            pedidos.Add(new Pedido()
            {
                ID = 2,
                IdCliente = 1,
                Data = DateTime.Now,
                Preco = 100.90
            });
            pedidos.Add(new Pedido()
            {
                ID = 3,
                IdCliente = 2,
                Data = DateTime.Now,
                Preco = 450.0
            });
            pedidos.Add(new Pedido()
            {
                ID = 4,
                IdCliente = 3,
                Data = DateTime.Now,
                Preco = 32.1
            });
            pedidos.Add(new Pedido()
            {
                ID = 5,
                IdCliente = 3,
                Data = DateTime.Now,
                Preco = 343.52
            });
            pedidos.Add(new Pedido()
            {
                ID = 6,
                IdCliente = 4,
                Data = DateTime.Now,
                Preco = 134.98
            });
            return pedidos;
        }

        static void ExibirResultado(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("{0} - {1}", cliente.ID, cliente.Nome);
                Console.WriteLine("Nascimento: {0}", cliente.Nascimento);
                Console.WriteLine("Sexo: {0}", cliente.Sexo.ToString());
                Console.WriteLine("Email: {0}", cliente.Email);
                Console.WriteLine("*******************************");
                Console.WriteLine("");
            }
        }

    }

}
