using PontoSys.InstituicaoFinanceira.Dominio.UnitOfWork;

namespace PontoSys.InstituicaoFinanceira.Aplicacao.Servicos
{
    public class AppService 
    {
        private readonly IUnitOfWork _uow;

        public AppService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        protected void Commit()
        {
            _uow.Commit();
        }
    }
}
