using System.Collections.Generic;

namespace Cards{
    public class Hand{
        private List<Card> heldCards;
        private int handSize;
        public Hand(int handSize){
            heldCards = new List<Card>(handSize);
        }
        public Hand(List<Card> cards){
            heldCards = cards;
            handSize = cards.Count;
            heldCards.Sort();
        }
        public void AddCard(Card card){
            heldCards.Add(card);
            heldCards.Sort();
        }
        public string toString(){
            string result="Hand Contents:{\n";
            foreach (Card c in heldCards){
                result+=c.toString();
                result+="\n";
            }
            result+="}";
            return result;
        }
    }
}