using System;
namespace Cards{
    public abstract class aCard : IComparable{
        public abstract int getVal();
        public abstract string getSuit();
        public abstract string toString();
        public abstract int CompareTo(object obj);
    }
}