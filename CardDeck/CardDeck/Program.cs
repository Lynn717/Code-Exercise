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
            for (int i = 0; i < cardDeck.cards.Count; i++)
            {
                Console.WriteLine(cardDeck.cards[i].getCardNameValue().Item1 + " "+ cardDeck.cards[i].getCardNameValue().Item2 + " " + cardDeck.cards[i].getCardSuit());

            }
            Console.ReadKey();

            cardDeck.randomDeck();
            for (int i = 0; i < cardDeck.cards.Count; i++)
            {
                Console.WriteLine(cardDeck.cards[i].getCardNameValue().Item1 + " " + cardDeck.cards[i].getCardNameValue().Item2 + " " + cardDeck.cards[i].getCardSuit());

            }
            Console.ReadKey();

            cardDeck.sortDeck();
            for (int i = 0; i < cardDeck.cards.Count; i++)
            {
                Console.WriteLine(cardDeck.cards[i].getCardNameValue().Item1 + " " + cardDeck.cards[i].getCardNameValue().Item2 + " " + cardDeck.cards[i].getCardSuit());

            }
            Console.ReadKey();

            //create a deck where Ace is the highest
            Tuple<int, string>[] value = {
            new Tuple<int, string>(1, "Two"),
            new Tuple<int, string>(2, "Three"),
            new Tuple<int, string>(3, "Four"),
            new Tuple<int, string>(4, "Five"),
            new Tuple<int, string>(5, "Six"),
            new Tuple<int, string>(6, "Seven"),
            new Tuple<int, string>(7, "Eight"),
            new Tuple<int, string>(8, "Nine"),
            new Tuple<int, string>(9, "Ten"),
            new Tuple<int, string>(10, "Jack"),
            new Tuple<int, string>(11, "Queen"),
            new Tuple<int, string>(12, "King"),
            new Tuple<int, string>(13, "Ace"), };
            for (int i = 0; i < cardDeck.cards.Count; i++)
            {
                Console.WriteLine(cardDeck.cards[i].getCardNameValue().Item1 + " " + cardDeck.cards[i].getCardNameValue().Item2 + " " + cardDeck.cards[i].getCardSuit());

            }
            Console.ReadKey();

            //test everything afterwards also works      
            cardDeck.randomDeck();
            for (int i = 0; i < cardDeck.cards.Count; i++)
            {
                Console.WriteLine(cardDeck.cards[i].getCardNameValue().Item1 + " " + cardDeck.cards[i].getCardNameValue().Item2 + " " + cardDeck.cards[i].getCardSuit());

            }
            Console.ReadKey();

            cardDeck.sortDeck();
            for (int i = 0; i < cardDeck.cards.Count; i++)
            {
                Console.WriteLine(cardDeck.cards[i].getCardNameValue().Item1 + " " + cardDeck.cards[i].getCardNameValue().Item2 + " " + cardDeck.cards[i].getCardSuit());

            }
            Console.ReadKey();
        }
    }
}
