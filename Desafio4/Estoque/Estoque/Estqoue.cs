using System;
using System.Collections.Generic;

namespace Estoque
{
    public class Estoque
    {
        private List<Produto> produtos;

        public Estoque()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void ExibirProdutos()
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }
    }
}
