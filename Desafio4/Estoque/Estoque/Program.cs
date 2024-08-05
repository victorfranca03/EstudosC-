using System;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();

            Produto produto1 = new Produto("Notebook", "001", 3500.00m, 10);
            Produto produto2 = new Produto("Mouse", "002", 50.00m, 100);

            estoque.AdicionarProduto(produto1);
            estoque.AdicionarProduto(produto2);

            Console.WriteLine("Produtos no estoque:");
            estoque.ExibirProdutos();
        }
    }
}
