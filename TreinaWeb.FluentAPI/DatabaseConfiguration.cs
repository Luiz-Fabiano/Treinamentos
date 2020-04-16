using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.FluentAPI
{
    class DatabaseConfiguration : DropCreateDatabaseIfModelChanges<BancoCodeFirst>
    {
        protected override void Seed(BancoCodeFirst context)
        {
            var destinos = new List<Destino>
            {
                new Destino {
                    Nome = "Betim",
                    Pais = "Brasil",
                    Descricao = "Um belo lugar"

                },
                new Destino {
                    Nome = "Bangkok",
                    Pais = "Tailândia",
                    Descricao = "Cidade mais populosa da Tailândia, além de principal centro financeiro, corporativo, mercantil, cultural e histórico do país."

                },
                new Destino {
                    Nome = "Vale do silício",
                    Pais = "Estados Unidos da Ameríca",
                    Descricao = "Região onde está situado um conjunto de empresas com o objetivo de gerar inovações científicas"
                },
            };

            destinos.ForEach(s => context.Destinos.Add(s));

            var hospedagens = new List<Hospedagem>
            {
                new Hospedagem {
                    Nome = "Inn Hope",
                    Dono = "John Smith",
                    IsResort = true,
                    Destino = destinos.Find(d => d.Nome.Contains("Bangkok"))
                },
                new Hospedagem {
                    Nome = "Pousada Boa noite",
                    Dono = "Maria Silva",
                    IsResort  = false,
                    Destino = destinos.Find(d => d.Nome.Contains("Betim"))
                },
                new Hospedagem {
                    Nome = "Hilton Hotel",
                    Dono = "Mr. Hilton",
                    IsResort = true,
                    Destino = destinos.Find(d => d.Nome.Contains("Vale do silício"))
                },
            };

            hospedagens.ForEach(d => context.Hospedagens.Add(d));

            context.SaveChanges();
        }
    }
}