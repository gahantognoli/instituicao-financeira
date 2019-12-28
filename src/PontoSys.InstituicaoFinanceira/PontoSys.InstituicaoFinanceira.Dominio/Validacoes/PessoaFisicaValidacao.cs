using FluentValidation;
using PontoSys.InstituicaoFinanceira.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PontoSys.InstituicaoFinanceira.Dominio.Validacoes
{
    public class PessoaFisicaValidacao : AbstractValidator<PessoaFisica>
    {
        public PessoaFisicaValidacao()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Email inválido");

            RuleFor(c => c.CPF).IsValidCPF();
        }
    }
}
