using FluentValidation;
using FluentValidation.Results;

namespace PontoSys.InstituicaoFinanceira.Dominio.Entidades
{
    public abstract class EntidadeBase
    {
        public bool Valida { get; private set; }
        public bool Invalida => !Valida;
        public ValidationResult ValidationResult { get; private set; }

        public bool Validate<TEntity>(TEntity entidade, AbstractValidator<TEntity> validator)
        {
            ValidationResult = validator.Validate(entidade);
            return Valida = ValidationResult.IsValid;
        }
    }
}
