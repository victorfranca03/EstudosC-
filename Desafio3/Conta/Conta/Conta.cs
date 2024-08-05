using System;

namespace Banco
{
    public class Conta
    {
        public Titular Titular { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }

        public Conta(Titular titular, string agencia, string numeroConta, decimal saldo, decimal limite)
        {
            Titular = titular;
            Agencia = agencia;
            NumeroConta = numeroConta;
            Saldo = saldo;
            Limite = limite;
        }

        public string InformacoesDetalhadas()
        {
            return $"Titular:\n{Titular}\n\n" +
                   $"Agência: {Agencia}\n" +
                   $"Número da Conta: {NumeroConta}\n" +
                   $"Saldo: {Saldo:C}\n" +
                   $"Limite: {Limite:C}";
        }
    }
}
