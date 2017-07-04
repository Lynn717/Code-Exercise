using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
    public class Deck
    {
        public List<Card> cardDeck = new List<Card>();
        public Deck()
        {
            //create the deck
            //Set Spades
            cardDeck.Add(new Card(1, "Ace", "Spade"));
            cardDeck.Add(new Card(2, "Two", "Spade"));
            cardDeck.Add(new Card(3, "Three", "Spade"));
            cardDeck.Add(new Card(4, "Four", "Spade"));
            cardDeck.Add(new Card(5, "Five", "Spade"));
            cardDeck.Add(new Card(6, "Six", "Spade"));
            cardDeck.Add(new Card(7, "Seven", "Spade"));
            cardDeck.Add(new Card(8, "Eight", "Spade"));
            cardDeck.Add(new Card(9, "Nine", "Spade"));
            cardDeck.Add(new Card(10, "Ten", "Spade"));
            cardDeck.Add(new Card(11, "Jack", "Spade"));
            cardDeck.Add(new Card(12, "Queen", "Spade"));
            cardDeck.Add(new Card(13, "King", "Spade"));

            //Set Diamond
            cardDeck.Add(new Card(1, "Ace", "Diamond"));
            cardDeck.Add(new Card(2, "Two", "Diamond"));
            cardDeck.Add(new Card(3, "Three", "Diamond"));
            cardDeck.Add(new Card(4, "Four", "Diamond"));
            cardDeck.Add(new Card(5, "Five", "Diamond"));
            cardDeck.Add(new Card(6, "Six", "Diamond"));
            cardDeck.Add(new Card(7, "Seven", "Diamond"));
            cardDeck.Add(new Card(8, "Eight", "Diamond"));
            cardDeck.Add(new Card(9, "Nine", "Diamond"));
            cardDeck.Add(new Card(10, "Ten", "Diamond"));
            cardDeck.Add(new Card(11, "Jack", "Diamond"));
            cardDeck.Add(new Card(12, "Queen", "Diamond"));
            cardDeck.Add(new Card(13, "King", "Diamond"));

            //Set Hearts
            cardDeck.Add(new Card(1, "Ace", "Heart"));
            cardDeck.Add(new Card(2, "Two", "Heart"));
            cardDeck.Add(new Card(3, "Three", "Heart"));
            cardDeck.Add(new Card(4, "Four", "Heart"));
            cardDeck.Add(new Card(5, "Five", "Heart"));
            cardDeck.Add(new Card(6, "Six", "Heart"));
            cardDeck.Add(new Card(7, "Seven", "Heart"));
            cardDeck.Add(new Card(8, "Eight", "Heart"));
            cardDeck.Add(new Card(9, "Nine", "Heart"));
            cardDeck.Add(new Card(10, "Ten", "Heart"));
            cardDeck.Add(new Card(11, "Jack", "Heart"));
            cardDeck.Add(new Card(12, "Queen", "Heart"));
            cardDeck.Add(new Card(13, "King", "Heart"));

            //set club
            cardDeck.Add(new Card(1, "Ace", "Club"));
            cardDeck.Add(new Card(2, "Two", "Club"));
            cardDeck.Add(new Card(3, "Three", "Club"));
            cardDeck.Add(new Card(4, "Four", "Club"));
            cardDeck.Add(new Card(5, "Five", "Club"));
            cardDeck.Add(new Card(6, "Six", "Club"));
            cardDeck.Add(new Card(7, "Seven", "Club"));
            cardDeck.Add(new Card(8, "Eight", "Club"));
            cardDeck.Add(new Card(9, "Nine", "Club"));
            cardDeck.Add(new Card(10, "Ten", "Club"));
            cardDeck.Add(new Card(11, "Jack", "Club"));
            cardDeck.Add(new Card(12, "Queen", "Club"));
            cardDeck.Add(new Card(13, "King", "Club"));
        }

        public void sortDeck() {
            List<Card> sortedDeck = new List<Card>();
            String[] suits = { "Club", "Heart", "Diamond", "Spade" }; //

            for (int i = 0; i < suits.Length; i++) {//go through the 4 suits
                string currentSuit = suits[i];
                for (int currentVal = 1; currentVal < 14; currentVal++) { //go through the 13 values for each suit.
                    for (int j = 0; j < cardDeck.Count; j++) {
                        if (cardDeck[j].getCardSuit() == currentSuit && cardDeck[j].getCardValue() == currentVal) {
                            sortedDeck.Add(cardDeck[j]);
                            cardDeck.RemoveAt(j);
                            break;
                        }

                    }
                }
                
            }

            cardDeck = sortedDeck;
        }

        public void randomDeck()
        {
            Random random = new Random();
            for (int i = 0; i < cardDeck.Count(); i++)
            {
                int randomNumber = random.Next(51);
                Card tempValue = cardDeck[randomNumber];
                cardDeck[randomNumber] = cardDeck[i];
                cardDeck[i] = tempValue;
            }

        }
    }
}
