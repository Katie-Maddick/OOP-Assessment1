using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Initial variables 
        private int _Value;
        private int _Suit;

        //Validation for Value
        public int setValue
        {
            get { return _Value; }
            set
            {
                //Prevents value if out of range
                while((value < 1) || (value > 13)){
                    Console.WriteLine("Value is out of range");
                }
                _Value = value; 
            }
        }

        //Validation for Suit
        public int setSuit
        {
            get { return _Suit; }
            set
            {
                //Prevents Suit if out of range
                while ((value < 1) || (value > 4))
                {
                    Console.WriteLine("Suit out of range");
                }
            }
        }
    }

    

}
