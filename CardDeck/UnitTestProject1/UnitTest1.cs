using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardDeck;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDeckCreation()
        {
            //test if deck creation is sucessful and all cards are in deck
            List<Card> newDeck = new List<Card>(); //hardcoded a new deck

            //test if it matches the deck created
            Deck cardDeck = new Deck();
            Assert.IsNotNull(cardDeck);
            Assert.AreEqual(cardDeck.cards.Count, 52);
        }
        [TestMethod]
        public void TestDeckSort()
        {
            Deck sortedDeck = new Deck(); //sorted deck
            sortedDeck.sortDeck();

            //Create and sort deck
            Deck cardDeck = new Deck();
            cardDeck.randomDeck(); //randomize the deck so it can be sorted
            cardDeck.sortDeck();
            Assert.AreEqual(cardDeck.cards.Count, sortedDeck.cards.Count);

            for (int i = 0; i < cardDeck.cards.Count; i++)
            {
                Assert.AreEqual(cardDeck.cards[i].getCardNameValue(), sortedDeck.cards[i].getCardNameValue());
                Assert.AreEqual(cardDeck.cards[i].getCardSuit(), sortedDeck.cards[i].getCardSuit());
            }



        }
        [TestMethod]
        public void TestDeckRandomize()
        {
            Deck randomizedDeck = new Deck();
            Deck cardDeck = new Deck();
            bool randomized = false;
            randomizedDeck.randomDeck();

            for (int i = 0; i < cardDeck.cards.Count; i++) //check to see if its randonized. Chances are low that it will repeat
            {
                if (cardDeck.cards[i].getCardNameValue() != randomizedDeck.cards[i].getCardNameValue() ||
                 cardDeck.cards[i].getCardSuit() != randomizedDeck.cards[i].getCardSuit())
                {
                    randomized = true;
                    break;
                }
            }
            Assert.AreEqual(randomized, true);

            //verify that the deck is still complete.
            cardDeck.sortDeck();
            randomizedDeck.sortDeck();
            for (int i = 0; i < cardDeck.cards.Count; i++) 
            {
                Assert.AreEqual(cardDeck.cards[i].getCardNameValue(), randomizedDeck.cards[i].getCardNameValue());
                Assert.AreEqual(cardDeck.cards[i].getCardSuit(), randomizedDeck.cards[i].getCardSuit());
            }


        }
        [TestMethod]
        public void TestChangeDeckValues()
        {
            Deck cardDeck = new Deck();

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

            cardDeck.SetValues(value);
            for (int i = 0; i < cardDeck.cards.Count; i++)
            {
                if(cardDeck.cards[i].getCardNameValue().Item1 == 13) {
                    Assert.AreEqual(cardDeck.cards[i].getCardNameValue().Item2, "Ace");
                }
            }


        }
    }
}
