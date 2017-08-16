using System;
using static System.Console;
namespace CardLib
{
    public class Card
    {
        #region field
        private readonly Rank rank;
        private readonly Suit suit;
        #endregion field
        #region constructor
        public Card(Rank newRank, Suit newSuit)
        {
            rank = newRank;
            suit = newSuit;
        }
        private Card()
        {

        }
        #endregion constructor
        #region override_methods
        public override string ToString() => $"The {rank} of {suit} s";
        #endregion override_methods
    }
}
