using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackjackGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackGame.Services.Requests;

namespace BlackjackGame.Services.Tests
{
    [TestClass()]
    public class DataServiceTests
    {
        [TestMethod()]
        public void newDecksTest()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void DrawTest()
        {
            DataService ds = new DataService();
            DrawRequest drawReq = new DrawRequest();
            drawReq.DeckID = "hu3p337wzncc";
            drawReq.NumberOfCards = 2;
            var x = ds.Draw(drawReq);
            Assert.Fail();
        }
    }
}