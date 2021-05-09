using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_App.Games
{
    enum CardSuit
    {
        Spades, Clubs, Diamonds, Hearts
    }

    enum CardName
    {
        Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13
    }

    class PlayingCard : Dice
    {
        public CardSuit Suit { get; set; }
        public CardName Name { get; set; }

        public override int Num //2
        {
            get { return _Num; }    //2a
            set                     //2b
            {
                if ((value > 0) && (value <= 13))   //2b-1
                {
                    _Num = value;
                }

                else
                {
                    throw new Exception("Bad number : " + value);
                }
            }
        } //end of Num

        public override void GenerateNumber()
        {
            Num = random.Next(1, 13);
        } //end of GenerateNumber method

        public void GenerateSuit()
        {
            int suitNum = random.Next(0, 3);
            Suit = (CardSuit)suitNum;
        }

        public override string ToString()
        {
            return this.Colour + " " + this.Name + " worth " + this.Num + " points";
        } //end of ToString method

        public PlayingCard(int inNum, string inColour, CardSuit inSuit, CardName inName) : base(inNum, inColour)
        {
            Suit = inSuit;
        }

        public PlayingCard(int inNum, string inColour, CardSuit inSuit) : base(inNum, inColour)
        {
            Name = (CardName)inNum;
            Suit = inSuit;
        }

        public PlayingCard(string inColour, CardSuit inSuit) : base(inColour)
        {
            GenerateNumber();
            Suit = inSuit;
            Name = (CardName)base.Num;
        }

        public PlayingCard()
        {
            GenerateNumber();
            GenerateSuit();
            Name = (CardName)base.Num;
        }

    } //end of class

}
