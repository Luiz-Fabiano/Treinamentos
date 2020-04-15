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
    public class MusicasRepositorio : RepositorioGenericoEF<Musica, long>
    {
        public MusicasRepositorio(MusicasDbContext contexto)
            : base(contexto)
        {

        }

        public override List<Musica> Selecionar()
        {
            return _contexto.Set<Musica>().Include(p => p.Album).ToList();
        }

        public override Musica SelecionarPorID(long id)
        {
            return _contexto.Set<Musica>().Include(p => p.Album).SingleOrDefault(m => m.ID == id);
        }
    }
}
