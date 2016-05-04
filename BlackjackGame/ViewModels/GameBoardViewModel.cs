using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackGame.Models;
using BlackjackGame.Services;
using BlackjackGame.Services.Requests;
using BlackjackGame.Views;

namespace BlackjackGame.ViewModels
{

    public class GameBoardViewModel
    {
        #region MyRegion Game State Properties
        public int PlayerScore { get; set; }
        public int DealerScore { get; set; }
        public string DeckId { get; set; }
        public Hand PlayerHand { get; set; }
        public Hand DealerHand { get; set; }
        public GameWindow UI { get; set; }
        #endregion

        public GameBoardViewModel(GameWindow ui)
        {
            UI = ui;
            NewGame();
        }

        private void NewGame()
        {
            DataService dataService = new DataService();
            string deckID = dataService.newDecks(1);
            int StartingCardCount = 7;
            //starting hands
            PlayerHand = new Hand(DeckId,dataService, StartingCardCount);
            DealerHand = new Hand(DeckId, dataService, StartingCardCount);
            PlayerScore = 0;
            DealerScore = 0;
            //combine like cards
            //players turn
        }

        public void PlayersTurn()
        {
            //TODO: player stuff and score piles
            //wait for click
        }
        public void DealersTurn()
        {
            bool check = false;
            do
            {
                if(DealerHand.getHandSize() == 0)
                {
                    DealerHand.Draw(2);
                    break;
                }

                ShowHands();
                Random rand = new Random();
                int cardIndex = rand.Next(0, DealerHand.getHandSize());
                check = CheckHand(PlayerHand, DealerHand.Cards[cardIndex]);

                if (check)
                {
                    DealerHand.RemoveCard(DealerHand.Cards[cardIndex]);
                    DealerScore++;
                    //add to score pile 
                }
            } while (check);
            DealerHand.Draw(1);
            ShowHands();
        }
        private bool CheckHand(Hand OtherGuy, Card MyCard)
        {
            return OtherGuy.RemoveCard(MyCard);
        }
        public void ShowHands()
        {
            foreach (Card OneCard in PlayerHand.Cards)
            {
                UI.addToPlayerField(OneCard.ImgLocation);
            }
            for (int i = 0; i < DealerHand.getHandSize(); i++)
            {
                UI.addToDealerField("/Assets/CardBack.png");
            }
        }       
    }
}
