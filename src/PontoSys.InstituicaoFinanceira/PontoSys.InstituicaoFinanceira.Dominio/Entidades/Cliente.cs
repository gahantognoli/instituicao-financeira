using PontoSys.InstituicaoFinanceira.Dominio.Enums;
using System;
using System.Collections.Generic;

namespace PontoSys.InstituicaoFinanceira.Dominio.Entidades
{
    public abstract class Cliente : EntidadeBase
    {
        public Guid ClienteId { get; protected set; }
        public string Nome { get; protected set; }
        public string Endereco { get; protected set; }
        public string Email { get; protected set; }
        public string Telefone { get; protected set; }
        public Sexo Sexo { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public bool Deletado { get; protected set; }

        public virtual ICollection<Conta> Contas { get; set; }
    }
}
