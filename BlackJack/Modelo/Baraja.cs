using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
    class Baraja
    {
        private List<Carta> cartas;

        public Baraja()
        {
            cartas = new List<Carta>();
            InicializarCartas();
        }

        private void InicializarCartas()
        {
            foreach (Pintas pinta in Enum.GetValues(typeof(Pintas)))
            {
                foreach (Valores valor in Enum.GetValues(typeof(Valores)))
                {
                    cartas.Add(new Carta(valor, pinta));
                }
            }
        }

        public void Revolver()
        {
            Random rand = new Random();
            cartas = cartas.OrderBy(c => rand.Next()).ToList();
        }

        public Carta Repartir()
        {
            if (cartas.Count > 0)
            {
                Carta carta = cartas[0];
                cartas.RemoveAt(0);
                return carta;
            }
            else
                return null;
        }

    }
}
