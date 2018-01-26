using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{

    public class Card
    {
        private string cardSuit;
        private Tuple<int, string> cardNameValue; //together so you can determine value with name

        //private string cardName;
       //private string cardSuit;

        public Card(string suit, Tuple<int, string> nameValue) {
            cardSuit = suit;
            cardNameValue = nameValue;
        }

        public string getCardSuit(){
            return cardSuit;
        }
        public Tuple<int, string> getCardNameValue()
        {
            return cardNameValue;
        }
    }
}
