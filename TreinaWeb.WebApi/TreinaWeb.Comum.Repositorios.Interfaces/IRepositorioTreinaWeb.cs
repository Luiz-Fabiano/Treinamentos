﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TreinaWeb.Comum.Repositorios.Interfaces
{
    public interface IRepositorioTreinaWeb<TDominio, TChave>
        where TDominio : class
    {
        List<TDominio> Selecionar(Expression<Func<TDominio, bool>> where = null);

        TDominio SelecionarPorID(TChave id);

        void Inserir(TDominio dominio);

        void Atualizar(TDominio dominio);

        void Excluir(TDominio dominio);

        void ExcluirPorID(TChave id);
    }
}
