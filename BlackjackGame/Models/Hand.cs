using BlackjackGame.Services;
using BlackjackGame.Services.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame.Models
{
    public class Hand
    {
        public List<Card> Cards { get; set; }
        public string DeckID { get; set; }
        public DataService Data { get; set; }

        public Hand(string _DeckID,DataService _Service, int StartingCardCount)
        {
            Setup(_DeckID, _Service);
            Draw(StartingCardCount);
        }
        public Hand(string _DeckID, DataService _Service)
        {
            Setup(_DeckID, _Service);
        }
        private void Setup(string _DeckID, DataService _Service)
        {
            Data = _Service;
            DeckID = DeckID;
        }

        public void Draw(int ThisMany)
        {
            DrawRequest drawReq = new DrawRequest();
            drawReq.DeckID = DeckID;
            drawReq.NumberOfCards = ThisMany;
            var response = Data.Draw(drawReq).Cards;
            foreach (var newCard in response)
            {
                Cards.Add(newCard);
            }
        }
        //checks for both card name and same card
        public bool RemoveCard(Card thisOne)
        {
            if (Cards.Contains(thisOne))
            {
                Cards.Remove(thisOne);
                return true;
            }
            else
            {
                int index = getIndex(thisOne);
                if(index != -1)
                {
                    Cards.Remove(Cards[index]);
                    return true;
                }
            }
            return false;
        }
        private int getIndex(Card thisOne)
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                if(Cards[i].CardValue == thisOne.CardValue) {
                    return i;
                }
            }
            return -1;
        }
        
        public int getHandSize()
        {
            return Cards.Capacity;
        }
    }
}
