using System;
namespace CardLib
{
    public class Deck
    {
        private Card[] cards;
        public Deck()
        {
            cards = new Card[52];
            for (int suitValue = 0; suitValue < 4; suitValue++)
                for (int rankValue = 1; rankValue <= 13; rankValue++)
                {
                    cards[suitValue * 13 + rankValue - 1] = new Card((Rank)rankValue, (Suit)suitValue);
                }
        }
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum < 52)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException(cardNum.ToString()));
        }
        public void Shuffle()
        {
            Card[] newDeck = new Card[52];
            bool[] assignedIndex = new bool[52];
            Random sourceGen = new Random();
            for (int index = 0; index < 52; index++)
            {
                int newIndex = 0;
                bool duplicatedIndex = true;
                while (duplicatedIndex)
                {
                    newIndex = sourceGen.Next(52); // random value will be between 0 and 51 (not 52)
                    if (assignedIndex[newIndex] == false)
                        duplicatedIndex = false;
                }
                assignedIndex[newIndex] = true;
                newDeck[newIndex] = cards[index];
            }
            newDeck.CopyTo(cards, 0);
        }
    }
}
