using BlackjackGame.Services.Requests;
using BlackjackGame.Services.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame.Services
{
    public class DataService
    {
        private const string CARD_API = "http://deckofcardsapi.com/api";
        public string newDecks(int numberOfDecks)
        {
            Uri serviceUri = new Uri($"{CARD_API}/deck/new/shuffle/?deck_count={numberOfDecks}");
            ServiceManager svcMgr = new ServiceManager(serviceUri);
            var response = svcMgr.CallService<DeckResponse>();
            return response.DeckID;
        }
        //TODO Fix This
        public DrawResponse Draw(DrawRequest drawReq)
        {
            Uri serviceuri = new Uri($"{CARD_API}/deck/{drawReq.DeckID}/draw/?count={drawReq.NumberOfCards}");
            ServiceManager svcMgr = new ServiceManager(serviceuri);
            return svcMgr.CallService<DrawResponse>();
        }
    }
}
