using PontoSys.InstituicaoFinanceira.Dominio.Entidades;
using PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Repositorios;
using PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace PontoSys.InstituicaoFinanceira.Dominio.Servicos
{
    public class PessoaFisicaService : IPessoaFisicaService
    {
        private readonly IPessoaFisicaRepositorio _pessoaFisicaRepositorio;

        public PessoaFisicaService(IPessoaFisicaRepositorio pessoaFisicaRepositorio)
        {
            _pessoaFisicaRepositorio = pessoaFisicaRepositorio;
        }

        public PessoaFisica Adicionar(PessoaFisica pessoaFisica)
        {
            return _pessoaFisicaRepositorio.Adicionar(pessoaFisica);
        }

        public PessoaFisica Atualizar(PessoaFisica pessoaFisica)
        {
            return _pessoaFisicaRepositorio.Atualizar(pessoaFisica);
        }

        public void Dispose()
        {
            this.Dispose();
            GC.SuppressFinalize(this);
        }

        public PessoaFisica ObterPorId(Guid id)
        {
            return _pessoaFisicaRepositorio.ObterPorId(id);
        }

        public IEnumerable<PessoaFisica> ObterTodos()
        {
            return _pessoaFisicaRepositorio.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _pessoaFisicaRepositorio.Remover(id);
        }
    }
}
