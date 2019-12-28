using PontoSys.InstituicaoFinanceira.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PontoSys.InstituicaoFinanceira.Aplicacao.Modelos
{
    public class ClienteModelo
    {
        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Deletado { get; set; }

        public virtual ICollection<ContaModelo> Contas { get; set; }
    }
}
