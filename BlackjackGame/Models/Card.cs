using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using BlackjackGame.ENUM;

namespace BlackjackGame.Models
{
    [DataContract]
    public class Card
    {
        private int cardValue;
        public int CardValue {
            get
            {
                int cardNumericVal = 0;
                if( CardValueStr.Equals("KING")||
                    CardValueStr.Equals("QUEEN") ||
                    CardValueStr.Equals("JACK"))
                {
                    cardNumericVal = 10;
                }
                else if(CardValueStr.Equals("ACE"))
                {
                    cardNumericVal = 11;
                }
                else
                {
                    cardNumericVal = int.Parse(CardValueStr);
                }
                return cardNumericVal;
            }
            set
            {
                cardValue = value;
            }
        }

        [DataMember(Name = "image")]
        public string ImgLocation { get; set; }
        [DataMember(Name = "value")]
        public string CardValueStr { get; set; }
        [DataMember(Name = "suit")]
        public string SuitValueStr { get; set; }
        public Suite CardSuit
        {
            get
            {
                Suite suit;
                switch (SuitValueStr)
                {
                    case "CLUBS":
                        suit = Suite.Clubs;
                        break;
                    case "DIAMONDS":
                        suit = Suite.Diamonds;
                        break;
                    case "HEARTS":
                        suit = Suite.Hearts;
                        break;
                    case "SPADES":
                        suit = Suite.Spades;
                        break;
                    default:
                        suit = Suite.Spades;
                            break;
                }
                return suit;
            }
            set
            {
            }
        }
    }
}
