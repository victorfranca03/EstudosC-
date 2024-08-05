using System;
using System.Collections.Generic;

namespace RestauranteApp
{
    public class Restaurante
    {
        public List<Mesa> Mesas { get; set; }
        public Cardapio Cardapio { get; set; }

        public Restaurante()
        {
            Mesas = new List<Mesa>();
            Cardapio = new Cardapio();
        }

        public void AdicionarMesa(Mesa mesa)
        {
            Mesas.Add(mesa);
        }

        public void ReservarMesa(int numeroMesa)
        {
            Mesa mesa = Mesas.Find(m => m.Numero == numeroMesa);
            if (mesa != null)
            {
                mesa.Reservada = true;
            }
        }

        public void ExibirMesas()
        {
            foreach (var mesa in Mesas)
            {
                Console.WriteLine(mesa);
            }
        }
    }
}
