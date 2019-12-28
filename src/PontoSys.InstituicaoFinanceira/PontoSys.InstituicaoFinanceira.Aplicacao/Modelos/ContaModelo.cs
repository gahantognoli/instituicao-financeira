using PontoSys.InstituicaoFinanceira.Dominio.Enums;
using System;

namespace PontoSys.InstituicaoFinanceira.Aplicacao.Modelos
{
    public class ContaModelo
    {
        public Guid ContaId { get; set; }
        public string NumeroConta { get; set; }
        public decimal Saldo { get; private set; }
        public DateTime DataAbertura { get; set; } = DateTime.Now;
        public DateTime DataEncerramento { get; set; }
        public SituacaoConta Situacao { get; set; }
        public int Senha { get; set; }
        public Guid ClienteId { get; set; }

        public virtual ClienteModelo Cliente { get; set; }
    }
}
