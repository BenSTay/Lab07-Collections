using System;
using Cards.Classes;

namespace Cards
{
    public class Program
    {
        /// <summary>
        /// Creates a deck with 52 cards in it.
        /// </summary>
        /// <returns>A deck with 52 cards in it.</returns>
        public static Deck<Card> BuildDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            for (int i = 0; i < 52; i++)
            {
                deck.Add(new Card((Card.Suit)(i / 13),(Card.Value)(i % 13)));
            }
            return deck;
        }

        /// <summary>
        /// Displays all of the cards in the deck, shuffles the deck, and displays them again.
        /// </summary>
        /// <param name="deck">The deck being dealt.</param>
        static void Deal(Deck<Card> deck)
        {
            Console.WriteLine("==== Pre-Shuffle ====");
            foreach(Card c in deck)
            {
                c.Print();
            }
            Console.WriteLine("\n==== Post-Shuffle ====");
            deck.Shuffle();
            foreach (Card card in deck)
            {
                card.Print();
            }
        }

        static void Main(string[] args)
        {
            Deck<Card> deck = BuildDeck();
            Deal(deck);
            Console.ReadKey();
        }
    }
}
