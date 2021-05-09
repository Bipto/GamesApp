using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_App.Games
{
    /// <summary>
    /// Class to create Dice. It has two properties Num and Colour.
    /// </summary>
    class Dice
    {
        protected int _Num;   //1
        protected string _Colour;
        protected static Random random = new Random();

        public virtual int Num      //2
        {
            get { return _Num; }   //2a
            set                    //2b
            {
                if ((value > 0) && (value <= 6)) //2b-1
                {
                    this._Num = value;
                }

                else
                {
                    throw new Exception("Bad number : " + value);   //2b-2
                }
            }
        } //end of num

        public string Colour    //3
        {
            get         //3a
            {
                return _Colour;
            }

            set         //3b
            {
                if (value.Length > 0 && (value.Length <= 10))   //3b-2
                {
                    this._Colour = value;
                }

                else
                {
                    throw new Exception("Bad colour : " + value);   //3b-2b
                }
            }
        } //end of colour

        /// <summary>
        /// Default Dice constructor that populates a Dice object with Num 1 and Color of Black
        /// </summary>
        public Dice() //4
        {
            Num = 1;
            Colour = "Black";
        } //end of dice constructor

        /// <summary>
        /// Dice constructor that populates a Dice object with passed inNum and inColour values.
        /// </summary>
        /// <param name="inNum"></param>
        /// <param name="inColour"></param>
        public Dice(int inNum, string inColour) //5
        {
            Num = inNum;
            Colour = inColour;
        } //end of dice constructor

        /// <summary>
        /// Generates a number between 1 and 6
        /// </summary>
        public virtual void GenerateNumber()    //6b
        {
            Num = random.Next(1, 6);            //6c
        } //end of generate number

        /// <summary>
        /// Dice constructor that populates a Dice object with passed colour and random generated number.
        /// </summary>
        /// <param name="colour"></param>
        public Dice(string colour) //8
        {
            GenerateNumber();
            Colour = colour;
        } //end of dice constructor

        /// <summary>
        /// Overrides ToString method to describe the dice object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Colour + " " + this.Num;
        } //end of ToString method

    } //end of class
}
