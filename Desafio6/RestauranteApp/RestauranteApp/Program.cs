using System;

namespace RestauranteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando o restaurante
            Restaurante restaurante = new Restaurante();

            // Adicionando mesas ao restaurante
            restaurante.AdicionarMesa(new Mesa(1));
            restaurante.AdicionarMesa(new Mesa(2));

            // Adicionando itens ao cardápio
            restaurante.Cardapio.AdicionarItem(new ItemCardapio("Pasta", 15.00m));
            restaurante.Cardapio.AdicionarItem(new ItemCardapio("Pizza", 20.00m));
            restaurante.Cardapio.AdicionarItem(new ItemCardapio("Salada", 10.00m));

            // Reservando uma mesa
            restaurante.ReservarMesa(1);

            // Criando um pedido para a mesa 1
            Mesa mesa1 = restaurante.Mesas.Find(m => m.Numero == 1);
            Pedido pedido1 = new Pedido(1);
            pedido1.AdicionarItem(restaurante.Cardapio.Itens[0]);
            pedido1.AdicionarItem(restaurante.Cardapio.Itens[1]);
            mesa1.AdicionarPedido(pedido1);

            // Exibindo mesas e pedidos
            Console.WriteLine("Mesas:");
            restaurante.ExibirMesas();

            Console.WriteLine("\nPedidos da Mesa 1:");
            foreach (var pedido in mesa1.Pedidos)
            {
                Console.WriteLine(pedido);
            }

            Console.WriteLine("\nCardápio:");
            restaurante.Cardapio.ExibirItens();
        }
    }
}
