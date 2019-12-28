namespace PontoSys.InstituicaoFinanceira.Dominio.Notificacoes
{
    public class Notificacao
    {
        public string Key { get; }
        public string Message { get; set; }

        public Notificacao(string key, string message)
        {
            Key = key;
            Message = message;
        }
    }
}
