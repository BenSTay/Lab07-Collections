using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Cards.Classes
{
    public class Deck<T> : IEnumerable
    {
        public T[] Cards = new T[8];

        protected int Count;

        /// <summary>
        /// Adds an item to the deck.
        /// </summary>
        /// <param name="card">The item being added.</param>
        public void Add(T card)
        {
            if (Count == Cards.Length)
            {
                Array.Resize(ref Cards, Cards.Length * 2);
            }

            Cards[Count++] = card;
        }

        /// <summary>
        /// Allows the deck to be iterated through.
        /// </summary>
        /// <returns>An item in the deck.</returns>
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return Cards[i];
            }
        }

        /// <summary>
        /// Re-orders the items in the deck.
        /// </summary>
        public void Shuffle()
        {
            Random rand = new Random();
            int shuffles = rand.Next(1, 10);
            for (int i = 0; i < 9; i++)
            {
                Shuffle(this);
            }
        }

        /// <summary>
        /// Re-orders the items in the deck.
        /// </summary>
        /// <param name="deck">The deck being re-ordered.</param>
        protected void Shuffle(Deck<T> deck)
        {
            if (deck.Count > 1)
            {
                Deck<T> deck1 = new Deck<T>();
                Deck<T> deck2 = new Deck<T>();
                while (deck.Count > 0)
                {
                    if (deck.Count > 0) deck1.Add(deck.Remove());
                    if (deck.Count > 0) deck2.Add(deck.Remove());
                }
                Shuffle(deck1);
                Shuffle(deck2);
                while (deck1.Count > 0) deck.Add(deck1.Remove());
                while (deck2.Count > 0) deck.Add(deck2.Remove());
            }
        }

        /// <summary>
        /// Removes an item from the deck.
        /// </summary>
        /// <returns>The removed item.</returns>
        public T Remove()
        {
            if (Count > 0)
            {
                Count--;
                return Cards[Count];
            }
            else throw new Exception("Deck has no cards!");
        }

        // Magic Don't Touch
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
