using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Repostitorios.Comum.EF
{
    public class RepositorioGenericoEF<TEntidade, TChave> : IRepositorioGenerico<TEntidade, TChave>
        where TEntidade : class
    {
        protected DbContext _contexto;

        public RepositorioGenericoEF(DbContext contexto)
        {
            _contexto = contexto;
        }

        public void Alterar(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public void ExcluirPorID(TChave id)
        {
            TEntidade entidade = SelecionarPorID(id);
            Excluir(entidade);
        }

        public void Inserir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Add(entidade);
            _contexto.SaveChanges();
        }

        public virtual List<TEntidade> Selecionar()
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public virtual TEntidade SelecionarPorID(TChave id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }
    }
}
