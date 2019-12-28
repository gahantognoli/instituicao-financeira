using PontoSys.InstituicaoFinanceira.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Servicos
{
    public interface IPessoaFisicaService : IDisposable
    {
        PessoaFisica Adicionar(PessoaFisica pessoaFisica);
        PessoaFisica Atualizar(PessoaFisica pessoaFisica);
        void Remover(Guid id);
        PessoaFisica ObterPorId(Guid id);
        IEnumerable<PessoaFisica> ObterTodos();
    }
}
