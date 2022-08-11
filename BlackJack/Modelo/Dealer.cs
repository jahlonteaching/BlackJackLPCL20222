using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
    class Dealer
    {
        public int Ganados { get; set; }
        public int Perdidos { get; set; }

        public Mano Mano { get; set; }
        public Baraja Baraja { get; set; }
        public Dealer()
        {
            Mano = new Mano();
            Ganados = 0;
            Perdidos = 0;
            Baraja = new Baraja();
        }

        public Carta RepartirCarta()
        {
            return Baraja.Repartir();
        }

        public void RecibirCarta(Carta carta)
        {
            Mano.AgregarCarta(carta);
        }
    }
}
