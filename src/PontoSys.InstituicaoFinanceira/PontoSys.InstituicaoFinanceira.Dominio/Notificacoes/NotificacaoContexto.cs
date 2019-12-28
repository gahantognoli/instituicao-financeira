using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace PontoSys.InstituicaoFinanceira.Dominio.Notificacoes
{
    public class NotificacaoContexto 
    {
        private readonly List<Notificacao> _notificacoes;
        public IReadOnlyCollection<Notificacao> Notificacoes => _notificacoes;
        public bool TemNotificacoes => _notificacoes.Any();

        public NotificacaoContexto()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void AddNotificacao(string key, string message)
        {
            _notificacoes.Add(new Notificacao(key, message));
        }

        public void AddNotificacao(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
            {
                AddNotificacao(erro.ErrorCode, erro.ErrorMessage);
            }
        }
    }
}
