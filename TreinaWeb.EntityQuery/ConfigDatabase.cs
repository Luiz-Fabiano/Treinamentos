using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TreinaWeb.EntityQuery
{
    class ConfigDatabase : DropCreateDatabaseIfModelChanges<BancoCodeFirst>
    {
        protected override void Seed(BancoCodeFirst context)
        {
            var departamentos = new List<Departamentos>
        {
            new Departamentos { Nome = "RH" },
            new Departamentos { Nome = "Desenvolvimento" },
            new Departamentos { Nome = "Marketing"},
            new Departamentos { Nome = "Gerência"}
        };

            departamentos.ForEach(c => context.Departamentos.Add(c));
            context.SaveChanges();

            var funcionarios = new List<Funcionarios>
        {
            new Funcionarios {
                Nome = "Carlos Silva",
                Cargo = "Analista",
                Salario = 4500,
                Departamento = departamentos.Single(d => d.Nome.Contains("Desenvolvimento"))
            },
            new Funcionarios {
                Nome = "Maria Santos",
                Cargo = "Psicologa",
                Salario = 2400,
                Departamento = departamentos.Single(d => d.Nome.Contains("RH"))
            },
            new Funcionarios {
                Nome = "José Sousa",
                Cargo = "CEO",
                Salario = 12000,
                Departamento = departamentos.Single(d => d.Nome.Contains("Gerência"))
            },
            new Funcionarios {
                Nome = "Ana Monteiro",
                Cargo = "Redatora",
                Salario = 2000,
                Departamento = departamentos.Single(d => d.Nome.Contains("Marketing"))
            },
            new Funcionarios {
                Nome = "Elis Regina",
                Cargo = "Estagiária",
                Salario = 1050.1M,
                Departamento = departamentos.Single(d => d.Nome.Contains("Desenvolvimento"))
            },
        };

            funcionarios.ForEach(s => context.Funcionarios.Add(s));
            context.SaveChanges();
        }
    }
}
