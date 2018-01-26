using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
    public class Deck
    {
        //The values may change, but the overall card deck stayes the same
        public List<Card> cards = new List<Card>();
        
        String[] suits = { "Club", "Heart", "Diamond", "Spade" };


        Tuple<int, string>[] nameValues = {
            new Tuple<int, string>(1, "Ace"),
            new Tuple<int, string>(2, "Two"),
            new Tuple<int, string>(3, "Three"),
            new Tuple<int, string>(4, "Four"),
            new Tuple<int, string>(5, "Five"),
            new Tuple<int, string>(6, "Six"),
            new Tuple<int, string>(7, "Seven"),
            new Tuple<int, string>(8, "Eight"),
            new Tuple<int, string>(9, "Nine"),
            new Tuple<int, string>(10, "Ten"),
            new Tuple<int, string>(11, "Jack"),
            new Tuple<int, string>(12, "Queen"),
            new Tuple<int, string>(13, "King")
        };
        public Deck()
        {
            //creates a deck by default. "Club" ->"Heart"->"Diamond"->"Spade"  Ace being 1 and King being 13


            for (int i = 0; i < suits.Length; i++){ //go through the 4 suits
                for (int j = 0; j < nameValues.Length; j++){ //go through all name/values
                    cards.Add(new Card(suits[i], nameValues[j]));
                }
            }

        }

        public void sortDeck() { 
            List<Card> sortedDeck = new List<Card>();

            for (int i = 0; i < suits.Length; i++) {//go through the 4 suits
                string currentSuit = suits[i];
                for (int currentVal = 1; currentVal < 14; currentVal++) { //go through the 13 values for each suit.
                    for (int j = 0; j < cards.Count; j++) {
                        if (cards[j].getCardSuit() == currentSuit && cards[j].getCardNameValue().Item1 == currentVal) {
                            sortedDeck.Add(cards[j]);
                            cards.RemoveAt(j);
                            break;
                        }

                    }
                }
                
            }

            cards = sortedDeck;
        }

        public void randomDeck()
        {
            Random random = new Random();
            for (int i = 0; i < cards.Count(); i++)
            {
                int randomNumber = random.Next(51);
                Card tempValue = cards[randomNumber];
                cards[randomNumber] = cards[i];
                cards[i] = tempValue;
            }

        }
        public void SetValues(Tuple<int, string>[] newValues)
        {
            List<Card> newcards = new List<Card>();
            for (int i = 0; i < suits.Length; i++)
            { //go through the 4 suits
                for (int j = 0; j < newValues.Length; j++)
                { //go through all name/values
                    newcards.Add(new Card(suits[i], newValues[j]));
                }
            }

            cards = newcards;

        }

    }
    
}
