using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Classes
{
    public class Card
    {
        public Suit CardSuit { get; set; }
        public Value CardValue { get; set; }

        /// <summary>
        /// Creates an instance of the Card class.
        /// </summary>
        /// <param name="suit">The card's suit</param>
        /// <param name="value">The card's value</param>
        public Card(Suit suit, Value value)
        {
            CardSuit = suit;
            CardValue = value;
        }

        /// <summary>
        /// Displays the Card's suit and value in the console.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{CardValue} of {CardSuit}");
        }

        public enum Suit { Hearts, Diamonds, Spades, Clubs};
        public enum Value {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }


    }
}
