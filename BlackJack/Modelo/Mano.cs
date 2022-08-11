using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
    class Mano
    {

        private List<Carta> Cartas;
        

        public Mano()
        {
            Cartas = new List<Carta>();
        }

        public void AgregarCarta(Carta carta)
        {
            Cartas.Add(carta);
        }

        public int ValorMano
        {
            get
            {
                int suma = 0;
                foreach (Carta carta in Cartas){
                    if (carta.Valor == Valores.J || carta.Valor == Valores.Q || carta.Valor == Valores.K)
                    {
                        suma += 10;
                    }
                    else
                    {
                        suma += (int)carta.Valor;
                    }
                    
                }
                return suma;
            }
        }
    }
}
