using PontoSys.InstituicaoFinanceira.Dados.Contexto;
using PontoSys.InstituicaoFinanceira.Dominio.UnitOfWork;

namespace PontoSys.InstituicaoFinanceira.Dados.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InstituicaoFinanceiraContexto _instituicaoFinanceiraContexto;
        private bool _disposed;

        public UnitOfWork(InstituicaoFinanceiraContexto instituicaoFinanceiraContexto)
        {
            _instituicaoFinanceiraContexto = instituicaoFinanceiraContexto;
        }

        public void Commit()
        {
            _instituicaoFinanceiraContexto.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _instituicaoFinanceiraContexto.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
