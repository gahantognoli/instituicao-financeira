using PontoSys.InstituicaoFinanceira.Dominio.Entidades;
using PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Servicos;
using System;

namespace PontoSys.InstituicaoFinanceira.Dominio.Servicos
{
    public class ContaService : IContaService
    {
        public Conta Abrir(Conta conta)
        {
            throw new NotImplementedException();
        }

        public Conta Depositar(decimal valor, string numConta, int senha)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Encerrar(string numConta, int senha)
        {
            throw new NotImplementedException();
        }

        public Conta Sacar(decimal valor, string numConta, int senha)
        {
            throw new NotImplementedException();
        }

        public decimal VisualizarSaldo(string numConta, int senha)
        {
            throw new NotImplementedException();
        }
    }
}
