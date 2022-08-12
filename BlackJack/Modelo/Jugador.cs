using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
    class Jugador
    {
        public string Nombre { get; }
        public int Ganados { get; set; }
        public int Perdidos { get; set; }
        public Mano Mano { get; set; }

        public Jugador(string nombre)
        {
            this.Nombre = nombre;
            Ganados = 0;
            Perdidos = 0;
            Mano = new Mano();

        }

        public void InicializarMano(List<Carta> cartas)
        {
            foreach(Carta carta in cartas)
            {
                Mano.AgregarCarta(carta);
            }
        }

        public void RecibirCarta(Carta carta)
        {
            Mano.AgregarCarta(carta);

        }
    }
}
