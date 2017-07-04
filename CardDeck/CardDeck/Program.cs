using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck cardDeck = new Deck();
            var a = cardDeck.cardDeck[0].getCardName();
            Console.WriteLine(a);


            cardDeck.randomDeck();
            for (int i = 0; i < cardDeck.cardDeck.Count; i++)
            {
                Console.WriteLine(cardDeck.cardDeck[i].getCardName() + " " + cardDeck.cardDeck[i].getCardSuit());
            }


            cardDeck.sortDeck();
            for (int i = 0; i < cardDeck.cardDeck.Count; i++)
            {
                Console.WriteLine(cardDeck.cardDeck[i].getCardName() + " " + cardDeck.cardDeck[i].getCardSuit());
            }

        }
    }
}
