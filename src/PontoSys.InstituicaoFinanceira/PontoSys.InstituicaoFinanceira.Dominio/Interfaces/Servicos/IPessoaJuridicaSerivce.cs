using PontoSys.InstituicaoFinanceira.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Servicos
{
    public interface IPessoaJuridicaSerivce : IDisposable
    {
        PessoaJuridica Adicionar(PessoaJuridica pessoaFisica);
        PessoaJuridica Atualizar(PessoaJuridica pessoaFisica);
        void Remover(Guid id);
        PessoaJuridica ObterPorId(Guid id);
        IEnumerable<PessoaJuridica> ObterTodos();
    }
}
