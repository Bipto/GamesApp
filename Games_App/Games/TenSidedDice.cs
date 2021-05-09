using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_App.Games
{
    /// <summary>
    /// Class to create TenSidedDice. It inherits two properties Num and Colour from dice class and a base constructor method.
    /// </summary>
    class TenSidedDice : Dice
    {
        /// <summary>
        /// Overrides Num property to allow numbers between 1 an 10
        /// </summary>
        public override int Num //2
        {
            get { return _Num; }    //2a
            set                     //2b
            {
                if ((value > 0) && (value <= 10))   //2b-1
                {
                    _Num = value;
                }

                else
                {
                    throw new Exception("Bad number : " + value);
                }
            }
        } //end of Num

        /// <summary>
        /// Overrides base method to generate a number between 1 and 10
        /// </summary>
        public override void GenerateNumber()
        {
            Num = random.Next(1, 10);   //key differences
        }   //end of generate number

        /// <summary>
        /// Constructor to make TenSidedDice it uses Dice method to create a base object then generates a number between 1 and 10
        /// </summary>
        /// <param name="inColour"></param>
        public TenSidedDice(string inColour) : base(inColour)
        {
            GenerateNumber();
        }

    } //end of ten sided dice
}
