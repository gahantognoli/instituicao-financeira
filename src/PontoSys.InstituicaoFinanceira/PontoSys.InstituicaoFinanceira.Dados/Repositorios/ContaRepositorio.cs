using PontoSys.InstituicaoFinanceira.Dados.Contexto;
using PontoSys.InstituicaoFinanceira.Dominio.Entidades;
using PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Repositorios;
using System.Linq;

namespace PontoSys.InstituicaoFinanceira.Dados.Repositorios
{
    public class ContaRepositorio : Repositorio<Conta>, IContaRepositorio
    {
        public ContaRepositorio(InstituicaoFinanceiraContexto contexto) : base(contexto)
        {
        }

        public Conta ObterPorNumConta(string numConta)
        {
            return DbSet.FirstOrDefault(c => c.NumeroConta == numConta);
        }

        public int ObterSenha(string numConta)
        {
            return DbSet.FirstOrDefault(c => c.NumeroConta == numConta).Senha;
        }
    }
}
