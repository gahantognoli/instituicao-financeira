using PontoSys.InstituicaoFinanceira.Dominio.Entidades;
using System;

namespace PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Servicos
{
    public interface IContaService : IDisposable
    {
        Conta Abrir(Conta conta);
        void Encerrar(string numConta, int senha);
        Conta Sacar(decimal valor, string numConta, int senha);
        Conta Depositar(decimal valor, string numConta, int senha);
        decimal VisualizarSaldo(string numConta, int senha);
    }
}
