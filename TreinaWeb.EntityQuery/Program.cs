using System;
using System.Linq;

namespace TreinaWeb.EntityQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    foreach (var item in dc.Funcionarios)
            //    {
            //        Console.WriteLine(item.Nome);
            //    }
            //    Console.ReadKey();
            //}
            #endregion

            #region 2º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    var result = from fun in dc.Funcionarios
            //                 orderby fun.Nome
            //                 select fun;

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var result = dc.Funcionarios.OrderBy(fun => fun.Nome);

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item.Nome);
            //    }
            //    Console.ReadKey();
            //}
            #endregion

            #region 3º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    var result = from fun in dc.Funcionarios
            //                 orderby fun.Nome
            //                 select fun;

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var result = dc.Funcionarios.OrderBy(fun => fun.Nome);

            //    Console.WriteLine("SQL: {0} \n", result.ToString());

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item.Nome);
            //    }
            //    Console.ReadKey();
            //}
            #endregion

            #region 4º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    var result = from fun in dc.Funcionarios
            //                 where fun.Salario > 2000M
            //                 orderby fun.Nome
            //                 select fun;

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var result = dc.Funcionarios.Where(fun => fun.Salario > 2000M).OrderBy(fun => fun.Nome);

            //    Console.WriteLine("SQL: \n{0} \n", result.ToString());

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine("{0}, \t salário {1}", item.Nome, item.Salario.ToString("C"));
            //    }
            //    Console.ReadKey();
            //}
            #endregion

            #region 5º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    var result = from fun in dc.Funcionarios
            //                 where fun.Salario > 2000M
            //                 orderby fun.Nome
            //                 select fun;

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var result = dc.Funcionarios.Where(fun => fun.Salario > 2000M).OrderBy(fun => fun.Nome);

            //    Console.WriteLine("Funcionários com salários acima de R$ 2000");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine("{0}, \t salário {1}", item.Nome, item.Salario.ToString("C"));
            //    }

            //    Console.WriteLine("\n");

            //    var result2 = from fun in dc.Funcionarios
            //                  where fun.Salario <= 2000M
            //                  orderby fun.Nome
            //                  select fun;

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var result2 = dc.Funcionarios.Where(fun => fun.Salario <= 2000M).OrderBy(fun => fun.Nome);
            //    Console.WriteLine("Funcionários com salários abaixo de R$ 2000");
            //    foreach (var item in result2)
            //    {
            //        Console.WriteLine("{0}, \t salário {1}", item.Nome, item.Salario.ToString("C"));
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region 6º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    var funcionarios = dc.Funcionarios.ToList();

            //    var result = from fun in funcionarios
            //                 where fun.Salario > 2000M
            //                 orderby fun.Nome
            //                 select fun;

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var result = funcionarios.Where(fun => fun.Salario > 2000M).OrderBy(fun => fun.Nome);

            //    Console.WriteLine("Funcionários com salários acima de R$ 2000");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine("{0}, \t salário {1}", item.Nome, item.Salario.ToString("C"));
            //    }

            //    Console.WriteLine("\n");

            //    var result2 = from fun in funcionarios
            //                  where fun.Salario <= 2000M
            //                  orderby fun.Nome
            //                  select fun;

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var result2 = funcionarios.Where(fun => fun.Salario <= 2000M).OrderBy(fun => fun.Nome);

            //    Console.WriteLine("Funcionários com salários abaixo de R$ 2000");
            //    foreach (var item in result2)
            //    {
            //        Console.WriteLine("{0}, \t salário {1}", item.Nome, item.Salario.ToString("C"));
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region 7º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    var query = from d in dc.Departamentos
            //                where d.Nome == "Desenvolvimento"
            //                select d;

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var query = dc.Departamentos.Where(d => d.Nome == "Desenvolvimento");

            //    var dev = query.Single();

            //    Console.WriteLine("Funcionários do departamento {0}:", dev.Nome);

            //    foreach (var item in dev.Funcionarios)
            //    {
            //        Console.WriteLine("{0}, \t salário {1}", item.Nome, item.Salario.ToString("C"));
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region 8º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    var result = from d in dc.Departamentos.Include("Funcionarios")
            //                 orderby d.Nome
            //                 select d;

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var result = dc.Departamentos.Include("Funcionarios").OrderBy(d => d.Nome);

            //    foreach (var departamento in result)
            //    {
            //        Console.WriteLine("Funcionários do departamento {0}:", departamento.Nome);

            //        foreach (var item in departamento.Funcionarios)
            //        {
            //            Console.WriteLine("{0}, \t salário {1}", item.Nome, item.Salario.ToString("C"));
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region 9º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    var query = from d in dc.Departamentos
            //                where d.Nome == "Desenvolvimento"
            //                select d;

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //var query = dc.Departamentos.Where(d => d.Nome == "Desenvolvimento");

            //    var dev = query.Single();

            //    dc.Entry(dev).Collection("Funcionarios").Load();
            //    // O método Reference é similar ao Collection:
            //    //dc.Entry(dev).Reference("Funcionarios").Load();

            //    Console.WriteLine("Funcionários do departamento {0}:", dev.Nome);

            //    foreach (var item in dev.Funcionarios)
            //    {
            //        Console.WriteLine("{0}, \t salário {1}", item.Nome, item.Salario.ToString("C"));
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region 10º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos antes da inclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0}", item.Nome);
            //    }

            //    InclusaoDepartamento();

            //    Console.WriteLine("\nDepartamentos após da inclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0}", item.Nome);
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region 11º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos antes da alteração:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0}", item.Nome);
            //    }
            //}
            //AlteracaoDepartamento();

            //Console.WriteLine();
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos após da alteração:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0}", item.Nome);
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region 12º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos antes da exclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0}", item.Nome);
            //    }
            //}
            //ExclusaoDepartamento();

            //Console.WriteLine();
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos após da exclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0}", item.Nome);
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region 13º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos antes da inclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0} - {1}", item.ID, item.Nome);
            //    }
            //}
            //InclusaoDepartamento();

            //Console.WriteLine();
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos após da inclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0} - {1}", item.ID, item.Nome);
            //    }
            //    Console.ReadKey();
            //}
            #endregion

            #region 14º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos antes da exclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0} - {1}", item.ID, item.Nome);
            //    }
            //}
            //ExclusaoDepartamento();

            //Console.WriteLine();
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos após da exclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0} - {1}", item.ID, item.Nome);
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region 15º Código
            using (BancoCodeFirst dc = new BancoCodeFirst())
            {
                Console.WriteLine("Departamentos antes da inclusão:");

                foreach (var item in dc.Departamentos)
                {
                    Console.WriteLine("{0} - {1}", item.ID, item.Nome);
                }
            }
            InclusaoDepartamento();

            Console.WriteLine();
            using (BancoCodeFirst dc = new BancoCodeFirst())
            {
                Console.WriteLine("Departamentos após da inclusão:");

                foreach (var item in dc.Departamentos)
                {
                    Console.WriteLine("{0} - {1}", item.ID, item.Nome);
                }

                Console.WriteLine();

                Console.WriteLine("Funcionários após a inclusão:");

                foreach (var item in dc.Funcionarios.Include("Departamento"))
                {
                    Console.WriteLine("{0} - {1}", item.Nome, item.Departamento.Nome);
                }

                Console.ReadKey();
            }
            #endregion

            #region 16º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{

            //    Console.WriteLine("Departamentos antes da exclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0} - {1}", item.ID, item.Nome);
            //    }
            //}
            //ExclusaoDepartamento();

            //Console.WriteLine();
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos após da exclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0} - {1}", item.ID, item.Nome);
            //    }

            //    Console.WriteLine();

            //    Console.WriteLine("Funcionários após a exclusão:");

            //    foreach (var item in dc.Funcionarios.Include("Departamento"))
            //    {
            //        Console.WriteLine("{0} - {1}", item.Nome, item.Departamento.Nome);
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region 17º Código
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos antes da exclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0} - {1}", item.ID, item.Nome);
            //    }
            //}
            //ExclusaoDepartamento();

            //Console.WriteLine();
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Console.WriteLine("Departamentos após da exclusão:");

            //    foreach (var item in dc.Departamentos)
            //    {
            //        Console.WriteLine("{0} - {1}", item.ID, item.Nome);
            //    }

            //    Console.WriteLine();

            //    Console.WriteLine("Funcionários após a exclusão:");

            //    foreach (var item in dc.Funcionarios.Include("Departamento"))
            //    {
            //        Console.WriteLine("{0} - {1}", item.Nome, item.Departamento == null ? "" : item.Departamento.Nome);
            //    }

            //    Console.ReadKey();
            //}
            #endregion
        }

        public static void InclusaoDepartamento()
        {
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Departamentos departamento = new Departamentos()
            //    {
            //        Nome = "Recepção"
            //    };

            //    dc.Departamentos.Add(departamento);
            //    dc.SaveChanges();
            //}

            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Departamentos departamento = new Departamentos()
            //    {
            //        Nome = "Recepção"
            //    };

            //    dc.Departamentos.Add(departamento);

            //    Funcionarios funcionario = new Funcionarios()
            //    {
            //        Nome = "Maria da Silva",
            //        Cargo = "Secretária",
            //        Salario = 900,
            //        Departamento = departamento
            //    };

            //    dc.Funcionarios.Add(funcionario);

            //    dc.SaveChanges();
            //}
            using (BancoCodeFirst dc = new BancoCodeFirst())
            {
                Departamentos departamento = new Departamentos()
                {
                    Nome = "Recepção"
                };

                dc.Departamentos.Add(departamento);

                Funcionarios funcionario = dc.Funcionarios.Where(f => f.Departamento == null).Single();

                funcionario.Departamento = departamento;

                dc.SaveChanges();
            }
        }

        public static void AlteracaoDepartamento()
        {
            using (BancoCodeFirst dc = new BancoCodeFirst())
            {
                Departamentos departamento = (from d in dc.Departamentos
                                              where d.Nome.Contains("Recepção")
                                              select d).Single();

                //Em sintaxe de método ficaria da seguinte forma:
                //Departamentos departamento = dc.Departamentos.Where(d => d.Nome.Contains("Recepção")).Single();

                departamento.Nome = "Atendimento ao cliente";

                dc.SaveChanges();
            }
        }

        public static void ExclusaoDepartamento()
        {
            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Departamentos departamento = (from d in dc.Departamentos
            //                                  where d.Nome.Contains("Atendimento")
            //                                  select d).Single();

            //    //Em sintaxe de método ficaria da seguinte forma:
            //    //Departamentos departamento = dc.Departamentos.Where(d => d.Nome.Contains("Atendimento")).Single();

            //    dc.Departamentos.Remove(departamento);

            //    dc.SaveChanges();
            //}

            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    Departamentos departamento = new Departamentos() { ID = 7 };

            //    dc.Departamentos.Attach(departamento);

            //    dc.Departamentos.Remove(departamento);

            //    dc.SaveChanges();
            //}

            //using (BancoCodeFirst dc = new BancoCodeFirst())
            //{
            //    var funcionarios = from f in dc.Funcionarios.Include("Departamento")
            //                       where f.Departamento.DepartamentosId == 7
            //                       select f;

            //    var rh = dc.Departamentos.Where(d => d.Nome == "RH").Single();

            //    foreach (var item in funcionarios)
            //        item.Departamento = rh;

            //    Departamentos departamento = dc.Departamentos.Where(d => d.DepartamentosId == 7).Single();

            //    dc.Departamentos.Remove(departamento);

            //    dc.SaveChanges();
            //}

            using (BancoCodeFirst dc = new BancoCodeFirst())
            {

                Departamentos departamento = dc.Departamentos.Where(d => d.ID == 7).Single();

                dc.Entry(departamento).Collection("Funcionarios").Load();

                dc.Departamentos.Remove(departamento);

                dc.SaveChanges();
            }
        }
    }
}
