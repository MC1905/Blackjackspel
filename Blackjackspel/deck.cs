﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackspel
{
    internal class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    int value;
                    if (int.TryParse(rank, out value))
                    {
                        // Numeric card
                        Cards.Add(new Card { Suit = suit, Rank = rank, Value = value });
                    }
                    else if (rank == "Ace")
                    {
                        // Ace can be 1 or 11
                        Cards.Add(new Card { Suit = suit, Rank = rank, Value = 11 });
                    }
                    else
                    {
                        // Face card
                        Cards.Add(new Card { Suit = suit, Rank = rank, Value = 10 });
                    }
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = card;
            }
        }
    }
}
