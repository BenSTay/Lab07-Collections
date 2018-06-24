using System;
using Xunit;
using Cards;
using Cards.Classes;

namespace TestDeck
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddCard()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card = new Card(0, 0);
            deck.Add(card);
            Assert.Equal(card, deck.Cards[0]);
        }

        [Theory]
        [InlineData(Card.Suit.Diamonds, Card.Value.Queen)]
        [InlineData(Card.Suit.Clubs, Card.Value.Eight)]
        [InlineData(Card.Suit.Spades, Card.Value.Ace)]
        [InlineData(Card.Suit.Hearts, Card.Value.Jack)]
        public void TestGetSetCard(Card.Suit suit, Card.Value value)
        {
            Card card = new Card(0, 0);
            card.CardSuit = suit;
            card.CardValue = value;
            Assert.True(card.CardSuit == suit && card.CardValue == value);
        }

        [Fact]
        public void TestRemoveExists()
        {
            Deck<Card> deck = Program.BuildDeck();
            Card card = deck.Remove();
            Assert.IsType<Card>(card);
        }

        [Fact]
        public void TestRemoveNotExists()
        {
            Deck<Card> deck = new Deck<Card>();
            Assert.Throws<Exception>(() => deck.Remove());
        }

        [Fact]
        public void TestShuffle()
        {
            Deck<Card> deck = Program.BuildDeck();
            Card card1 = deck.Cards[0];
            deck.Shuffle();
            Assert.False(deck.Cards[0] == card1);
        }
    }
}
