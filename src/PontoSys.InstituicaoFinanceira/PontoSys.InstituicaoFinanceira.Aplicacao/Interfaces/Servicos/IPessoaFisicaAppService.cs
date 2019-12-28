using PontoSys.InstituicaoFinanceira.Aplicacao.Modelos;
using System;
using System.Collections.Generic;

namespace PontoSys.InstituicaoFinanceira.Aplicacao.Interfaces.Servicos
{
    public interface IPessoaFisicaAppService
    {
        PessoaFisicaModelo Adicionar(PessoaFisicaModelo pessoaFisica);
        PessoaFisicaModelo Atualizar(PessoaFisicaModelo pessoaFisica);
        void Remover(Guid id);
        PessoaFisicaModelo ObterPorId(Guid id);
        IEnumerable<PessoaFisicaModelo> ObterTodos();
    }
}
