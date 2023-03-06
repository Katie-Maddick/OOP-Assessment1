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
            //Instantiates objects
            Pack p1 = new Pack();

            //Uses the methods for the Pack class
            Pack.shuffleCardPack(1);
            Console.WriteLine("Test 1 successful");
            Pack.shuffleCardPack(2);
            Console.WriteLine("Test 2 successful");
            Pack.shuffleCardPack(3);
            Console.WriteLine("Test 3 successful");
            Card card = Pack.deal();
            Card[] cards = Pack.dealCard(10);
        }
    }
}
