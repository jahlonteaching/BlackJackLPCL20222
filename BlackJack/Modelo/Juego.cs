using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
    class Juego
    {
        public Jugador Jugador { get; set; }

        public Dealer Dealer { get; set; }

        public Juego(Jugador jugador, Dealer dealer)
        {
            Jugador = jugador;
            Dealer = dealer;
        }

        public void Iniciar()
        {
            Dealer.Barajar();
            IniciarManos();
        }

        public void AgregarCartaAJugador()
        {
            Jugador.RecibirCarta(Dealer.RepartirCarta());
        }

        public void AgregarCartaADealer()
        {
            Dealer.RecibirCarta(Dealer.RepartirCarta());
        }

        private void IniciarManos()
        {
            List<Carta> cartasManoJugador = new List<Carta>();
            List<Carta> cartasManoDealer = new List<Carta>();
            for(int i = 0; i < 2; i++)
            {
                cartasManoJugador.Add(Dealer.RepartirCarta());
                cartasManoDealer.Add(Dealer.RepartirCarta());
            }
        }
    }
}
