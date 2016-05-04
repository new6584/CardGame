using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackjackGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackGame.Services.Responses;

namespace BlackjackGame.Services.Tests
{
    [TestClass()]
    public class ServiceManagerTests
    {
        [TestMethod()]
        public void CallServiceTest()
        {
            ServiceManager sm = 
                new ServiceManager(
                    new Uri("http://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1"));
            var response = sm.CallService<DeckResponse>();
            Assert.IsNotNull(response);
        }
    }
}