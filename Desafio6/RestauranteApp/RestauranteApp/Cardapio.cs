using System;
using System.Collections.Generic;

namespace RestauranteApp
{
    public class Cardapio
    {
        public List<ItemCardapio> Itens { get; set; }

        public Cardapio()
        {
            Itens = new List<ItemCardapio>();
        }

        public void AdicionarItem(ItemCardapio item)
        {
            Itens.Add(item);
        }

        public void ExibirItens()
        {
            foreach (var item in Itens)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class ItemCardapio
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public ItemCardapio(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"{Nome}, Preço: {Preco:C}";
        }
    }
}
