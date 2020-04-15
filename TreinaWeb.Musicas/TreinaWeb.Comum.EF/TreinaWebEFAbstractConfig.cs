using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Comum.EF
{
    public abstract class TreinaWebEFAbstractConfig<TEntity> : EntityTypeConfiguration<TEntity>
        where TEntity : class
    {
        public TreinaWebEFAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChavesEstrangeiras();
        }

        protected abstract void ConfigurarNomeTabela();

        protected abstract void ConfigurarCamposTabela();

        protected abstract void ConfigurarChavePrimaria();

        protected abstract void ConfigurarChavesEstrangeiras();        
    } 
}
