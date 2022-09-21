using System;

namespace Cards{
    public class Card : aCard{
        private int value;
        private string suit;
        private string special;
        public Card(int val, string suit){
            value=val;
            this.suit=suit;
        }
        public Card(int val, string suit, string spec){
            value=val;
            this.suit=suit;
            special=spec;
        }
        public override int getVal(){
            return value;
        }
        public override string getSuit(){
            return suit;
        }
        public override string toString(){
            if(special!=null){
                return(String.Format("{0,5} of {1,-8}",special,suit));
            }
            else return(String.Format("{0,5} of {1,-8}",value,suit));
        }
        public override int CompareTo(object obj){
            if(obj==null) return 1;
            Card other = obj as Card;
            if(other!=null){
                return this.value-other.value;
            }
            else{
                throw new ArgumentException("Object is not a Card");
            }
        }
    }
}