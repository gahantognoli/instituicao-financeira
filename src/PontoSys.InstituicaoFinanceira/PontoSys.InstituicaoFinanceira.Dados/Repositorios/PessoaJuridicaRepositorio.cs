using PontoSys.InstituicaoFinanceira.Dados.Contexto;
using PontoSys.InstituicaoFinanceira.Dominio.Entidades;
using PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Repositorios;

namespace PontoSys.InstituicaoFinanceira.Dados.Repositorios
{
    public class PessoaJuridicaRepositorio : Repositorio<PessoaJuridica>, IPessoaJuridicaRepositorio
    {
        public PessoaJuridicaRepositorio(InstituicaoFinanceiraContexto contexto) : base(contexto)
        {
        }
    }
}
