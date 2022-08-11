using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelo
{
    public enum Pintas
    {
        Corazones,
        Diamantes,
        Treboles,
        Espadas
    }

    public enum Valores
    {
        A = 1,
        DOS = 2,
        TRES = 3,
        CUATRO = 4,
        CINCO = 5,
        SEIS = 6,
        SIETE = 7,
        OCHO = 8,
        NUEVE = 9,
        DIEZ = 10,
        J = 11,
        Q = 12,
        K = 13
    }

    class Carta
    {
        public Valores Valor { get; }
        public Pintas Pinta { get; }


        public Carta(Valores valor, Pintas pinta)
        {
            Valor = valor;
            Pinta = pinta;
        }

        public override string ToString()
        {
            return $"{Valor} de {Pinta}";
        }
    }

}
