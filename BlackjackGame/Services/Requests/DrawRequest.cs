using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame.Services.Requests
{
    public class DrawRequest
    {
        public string DeckID { get; set; }
        public int NumberOfCards { get; set; }
        public string[] ValidCards { get; set; }
    }
}
