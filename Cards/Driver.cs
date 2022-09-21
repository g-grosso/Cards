using System;
using System.Linq;
using System.Collections.Generic;
namespace Cards{
    class Driver{
        static void Main(string[] args){
            Deck pokerDeck = new Deck(Enumerable.Range(1,13).ToArray(), new string[] {"Spades","Diamonds","Clubs","Hearts"});
            pokerDeck.randShuffle();
            List<Hand> hands = new List<Hand>(5);
            for (int i = 0; i < 5; i++)
            {
                hands.Add(new Hand(pokerDeck.drawCards(5)));
                Console.WriteLine(hands[i].toString());
            }
        }
    }
}