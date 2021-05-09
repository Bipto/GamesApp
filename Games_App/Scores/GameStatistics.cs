using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_App.Scores
{
    /// <summary>
    /// Enum uses to store the winner of the game
    /// </summary>
    public enum WinnerName
    {
        Player,
        Computer,
        Draw
    }

    /// <summary>
    /// Enum used to store the names of the games that can be played
    /// </summary>
    enum GameName
    {
        None,
        Dice,
        TenSidedDice,
        HighCard,
        LowCard,
        WildEights,
        Blackjack
    }    

    class GameStatistics
    {
        public List<GameResult> _GameResults;
        private decimal _AveragePlayerScore = 0;
        private int _MinimumPlayerScore = 0;
        private int _MaximumPlayerScore = 0;
        private int _NumberOfPlayerWins = 0;
        private decimal _Percentage = 0;

        private int _TotalGames = 0;

        public decimal Average
        {
            get { return _AveragePlayerScore; }
            set { _AveragePlayerScore = value; }
        }

        public int Minimum
        {
            get { return _MinimumPlayerScore; }
            set { _MinimumPlayerScore = value; }
        }

        public int Maximum
        {
            get { return _MaximumPlayerScore; }
            set { _MaximumPlayerScore = value; }
        }

        public int NumberOfPlayerWins
        {
            get { return _NumberOfPlayerWins; }
            set { _NumberOfPlayerWins = value; }
        }

        public decimal Percentage
        {
            get { return _Percentage; }
            set
            {
                if ((value >= 0) && (value <= 100))
                {
                    _Percentage = value;
                }

                else
                {
                    throw new Exception("Number is not between 0 and 100.");
                }
            }
        }

        public int Count
        {
            get { return _GameResults.Count; }
        }

        public List<GameResult> Results
        {
            get { return _GameResults; }
        }

        public GameStatistics()
        {
            _GameResults = new List<GameResult>();
        }

        public void Add(GameResult result)
        {
            _TotalGames++;
            if (result.Winner == WinnerName.Player)
                NumberOfPlayerWins++;
            _GameResults.Add(result);
        }

        public void CalculateStatistics()
        {
            int max = 0;
            int min = 10000;
            int value = 0;
            int total = 0;
            int numOfResults = _GameResults.Count;

            for (int pointer = 0; pointer < numOfResults; pointer++)
            {
                value = _GameResults[pointer].PlayerScore;
                total = total + value;

                if (value < min)
                {
                    min = value;
                }

                if (value > max)
                {
                    max = value;
                }
            }

            if (numOfResults != 0)
            {
                Average = total / numOfResults;
                Maximum = max;
                Minimum = min;

                CalculatePercentageOfWins();
            }
        }

        private void CalculatePercentageOfWins()
        {            
            Percentage = 100 / _TotalGames * NumberOfPlayerWins;
        }

        public void Sort(IComparer<GameResult> comparisonMethod)
        {
            _GameResults.Sort(comparisonMethod);
        }

        public override string ToString()
        {
            return _GameResults.ToString();
        }
    }

    class SortByMaximum : IComparer<GameResult>
    {
        public int Compare(GameResult r1, GameResult r2)
        {
            if (r1.PlayerScore < r2.PlayerScore)
                return 1;
            if (r1.PlayerScore > r2.PlayerScore)
                return -1;
            return 0;
        }
    }

    class SortByMinimum : IComparer<GameResult>
    {
        public int Compare(GameResult r1, GameResult r2)
        {
            if (r1.PlayerScore > r2.PlayerScore)
                return 1;
            if (r2.PlayerScore < r2.PlayerScore)
                return -1;
            return 0;
        }
    }

    class SortByGameNameAscending : IComparer<GameResult>
    {
        public int Compare(GameResult r1, GameResult r2)
        {
            return String.Compare(r1.GameName.ToString(), r2.GameName.ToString());
        }
    }

    class SortByGameNameDescending : IComparer<GameResult>
    {
        public int Compare(GameResult r1, GameResult r2)
        {
            return String.Compare(r2.GameName.ToString(), r1.GameName.ToString());
        }
    }
}
