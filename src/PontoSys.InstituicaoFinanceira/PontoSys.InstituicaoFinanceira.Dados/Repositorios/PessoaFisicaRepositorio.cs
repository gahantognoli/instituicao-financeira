using PontoSys.InstituicaoFinanceira.Dados.Contexto;
using PontoSys.InstituicaoFinanceira.Dominio.Entidades;
using PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Repositorios;

namespace PontoSys.InstituicaoFinanceira.Dados.Repositorios
{
    public class PessoaFisicaRepositorio : Repositorio<PessoaFisica>, IPessoaFisicaRepositorio
    {
        public PessoaFisicaRepositorio(InstituicaoFinanceiraContexto contexto) : base(contexto)
        {
        }
    }
}
