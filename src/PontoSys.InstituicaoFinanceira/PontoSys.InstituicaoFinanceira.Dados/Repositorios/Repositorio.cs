using Microsoft.EntityFrameworkCore;
using PontoSys.InstituicaoFinanceira.Dados.Contexto;
using PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;

namespace PontoSys.InstituicaoFinanceira.Dados.Repositorios
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        protected InstituicaoFinanceiraContexto Db;
        protected DbSet<TEntity> DbSet;

        public Repositorio(InstituicaoFinanceiraContexto contexto)
        {
            Db = contexto;
            DbSet = Db.Set<TEntity>();
        }

        public TEntity Adicionar(TEntity entity)
        {
            return DbSet.Add(entity).Entity;
        }

        public TEntity Atualizar(TEntity entity)
        {
            var entry = Db.Entry(entity);
            DbSet.Attach(entity);
            entry.State = EntityState.Modified;

            return entry.Entity;
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public TEntity ObterPorId(Guid Id)
        {
            return DbSet.Find(Id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return DbSet;
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}
