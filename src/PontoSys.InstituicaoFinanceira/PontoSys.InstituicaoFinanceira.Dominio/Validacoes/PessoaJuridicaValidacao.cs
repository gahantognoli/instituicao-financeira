using FluentValidation;
using PontoSys.InstituicaoFinanceira.Dominio.Entidades;

namespace PontoSys.InstituicaoFinanceira.Dominio.Validacoes
{
    public class PessoaJuridicaValidacao : AbstractValidator<PessoaJuridica>
    {
        public PessoaJuridicaValidacao()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Email inválido");

            RuleFor(c => c.CNPJ).IsValidCNPJ();
        }
    }
}
