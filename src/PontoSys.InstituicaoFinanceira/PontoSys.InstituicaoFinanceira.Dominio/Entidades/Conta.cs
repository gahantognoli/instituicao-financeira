using PontoSys.InstituicaoFinanceira.Dominio.Enums;
using System;

namespace PontoSys.InstituicaoFinanceira.Dominio.Entidades
{
    public class Conta : EntidadeBase
    {
        public Conta(string numeroConta, int senha, Guid clienteId, decimal saldo = 0)
        {
            ContaId = Guid.NewGuid();
            NumeroConta = numeroConta;
            Senha = senha;
            Saldo = saldo;
            ClienteId = clienteId;
        }

        public Guid ContaId { get; }
        public string NumeroConta { get; }
        public decimal Saldo { get; private set; }
        public DateTime DataAbertura { get; }
        public DateTime DataEncerramento { get; }
        public SituacaoConta Situacao { get; }
        public int Senha { get; }
        public Guid ClienteId { get; }

        public virtual Cliente Cliente { get; set; }
    }
}
