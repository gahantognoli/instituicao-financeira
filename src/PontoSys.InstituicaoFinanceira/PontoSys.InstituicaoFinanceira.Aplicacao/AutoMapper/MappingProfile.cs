using AutoMapper;
using PontoSys.InstituicaoFinanceira.Aplicacao.Modelos;
using PontoSys.InstituicaoFinanceira.Dominio.Entidades;

namespace PontoSys.InstituicaoFinanceira.Aplicacao.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PessoaFisica, PessoaFisicaModelo>();
            CreateMap<PessoaJuridica, PessoaJuridicaModelo>();
            CreateMap<Conta, PessoaJuridicaModelo>();
        }
    }
}
