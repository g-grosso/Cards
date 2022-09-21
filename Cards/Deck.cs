using System;
using System.Collections.Generic;

namespace Cards{
    public class Deck: aDeck{
        private List<Card> cards;
        private List<Card> drawnCards;
        //Default Constructor for standard deck of cards.
        public Deck(int[] values, string[] suits){
            cards = new List<Card>(values.Length*suits.Length);
            drawnCards = new List<Card>();
            Dictionary<int,string> specialValues = new Dictionary<int,string>(){
                {1,"Ace"},
                {11,"Jack"},
                {12,"Queen"},
                {13,"King"}};
            foreach (string suit in suits){
                    foreach (int value in values){
                        if((specialValues.ContainsKey(value))){
                        cards.Add(new Card(value,suit,specialValues[value]));
                        }
                        else{
                            cards.Add(new Card(value,suit));
                        }
                    }
                }
        }
        //Constructor for Decks with different specially named cards.
        //Example: For Uno, a Dictionary associating values 10, 11, and 12 to Skip, Reverse, and Draw 2 could be used.
        public Deck(int[] values, string[] suits, Dictionary<int, string> specialValues){
                    cards = new List<Card>(values.Length*suits.Length);
                    drawnCards = new List<Card>();
                    foreach (string suit in suits){
                        foreach (int value in values){
                            if((specialValues.ContainsKey(value))){
                                cards.Add(new Card(value,suit,specialValues[value]));
                            }
                            else{
                                cards.Add(new Card(value,suit));
                            }
                        }
                    }
                }
        //Shuffle cards using the Fisher-Yates algorithm.
        public override void randShuffle(){
            Random rand = new Random();
            int pos = cards.Count;
            while(pos>1){
                int swap = rand.Next(pos--);
                (cards[pos],cards[swap])=(cards[swap],cards[pos]); 
            }
        }
        public override void cutDeck(int cutPos){
            if(cutPos>=cards.Count){
                return;
            }
            List<Card> temp = cards.GetRange(0,cutPos);
            cards.RemoveRange(0,cutPos);
            cards.AddRange(temp);
        }
        public override List<Card> drawCards(int amt){
            List<Card> dealtCards = cards.GetRange(0,amt);
            drawnCards.AddRange(dealtCards);
            cards.RemoveRange(0,amt);
            return dealtCards;
        }
        public override Card drawCard(){
            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            drawnCards.Add(dealtCard);
            return dealtCard;
        }
        public Card topCard(){
            return cards[0];
        }
    }
}