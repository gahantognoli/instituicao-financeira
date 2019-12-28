using AutoMapper;
using PontoSys.InstituicaoFinanceira.Aplicacao.Interfaces.Servicos;
using PontoSys.InstituicaoFinanceira.Aplicacao.Modelos;
using PontoSys.InstituicaoFinanceira.Dominio.Entidades;
using PontoSys.InstituicaoFinanceira.Dominio.Interfaces.Servicos;
using PontoSys.InstituicaoFinanceira.Dominio.Notificacoes;
using PontoSys.InstituicaoFinanceira.Dominio.UnitOfWork;
using PontoSys.InstituicaoFinanceira.Dominio.Validacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PontoSys.InstituicaoFinanceira.Aplicacao.Servicos
{
    public class PessoaFisicaAppService : AppService, IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;
        private readonly NotificacaoContexto _notificacaoContexto;
        private readonly IMapper _mapper;
        public PessoaFisicaAppService(IPessoaFisicaService pessoaFisicaService, NotificacaoContexto notificacaoContexto,
            IMapper mapper, IUnitOfWork uow) : base(uow)
        {
            _pessoaFisicaService = pessoaFisicaService;
            _notificacaoContexto = notificacaoContexto;
            _mapper = mapper;
        }

        public PessoaFisicaModelo Adicionar(PessoaFisicaModelo pessoaFisicaModelo)
        {
            PessoaFisica pessoaFisica = new PessoaFisica(pessoaFisicaModelo.Nome, pessoaFisicaModelo.Endereco,
                pessoaFisicaModelo.Email, pessoaFisicaModelo.Telefone, pessoaFisicaModelo.Sexo,
                pessoaFisicaModelo.DataNascimento, pessoaFisicaModelo.CPF);

            if (pessoaFisica.Invalida)
            {
                _notificacaoContexto.AddNotificacao(pessoaFisica.ValidationResult);
                return _mapper.Map<PessoaFisicaModelo>(pessoaFisica);
            }

            var pessoaFisicaAdd = _pessoaFisicaService.Adicionar(pessoaFisica);
            return _mapper.Map<PessoaFisicaModelo>(pessoaFisicaAdd);
        }

        public PessoaFisicaModelo Atualizar(PessoaFisicaModelo pessoaFisica)
        {
            throw new NotImplementedException();
        }

        public PessoaFisicaModelo ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaFisicaModelo> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
