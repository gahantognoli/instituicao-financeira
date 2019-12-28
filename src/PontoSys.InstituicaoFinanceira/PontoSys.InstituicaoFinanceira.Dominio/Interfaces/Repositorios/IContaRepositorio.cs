using PontoSys.InstituicaoFinanceira.Dominio.Entidades;

namespace PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Repositorios
{
    public interface IContaRepositorio : IRepositorio<Conta>
    {
        Conta ObterPorNumConta(string numConta);
        int ObterSenha(string numConta);
    }
}
