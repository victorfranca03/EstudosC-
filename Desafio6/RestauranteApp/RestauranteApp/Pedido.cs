using System;

namespace RestauranteApp
{
    public class Pedido
    {
        public int Numero { get; set; }
        public List<ItemCardapio> Itens { get; set; }

        public Pedido(int numero)
        {
            Numero = numero;
            Itens = new List<ItemCardapio>();
        }

        public void AdicionarItem(ItemCardapio item)
        {
            Itens.Add(item);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in Itens)
            {
                total += item.Preco;
            }
            return total;
        }

        public override string ToString()
        {
            return $"Pedido {Numero}, Total: {CalcularTotal():C}";
        }
    }
}
