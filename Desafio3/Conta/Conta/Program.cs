using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Titular titular = new Titular("João Silva", "123.456.789-00", "Rua das Flores, 123");
            Conta conta = new Conta(titular, "1234", "56789-0", 1000.00m, 2000.00m);

            Console.WriteLine(conta.InformacoesDetalhadas());
        }
    }
}
