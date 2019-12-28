using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using PontoSys.InstituicaoFinanceira.Dominio.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PontoSys.InstituicaoFinanceira.API.Filters
{
    public class NotificationFilter : IResultFilter
    {
        private readonly NotificacaoContexto _notificacaoContexto;

        public NotificationFilter(NotificacaoContexto notificacaoContexto)
        {
            _notificacaoContexto = notificacaoContexto;
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (_notificacaoContexto.TemNotificacoes)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.HttpContext.Response.ContentType = "application/json";

                var notifications = JsonConvert.SerializeObject(_notificacaoContexto.Notificacoes);
                context.HttpContext.Response.Body.Write(Encoding.ASCII.GetBytes(notifications));

                return;
            }
        }
    }
}
