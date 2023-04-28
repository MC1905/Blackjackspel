using System;
using System.Collections.Generic;
using System.Xml.Linq;
namespace Blackjackspel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            while (true)
            {
                Console.WriteLine("\nPress 'N' to start a new game, 'Q' to quit, 'T' for tutorial.");
                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.N)
                {
                    StartGame();
                }

                else if (key == ConsoleKey.Q)
                {
                    break;
                }
                else if (key == ConsoleKey.T)
                {
                    ShowTutorial();
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please try again.");
                }
            }

            Console.WriteLine("\nThank you for playing Blackjack!");
        }

        static void StartGame()
        {
            Console.WriteLine("Starting a new game...");
            const double initialMoney = 100.00;

            double playerMoney = initialMoney;
            Console.WriteLine($"your money count is: {playerMoney}$");
        }

        static void ShowTutorial()
        {
            Console.ReadLine(); // Wait for user to press Enter
            Console.WriteLine("Stap 1: Het doel van het speler. Het doel van blackjack is om de dealer te verslaan door een hand te krijgen die dichter bij 21 punten ligt dan de hand van de dealer, zonder over 21 punten te gaan.");
            Console.ReadLine(); // Wait for user to press Enter
            Console.WriteLine("Stap 2: Kaartwaarden. De kaarten 2 tot en met 10 hebben de waarde die op de kaart staat aangegeven. De plaatjes (boer, vrouw, koning) zijn elk 10 punten waard. De aas kan als 1 of 11 punten worden geteld, afhankelijk van wat gunstiger is voor de hand.");
            Console.ReadLine(); // Wait for user to press Enter
            Console.WriteLine("Stap 3: Het delen van de kaarten. Het spel begint met het delen van twee kaarten aan elke speler, inclusief de dealer. De spelers krijgen hun kaarten open, terwijl de dealer één kaart open en één kaart dicht (ook wel de \"hole card\" genoemd) krijgt.");
            Console.ReadLine(); // Wait for user to press Enter
            Console.WriteLine("Stap 4: Speler beslist om te passen of kaart te vragen. De spelers kunnen nu beslissen of ze willen passen (geen extra kaarten nemen) of kaarten willen vragen (een extra kaart nemen om hun hand te verbeteren).");
            Console.ReadLine(); // Wait for user to press Enter
            Console.WriteLine("Stap 5: Handwaarde berekenen. De spelers moeten de waarde van hun hand berekenen door de punten van hun kaarten op te tellen. Ze kunnen beslissen om extra kaarten te vragen totdat ze tevreden zijn met hun handwaarde of totdat ze over 21 punten gaan (wat resulteert in een \"bust\" en verlies van de hand).");
            Console.ReadLine(); // Wait for user to press Enter
            Console.WriteLine("Stap 6: Dealer onthult de hole card. Als alle spelers hun beslissingen hebben genomen, onthult de dealer zijn hole card.");
            Console.ReadLine(); // Wait for user to press Enter
            Console.WriteLine("Stap 7: Dealer speelt volgens de regels. De dealer moet volgens bepaalde regels spelen, meestal als volgt: als de dealer 16 punten of minder heeft, moet hij een extra kaart nemen. Als de dealer 17 punten of meer heeft, moet hij passen.");
            Console.ReadLine(); // Wait for user to press Enter
            Console.WriteLine("Stap 8: Handen vergelijken. Als de dealer klaar is met spelen, worden de handen van de spelers en de dealer vergeleken. Degene met een handwaarde die het dichtst bij 21 ligt zonder over 21 te gaan, wint de hand.");
            Console.ReadLine(); // Wait for user to press Enter
            Console.WriteLine("Stap 9: Uitbetaling en nieuwe ronde. Afhankelijk van de uitkomst van de hand worden de winnende inzetten uitbetaald en verliezende inzetten verzameld. Een nieuwe ronde begint en spelers kunnen opnieuw inzetten en kaarten ontvangen.");

        }
    }


}
