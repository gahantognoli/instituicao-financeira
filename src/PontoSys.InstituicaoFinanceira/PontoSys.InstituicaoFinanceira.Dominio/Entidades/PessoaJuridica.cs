using PontoSys.InstituicaoFinanceira.Dominio.Enums;
using PontoSys.InstituicaoFinanceira.Dominio.Validacoes;
using System;

namespace PontoSys.InstituicaoFinanceira.Dominio.Entidades
{
    public class PessoaJuridica : Cliente
    {
        public PessoaJuridica(string nome, string endereco, string email, string telefone, Sexo sexo,
            DateTime dataNascimento, string cnpj)
        {
            ClienteId = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
            Email = email;
            Telefone = telefone;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            CNPJ = cnpj;

            Validate(this, new PessoaJuridicaValidacao());
        }

        public string CNPJ { get; set; }
    }
}
