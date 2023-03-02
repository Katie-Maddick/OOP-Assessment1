using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public void Test()
        {
            int[] cardArray = { };
            
            //Instantiates objects
            Card c1 = new Card();
            Pack p1 = new Pack();

            int[] cards = p1.cardPack.ToArray();

            //Uses the methods for the Pack class
            p1.shuffleCardPack(1, cards);
            p1.deal(cards);
            p1.dealCard(52, cards);
        }
    }
}
