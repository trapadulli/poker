namespace CardGame.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_0100_IsStraight()
        {
            var card1 = new Card();
            card1.Suit = "spades";
            card1.Value = "J";
            var card2 = new Card();
            card2.Suit = "hearts";
            card2.Value = "Q";
            var card3 = new Card();
            card3.Suit = "spades";
            card3.Value = "K";
            var card4 = new Card();
            card4.Suit = "diamonds";
            card4.Value = "A";
            var card5 = new Card();
            card5.Suit = "spades";
            card5.Value = "10";

            Card[] hand3 = { card1, card2, card3, card4, card5 };
            var hand4 = new Hand(hand3);
            Assert.Equal("Straight",hand4.Category);
        }

        [Fact]
        public void Test_0200_IsFlush()
        {
            var card1 = new Card();
            card1.Suit = "spades";
            card1.Value = "3";
            var card2 = new Card();
            card2.Suit = "spades";
            card2.Value = "Q";
            var card3 = new Card();
            card3.Suit = "spades";
            card3.Value = "K";
            var card4 = new Card();
            card4.Suit = "spades";
            card4.Value = "A";
            var card5 = new Card();
            card5.Suit = "spades";
            card5.Value = "10";

            Card[] hand = { card1, card2, card3, card4, card5 };
            var category = new Hand(hand);
            Assert.Equal("Flush", category.Category);
        }

        [Fact]
        public void Test_0300_IsPair()
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
            Assert.Equal("Pair", category.Category);
        }

        [Fact]
        public void Test_0400_IsTwoPair()
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
            Assert.Equal("Two Pair", category.Category);
        }
    }
}