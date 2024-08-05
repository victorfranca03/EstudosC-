using System;
using System.Collections.Generic;

namespace RestauranteApp
{
    public class Mesa
    {
        public int Numero { get; set; }
        public bool Reservada { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Mesa(int numero)
        {
            Numero = numero;
            Reservada = false;
            Pedidos = new List<Pedido>();
        }

        public void AdicionarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }

        public override string ToString()
        {
            return $"Mesa {Numero}, Reservada: {Reservada}";
        }
    }
}
