using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{

    public class Card
    {
        private int cardValue;
        private string cardName;
        private string cardSuit;

        public Card(int value, string name, string suit) {
            cardValue = value;
            cardName = name;
            cardSuit = suit;
        }

        public int getCardValue(){
            return cardValue;
        }
        public string getCardName()
        {
            return cardName;
        }
        public string getCardSuit()
        {
            return cardSuit;
        }
    }
}
