using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        
        //Get, set values
        public int typeOfShuffle { get; set; }
        public int amount { get; set; }

        //Initialise the card pack here
        public static List<Card> _pack = new List<Card>();
        public Card[] cardPack = _pack.ToArray();

        public Pack()
        {
        }
        public static bool shuffleCardPack(int typeOfShuffle, int[] cardPack)
        {
            //Shuffles the pack based on the type of shuffle
            if(typeOfShuffle == 1)
            {
                Console.WriteLine("Fisher–Yates shuffle");
                Random _random = new Random(); 
                int n = cardPack.Length; 
                //Will change all positions of cards with a random card
                for(int i = 0; i < n; i++)
                {
                    int r = i + _random.Next(n - 1);
                    int temp = cardPack[r];
                    cardPack[r] = cardPack[i];
                    cardPack[i] = temp;
                }
                return true;
            }
            else if (typeOfShuffle == 2) 
            {
                Console.WriteLine("Tabled Card Riffle Shuffle");
                int n = cardPack.Length;
                //Creates two halves of the deck 
                int[] left = { };
                int[] right = { };
                int[] shuffledCards = { };
                //Shuffles with both arrays from both ends
                for (int i = 0; i < (n / 2); i++) 
                {
                    cardPack[i] = left[i];
                    cardPack[1 - i] = right[i];
                }
                for(int i = 0; i < n; i++)
                {
                    shuffledCards[i] = left[i];
                    shuffledCards[i + 1] = right[i];
                    i++;
                }
                return true;
            }
            else
            {
                //Error handling
                Console.WriteLine("Invalid number input");
                return false;
            }
        }

        public static Card deal(int[] cardPack)
        {
            //Deals one card
            Random random = new Random(); //Picks a random number
            int ranNumb = random.Next(1, 52);
            int card = cardPack[ranNumb];
            Console.WriteLine(card);
            return null;
        }
        public static List<Card> dealCard(int amount, int[]cardPack) 
        {
            //Deals the number of cards specified by 'amount'
            int i = 0;
            
            //If statement to deal multiple cards as specified
            for (i = 1; i <= amount; i++)
            {
                Random random = new Random(); //Picks a random number
                int ranNumb = random.Next(1, 52);
                int card = cardPack[ranNumb];
                Console.WriteLine(card);
            }
            return null;
        }
    }
}
