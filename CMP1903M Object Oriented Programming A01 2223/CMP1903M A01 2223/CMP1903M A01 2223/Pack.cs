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
        //Initialise the card pack here
        private static Card[] _pack;
        public Pack()
        {
            _pack = new Card[52];
            CreatePack();
        }

        private static void FisherShuffle(ref Card[] _pack)
        {
            Console.WriteLine("Fisher–Yates shuffle");
            Random _random = new Random();
            int n = _pack.Length;
            Card[] tempArr = new Card[n];

            //Will change all positions of cards with a random card
            for (int i = 0; i < n; i++)
            {
                int r = _random.Next(n);
                if (r != i) tempArr[i] = tempArr[r];
                tempArr[r] = _pack[i];
            }
            _pack = tempArr;
            
        }

        private static void RiffleShuffle(ref Card[] _pack)
        {
            Console.WriteLine("Tabled Card Riffle Shuffle");
            int n = _pack.Length;

            //Creates two halves of the deck 
            Card[] left = new Card[26];
            Card[] right = new Card[26];
            Card[] shuffledCards = new Card[52];

            //Shuffles with both arrays from both ends
            for (int i = 0; i < (n / 2); i++)
            {
                _pack[i] = left[i];
                _pack[26 + i] = right[i];
            }
            for (int i = 0; i < 26; i++)
            {
                shuffledCards[i] = left[i];
                shuffledCards[i + 1] = right[i];
                i++;
            }
        }
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if(typeOfShuffle == 1)
            {
                FisherShuffle(ref _pack);
                return true;
            }
            else if (typeOfShuffle == 2) 
            {
                RiffleShuffle(ref _pack);
                return true;
            }
            else
            {
                //Error handling
                Console.WriteLine("Invalid number input");
                return false;
            }
        }

        public static Card deal()
        {
            //Deals one card
            Random random = new Random(); //Picks a random number
            int ranNumb = random.Next(1, 52);
            Card card = _pack[ranNumb];
            Console.WriteLine(card);
            return card;
        }
        public static Card[] dealCard(int amount) 
        {
            //Deals the number of cards specified by 'amount'
            int i = 0;
            Card[] multCards = new Card[amount];

            //If statement to deal multiple cards as specified
            for (i = 1; i < amount; i++)
            {
                Random random = new Random(); //Picks a random number
                int ranNumb = random.Next(1, 52);
                Card card = _pack[ranNumb];
                multCards[i] = card;
            }
            Console.WriteLine(multCards);
            return multCards;
        }

        //Creates the pack to be used
        public static void CreatePack()
        {
            for(int i = 1; i < 5; i++)
            {
                for(int j = 1; j < 14; j++)
                {
                    Card card = new Card();
                    card.setSuit = j;
                    card.setValue = i;
                }
            }
        }
    }
}
