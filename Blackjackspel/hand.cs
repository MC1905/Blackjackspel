using blackjackspel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackspel
{

    public class Hand
    {  
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public int Score()
        {
            int score = 0;
            int aceCount = 0;

            foreach (Card card in cards)
            {
                score += card.Value;
                if (card.Rank == "Ace")
                {
                    aceCount++;
                }
            }

            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        public void Show()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

    }

}
