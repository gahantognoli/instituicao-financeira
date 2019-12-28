using PontoSys.InstituicaoFinanceira.Dominio.Enums;
using PontoSys.InstituicaoFinanceira.Dominio.Validacoes;
using System;

namespace PontoSys.InstituicaoFinanceira.Dominio.Entidades
{
    public class PessoaFisica : Cliente
    {
        public PessoaFisica(string nome, string endereco, string email, string telefone, Sexo sexo, 
            DateTime dataNascimento, string cpf)
        {
            ClienteId = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
            Email = email;
            Telefone = telefone;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            CPF = cpf;

            Validate(this, new PessoaFisicaValidacao());
        }

        public string CPF { get; }
    }
}
