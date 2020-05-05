using TreinaWeb.Comum.Repositorios.EF;
using TreinaWeb.WebApi.AcessoDados.EF.Context;
using TreinaWeb.WebApi.Dominio;

namespace TreinaWeb.WebApi.Repositorios.EF
{
    public class RepositorioAlunos : RepositorioTreinaWeb<Aluno, int>
    {
        public RepositorioAlunos(WebApiDbContext context)
            : base(context)
        {

        }
    }
}
