using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Test.TestModels
{
    public static class HandCategory
    {
        public static Hand BuildPair()
        {
            var card1 = new Card();
            card1.Suit = "spades";
            card1.Value = "10";
            var card2 = new Card();
            card2.Suit = "diamonds";
            card2.Value = "Q";
            var card3 = new Card();
            card3.Suit = "spades";
            card3.Value = "3";
            var card4 = new Card();
            card4.Suit = "spades";
            card4.Value = "A";
            var card5 = new Card();
            card5.Suit = "spades";
            card5.Value = "10";

            Card[] hand = { card1, card2, card3, card4, card5 };
            var category = new Hand(hand);
            return category;
        }
        public static Hand BuildTwoPair()
        {
            var card1 = new Card();
            card1.Suit = "spades";
            card1.Value = "10";
            var card2 = new Card();
            card2.Suit = "diamonds";
            card2.Value = "Q";
            var card3 = new Card();
            card3.Suit = "spades";
            card3.Value = "Q";
            var card4 = new Card();
            card4.Suit = "spades";
            card4.Value = "A";
            var card5 = new Card();
            card5.Suit = "spades";
            card5.Value = "10";

            Card[] hand = { card1, card2, card3, card4, card5 };
            var category = new Hand(hand);
            return category;
        }
        public static Hand BuildLowStraight()
        {
            var card1 = new Card();
            card1.Suit = "Clubs";
            card1.Value = "10";
            var card2 = new Card();
            card2.Suit = "Clubs";
            card2.Value = "9";
            var card3 = new Card();
            card3.Suit = "Clubs";
            card3.Value = "8";
            var card4 = new Card();
            card4.Suit = "Hearts";
            card4.Value = "7";
            var card5 = new Card();
            card5.Suit = "Clubs";
            card5.Value = "J";

            Card[] hand = { card1, card2, card3, card4, card5 };
            var category = new Hand(hand);
            return category;
        }
        public static Hand BuildHighStraight()
        {
            var card1 = new Card();
            card1.Suit = "Diamonds";
            card1.Value = "10";
            var card2 = new Card();
            card2.Suit = "Clubs";
            card2.Value = "9";
            var card3 = new Card();
            card3.Suit = "Clubs";
            card3.Value = "8";
            var card4 = new Card();
            card4.Suit = "Clubs";
            card4.Value = "Q";
            var card5 = new Card();
            card5.Suit = "Clubs";
            card5.Value = "J";

            Card[] hand = { card1, card2, card3, card4, card5 };
            var category = new Hand(hand);
            return category;
        }
        public static Hand BuildLowFlush(string type)
        {
            var card1 = new Card();
            card1.Suit = type;
            card1.Value = "10";
            var card2 = new Card();
            card2.Suit = type;
            card2.Value = "5";
            var card3 = new Card();
            card3.Suit = type;
            card3.Value = "Q";
            var card4 = new Card();
            card4.Suit = type;
            card4.Value = "K";
            var card5 = new Card();
            card5.Suit = type;
            card5.Value = "3";

            Card[] hand = { card1, card2, card3, card4, card5 };
            var category = new Hand(hand);
            return category;
        }
        public static Hand BuildHighFlush(string type)
        {
            var card1 = new Card();
            card1.Suit = type;
            card1.Value = "1";
            var card2 = new Card();
            card2.Suit = type;
            card2.Value = "Q";
            var card3 = new Card();
            card3.Suit = type;
            card3.Value = "8";
            var card4 = new Card();
            card4.Suit = type;
            card4.Value = "A";
            var card5 = new Card();
            card5.Suit = type;
            card5.Value = "10";

            Card[] hand = { card1, card2, card3, card4, card5 };
            var category = new Hand(hand);
            return category;
        }
    }
}
