using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.Musicas.AcessoDados.EF.Context;
using TreinaWeb.Musicas.Dominio;
using TreinaWeb.Repostitorios.Comum.EF;
using System.Data.Entity;

namespace TreinaWeb.Musicas.Repositorios.EF
{
    public class AlbunsRepositorio : RepositorioGenericoEF<Album, int>
    {
        public AlbunsRepositorio(MusicasDbContext contexto)
            : base(contexto)
        {

        }

        public override List<Album> Selecionar()
        {
            return _contexto.Set<Album>().Include(p => p.Musicas).ToList();
        }

        public override Album SelecionarPorID(int id)
        {
            return _contexto.Set<Album>().Include(p => p.Musicas).SingleOrDefault(a => a.ID == id);
        }
    }
}
