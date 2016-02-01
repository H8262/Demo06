using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{

    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            Deck deck = new Deck();

            int o = 0;
            for(int i = 0;i<4;i++)
            {
                for(o = 0;o<13;o++)
                {
                    Card card = new Card { Maa = i, Nro = o };
                    deck.AddCard(card);
                    Console.WriteLine(card.ToString());      
                }
                o = 0;
            }
        }
    }
}
