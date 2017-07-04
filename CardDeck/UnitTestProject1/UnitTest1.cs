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
            newDeck.Add(new Card(1, "Ace", "Spade"));
            newDeck.Add(new Card(2, "Two", "Spade"));
            newDeck.Add(new Card(3, "Three", "Spade"));
            newDeck.Add(new Card(4, "Four", "Spade"));
            newDeck.Add(new Card(5, "Five", "Spade"));
            newDeck.Add(new Card(6, "Six", "Spade"));
            newDeck.Add(new Card(7, "Seven", "Spade"));
            newDeck.Add(new Card(8, "Eight", "Spade"));
            newDeck.Add(new Card(9, "Nine", "Spade"));
            newDeck.Add(new Card(10, "Ten", "Spade"));
            newDeck.Add(new Card(11, "Jack", "Spade"));
            newDeck.Add(new Card(12, "Queen", "Spade"));
            newDeck.Add(new Card(13, "King", "Spade"));

            //Set Diamond
            newDeck.Add(new Card(1, "Ace", "Diamond"));
            newDeck.Add(new Card(2, "Two", "Diamond"));
            newDeck.Add(new Card(3, "Three", "Diamond"));
            newDeck.Add(new Card(4, "Four", "Diamond"));
            newDeck.Add(new Card(5, "Five", "Diamond"));
            newDeck.Add(new Card(6, "Six", "Diamond"));
            newDeck.Add(new Card(7, "Seven", "Diamond"));
            newDeck.Add(new Card(8, "Eight", "Diamond"));
            newDeck.Add(new Card(9, "Nine", "Diamond"));
            newDeck.Add(new Card(10, "Ten", "Diamond"));
            newDeck.Add(new Card(11, "Jack", "Diamond"));
            newDeck.Add(new Card(12, "Queen", "Diamond"));
            newDeck.Add(new Card(13, "King", "Diamond"));

            //Set Hearts
            newDeck.Add(new Card(1, "Ace", "Heart"));
            newDeck.Add(new Card(2, "Two", "Heart"));
            newDeck.Add(new Card(3, "Three", "Heart"));
            newDeck.Add(new Card(4, "Four", "Heart"));
            newDeck.Add(new Card(5, "Five", "Heart"));
            newDeck.Add(new Card(6, "Six", "Heart"));
            newDeck.Add(new Card(7, "Seven", "Heart"));
            newDeck.Add(new Card(8, "Eight", "Heart"));
            newDeck.Add(new Card(9, "Nine", "Heart"));
            newDeck.Add(new Card(10, "Ten", "Heart"));
            newDeck.Add(new Card(11, "Jack", "Heart"));
            newDeck.Add(new Card(12, "Queen", "Heart"));
            newDeck.Add(new Card(13, "King", "Heart"));

            //set club
            newDeck.Add(new Card(1, "Ace", "Club"));
            newDeck.Add(new Card(2, "Two", "Club"));
            newDeck.Add(new Card(3, "Three", "Club"));
            newDeck.Add(new Card(4, "Four", "Club"));
            newDeck.Add(new Card(5, "Five", "Club"));
            newDeck.Add(new Card(6, "Six", "Club"));
            newDeck.Add(new Card(7, "Seven", "Club"));
            newDeck.Add(new Card(8, "Eight", "Club"));
            newDeck.Add(new Card(9, "Nine", "Club"));
            newDeck.Add(new Card(10, "Ten", "Club"));
            newDeck.Add(new Card(11, "Jack", "Club"));
            newDeck.Add(new Card(12, "Queen", "Club"));
            newDeck.Add(new Card(13, "King", "Club"));

            //test if it matches the deck created
            Deck cardDeck = new Deck();
            for (int i = 0; i < cardDeck.cardDeck.Count; i++)
            {
                Assert.AreEqual(cardDeck.cardDeck[i].getCardName(), newDeck[i].getCardName());
                Assert.AreEqual(cardDeck.cardDeck[i].getCardSuit(), newDeck[i].getCardSuit());
                Assert.AreEqual(cardDeck.cardDeck[i].getCardValue(), newDeck[i].getCardValue());
            }
        }
        [TestMethod]
        public void TestDeckSort()
        {
            List<Card> sortedDeck = new List<Card>(); //hardcoded sorted deck
            sortedDeck.Add(new Card(1, "Ace", "Club"));
            sortedDeck.Add(new Card(2, "Two", "Club"));
            sortedDeck.Add(new Card(3, "Three", "Club"));
            sortedDeck.Add(new Card(4, "Four", "Club"));
            sortedDeck.Add(new Card(5, "Five", "Club"));
            sortedDeck.Add(new Card(6, "Six", "Club"));
            sortedDeck.Add(new Card(7, "Seven", "Club"));
            sortedDeck.Add(new Card(8, "Eight", "Club"));
            sortedDeck.Add(new Card(9, "Nine", "Club"));
            sortedDeck.Add(new Card(10, "Ten", "Club"));
            sortedDeck.Add(new Card(11, "Jack", "Club"));
            sortedDeck.Add(new Card(12, "Queen", "Club"));
            sortedDeck.Add(new Card(13, "King", "Club"));

            sortedDeck.Add(new Card(1, "Ace", "Heart"));
            sortedDeck.Add(new Card(2, "Two", "Heart"));
            sortedDeck.Add(new Card(3, "Three", "Heart"));
            sortedDeck.Add(new Card(4, "Four", "Heart"));
            sortedDeck.Add(new Card(5, "Five", "Heart"));
            sortedDeck.Add(new Card(6, "Six", "Heart"));
            sortedDeck.Add(new Card(7, "Seven", "Heart"));
            sortedDeck.Add(new Card(8, "Eight", "Heart"));
            sortedDeck.Add(new Card(9, "Nine", "Heart"));
            sortedDeck.Add(new Card(10, "Ten", "Heart"));
            sortedDeck.Add(new Card(11, "Jack", "Heart"));
            sortedDeck.Add(new Card(12, "Queen", "Heart"));
            sortedDeck.Add(new Card(13, "King", "Heart"));


            sortedDeck.Add(new Card(1, "Ace", "Diamond"));
            sortedDeck.Add(new Card(2, "Two", "Diamond"));
            sortedDeck.Add(new Card(3, "Three", "Diamond"));
            sortedDeck.Add(new Card(4, "Four", "Diamond"));
            sortedDeck.Add(new Card(5, "Five", "Diamond"));
            sortedDeck.Add(new Card(6, "Six", "Diamond"));
            sortedDeck.Add(new Card(7, "Seven", "Diamond"));
            sortedDeck.Add(new Card(8, "Eight", "Diamond"));
            sortedDeck.Add(new Card(9, "Nine", "Diamond"));
            sortedDeck.Add(new Card(10, "Ten", "Diamond"));
            sortedDeck.Add(new Card(11, "Jack", "Diamond"));
            sortedDeck.Add(new Card(12, "Queen", "Diamond"));
            sortedDeck.Add(new Card(13, "King", "Diamond"));

            sortedDeck.Add(new Card(1, "Ace", "Spade"));
            sortedDeck.Add(new Card(2, "Two", "Spade"));
            sortedDeck.Add(new Card(3, "Three", "Spade"));
            sortedDeck.Add(new Card(4, "Four", "Spade"));
            sortedDeck.Add(new Card(5, "Five", "Spade"));
            sortedDeck.Add(new Card(6, "Six", "Spade"));
            sortedDeck.Add(new Card(7, "Seven", "Spade"));
            sortedDeck.Add(new Card(8, "Eight", "Spade"));
            sortedDeck.Add(new Card(9, "Nine", "Spade"));
            sortedDeck.Add(new Card(10, "Ten", "Spade"));
            sortedDeck.Add(new Card(11, "Jack", "Spade"));
            sortedDeck.Add(new Card(12, "Queen", "Spade"));
            sortedDeck.Add(new Card(13, "King", "Spade"));


            //Create and sort deck
            Deck cardDeck = new Deck();
            cardDeck.sortDeck();
            Assert.AreEqual(cardDeck.cardDeck.Count, sortedDeck.Count);

            for (int i = 0; i < cardDeck.cardDeck.Count; i++)
            {
                Assert.AreEqual(cardDeck.cardDeck[i].getCardName(), sortedDeck[i].getCardName());
                Assert.AreEqual(cardDeck.cardDeck[i].getCardSuit(), sortedDeck[i].getCardSuit());
                Assert.AreEqual(cardDeck.cardDeck[i].getCardValue(), sortedDeck[i].getCardValue());
            }



        }
        [TestMethod]
        public void TestDeckRandomize()
        {
            Deck randomizedDeck = new Deck();
            Deck cardDeck = new Deck();
            bool randomized = false;
            randomizedDeck.randomDeck();

            for (int i = 0; i < cardDeck.cardDeck.Count; i++) //check to see if its randonized. Chances are low that it will repeat
            {
                if (cardDeck.cardDeck[i].getCardName() != randomizedDeck.cardDeck[i].getCardName() ||
                 cardDeck.cardDeck[i].getCardSuit() != randomizedDeck.cardDeck[i].getCardSuit() ||
                cardDeck.cardDeck[i].getCardValue() != randomizedDeck.cardDeck[i].getCardValue())
                {
                    randomized = true;
                    break;
                }
            }
            Assert.AreEqual(randomized, true);

            //verify that the deck is still complete.
            cardDeck.sortDeck();
            randomizedDeck.sortDeck();
            for (int i = 0; i < cardDeck.cardDeck.Count; i++) //check to see if its randonized. Chances are low that it will repeat
            {
                Assert.AreEqual(cardDeck.cardDeck[i].getCardName(), randomizedDeck.cardDeck[i].getCardName());
                Assert.AreEqual(cardDeck.cardDeck[i].getCardSuit(), randomizedDeck.cardDeck[i].getCardSuit());
                Assert.AreEqual(cardDeck.cardDeck[i].getCardValue(), randomizedDeck.cardDeck[i].getCardValue());
            }


        }
    }
}
