using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_App.Scores
{
    class GameResult
    {
        GameName _GameName;
        int _PlayerScore;
        int _ComputerScore;
        WinnerName _winnerName;

        public GameName GameName
        {
            get { return _GameName; }
            set { _GameName = value; }
        }

        public int PlayerScore
        {
            get { return _PlayerScore; }
            set
            {
                if (value > 0)
                {
                    _PlayerScore = value;
                }
            }
        }

        public int ComputerScore
        {
            get { return _ComputerScore; }
            set
            {
                if (value > 0)
                {
                    _ComputerScore = value;
                }
            }
        }

        public WinnerName Winner
        {
            get { return _winnerName; }
            set { _winnerName = value; }
        }

        public GameResult(GameName gameName, int playerScore, int computerScore, WinnerName winnerName)
        {
            GameName = gameName;
            PlayerScore = playerScore;
            ComputerScore = computerScore;
            Winner = winnerName;
        }

        public override string ToString()
        {
            return $"Game is:{GameName} Player score is:{PlayerScore} Computer score is:{ComputerScore} The winner is:{Winner}";
        }
    } //end of gameresult
}
