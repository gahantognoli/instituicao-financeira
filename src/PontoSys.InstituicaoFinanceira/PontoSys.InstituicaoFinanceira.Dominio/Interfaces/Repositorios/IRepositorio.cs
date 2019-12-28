using System;
using System.Collections.Generic;
using System.Text;

namespace PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Repositorios
{
    public interface IRepositorio<TEntity> : IDisposable where TEntity : class
    {
        TEntity Adicionar(TEntity entity);
        TEntity Atualizar(TEntity entity);
        void Remover(Guid id);
        TEntity ObterPorId(Guid Id);
        IEnumerable<TEntity> ObterTodos();
        int SaveChanges();
    }
}
