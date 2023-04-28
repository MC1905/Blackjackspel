
using blackjackspel;
using System;

namespace Blackjackspel
{
    public class Blackjack
    {
        private Deck deck;
        private Hand playerHand;
        private Hand dealerHand;



        public void StartGame(int bet)
        {
            // Create a new deck and shuffle it
            deck = new Deck();
            deck.Shuffle();

            // Create new player and dealer hands
            playerHand = new Hand();
            dealerHand = new Hand();

            // Deal initial cards
            playerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());
            playerHand.AddCard(deck.DealCard(true));
            dealerHand.AddCard(deck.DealCard());


            // Check for natural blackjack
            if (playerHand.GetScore() == 21)
            {
                Console.WriteLine("Player has a natural blackjack!");
                return;
            }
            if (dealerHand.GetScore() == 21)
            {
                Console.WriteLine("Dealer has a natural blackjack!");
                return;
            }

            // Player's turn
            while (true)
            {
                Console.WriteLine("Player's hand:");
                playerHand.DisplayHand();
                Console.WriteLine("Player's score: " + playerHand.GetScore());
                Console.WriteLine();

                Console.WriteLine("Dealer's face-up card:");
                dealerHand.DisplayFirstCard();
                Console.WriteLine();

                Console.Write("Hit or stand? (h/s): ");
                string input = Console.ReadLine().ToLower();

                if (input == "h")
                {
                    playerHand.AddCard(deck.DealCard());
                    Console.WriteLine();
                }
                else if (input == "s")
                {
                    Console.WriteLine();
                    break;
                }

                // Check for bust
                if (playerHand.GetScore() > 21)
                {
                    Console.WriteLine("Player busts!");
                    return;
                }
            }

            // Dealer's turn
            while (dealerHand.GetScore() < 17)
            {
                dealerHand.AddCard(deck.DealCard());
            }

            Console.WriteLine("Player's hand:");
            playerHand.DisplayHand();
            Console.WriteLine("Player's score: " + playerHand.GetScore());
            Console.WriteLine();

            Console.WriteLine("Dealer's hand:");
            dealerHand.DisplayHand();
            Console.WriteLine("Dealer's score: " + dealerHand.GetScore());
            Console.WriteLine();

            // Check for win
            if (dealerHand.GetScore() > 21)
            {
                Console.WriteLine("Dealer busts! Player wins " + bet + " chips!");
            }
            else if (playerHand.GetScore() > dealerHand.GetScore())
            {
                Console.WriteLine("Player wins " + bet + " chips!");
            }
            else if (dealerHand.GetScore() > playerHand.GetScore())
            {
                Console.WriteLine("Dealer wins " + bet + " chips!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
