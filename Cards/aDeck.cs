using System;
using System.Collections.Generic;

namespace Cards{
    public abstract class aDeck{
        public abstract void randShuffle();
        public abstract void cutDeck(int cutPos);
        public abstract List<Card> drawCards(int amt);
        public abstract Card drawCard();
    }
}