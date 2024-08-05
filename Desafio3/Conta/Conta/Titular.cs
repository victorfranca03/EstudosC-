using System;

namespace Banco
{
    public class Titular
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }

        public Titular(string nome, string cpf, string endereco)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF: {CPF}\nEndereço: {Endereco}";
        }
    }
}
