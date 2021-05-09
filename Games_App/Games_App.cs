using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Games_App.Games;
using Games_App.Scores;

namespace Games_App
{ 
    /// <summary>
    /// Games_App inherits from Form to create a windows form gui interface
    /// Allows the user to play a number of games and see feedback and statistics on their performance via Event Handlers.    /// 
    /// </summary>
    public partial class Games_App : Form
    {
        /// <summary>
        /// Creates global variables
        /// </summary>
        string game;
        int playerScore = 0;
        int computerScore = 0;
        string playerName = "";
        GameStatistics gameStatistics = new GameStatistics();
        GameStatistics filteredStatistics;

        public Games_App()
        {
            InitializeComponent();
        }      

        private void Games_App_Load(object sender, EventArgs e)
        {
            this.MitSave.Click += MitSave_Click;
            this.MitLoad.Click += MitLoad_Click;
            this.MitQuit.Click += MitQuit_Click;
            ResetInterface();
        }

        /// <summary>
        /// Clears interface controls and populates cbxGame with available games and makes buttons unavailable initially
        /// </summary>
        private void ResetInterface()
        {
            TbxName.Text = "";
            CbxGame.SelectedItem = null;

            CbxGame.Items.Clear();
            CbxGame.Items.Add("Dice");
            CbxGame.Items.Add("Ten Sided Dice");
            CbxGame.Items.Add("High Card");
            CbxGame.Items.Add("Low Card");
            CbxGame.Items.Add("Wild Eights");
            CbxGame.Items.Add("Black Jack");

            CbxGame.Enabled = false;
            BtnPlayGame.Enabled = false;
            CbxGameFilter.Enabled = false;
            CbxScoreFilter.Enabled = false;
            CbxGameFilter.SelectedIndex = 0;
            CbxScoreFilter.SelectedIndex = 0;
            MitSave.Enabled = false;
            MitLoad.Enabled = false;
        }

        /// <summary>
        /// Allows you to select a game after you have entered a player name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (TbxName.Text.Length > 0)
            {
                CbxGame.Enabled = true;
                CbxGameFilter.Enabled = true;
                CbxScoreFilter.Enabled = true;
                MitSave.Enabled = true;
                MitLoad.Enabled = true;
            }

            else
            {
                CbxGame.Enabled = false;
                CbxGameFilter.Enabled = false;
                CbxScoreFilter.Enabled = false;
                MitSave.Enabled = false;
                MitLoad.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlayGame_Click(object sender, EventArgs e)
        {
            string feedback = "";
            playerName = TbxName.Text.TrimEnd();

            switch (game)
            {
                case "Dice":
                    feedback = playDiceGame();
                    break;
                case "Ten Sided Dice":
                    feedback = playTenSidedDiceGame();
                    break;
                case "High Card":
                    feedback = playHighCardGame();
                    break;
                case "Low Card":
                    feedback = playLowCardGame();
                    break;
                case "Wild Eights":
                    feedback = playWildEightsGame();
                    break;
                case "Black Jack":
                    feedback = playBlackJackGame();
                    break;
            }

            DisplayResultsInListView(gameStatistics);
            DisplayStatisticsInListView(gameStatistics);
            MessageBox.Show(feedback, "Game Result", MessageBoxButtons.OK);
        }

        private void DisplayResultsInListView(GameStatistics statistics)
        {
            LsvGameResults.Items.Clear();
            for (int i = 0; i < statistics._GameResults.Count; i++)
            {
                GameResult result = statistics._GameResults[i];
                int number = i + 1;

                LsvGameResults.Items.Add(new ListViewItem(new[]
                {                    
                    number.ToString(), result.GameName.ToString(), result.PlayerScore.ToString(), result.ComputerScore.ToString(), result.Winner.ToString()
                }));
            }
        }

        private void DisplayStatisticsInListView(GameStatistics statistics)
        {
            statistics.CalculateStatistics();
            LsvStatistics.Items.Clear();
            LsvStatistics.Items.Add(new ListViewItem(new[]{
                statistics.NumberOfPlayerWins.ToString(), $"{statistics.Percentage.ToString()}%", statistics.Average.ToString(), statistics.Minimum.ToString(), gameStatistics.Maximum.ToString()
                
            }));
        }

        private void AddScore(Scores.GameName name, WinnerName winnerName)
        {
            gameStatistics.Add(new GameResult(name, playerScore, computerScore, winnerName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Feedback i.e. the result of the game</returns>
        private string playDiceGame()
        {
            string feedback = ""; //1

            Dice playerDice = new Dice("Blue"); //2
            playerScore = playerDice.Num;

            Dice computerDice = new Dice("Red"); //3
            computerScore = computerDice.Num;


            ///calculate percentage wins for the computer and report
            if (playerScore > computerScore)
            {
                AddScore(Scores.GameName.Dice, WinnerName.Player);
                feedback = $"{playerName} wins as {playerScore} is higher than {computerScore}"; //4a
            }

            else if (computerScore > playerScore)
            {
                AddScore(Scores.GameName.Dice, WinnerName.Computer);
                feedback = $"Computer wins as {computerScore} is higher than {playerScore}"; //4b
            }

            else
            {
                AddScore(Scores.GameName.Dice, WinnerName.Draw);
                feedback = $"Draw as {playerScore} matches {computerScore}"; //4c
            }
            
            return feedback;
        }

        private string playTenSidedDiceGame()
        {
            string feedback = ""; //1

            TenSidedDice playerDice = new TenSidedDice("Blue"); //2
            playerScore = playerDice.Num;

            TenSidedDice computerDice = new TenSidedDice("Red"); //3
            computerScore = computerDice.Num;

            ///calculate percentage wins for the computer and report
            if (playerScore > computerScore)
            {
                AddScore(Scores.GameName.TenSidedDice, WinnerName.Player);
                feedback = $"{playerName} wins as {playerScore} is higher than {computerScore}"; //4a
            }

            else if (computerScore > playerScore)
            {
                AddScore(Scores.GameName.TenSidedDice, WinnerName.Computer);
                feedback = $"Computer wins as {computerScore} is higher than {playerScore}"; //4b
            }

            else
            {
                AddScore(Scores.GameName.TenSidedDice, WinnerName.Draw);
                feedback = $"Draw as {playerScore} matches {computerScore}"; //4c
            }

            return feedback;
        }

        private string playHighCardGame()
        {
            string feedback = ""; //1

            PlayingCard playerCard = new PlayingCard("Red", CardSuit.Diamonds);
            playerScore = playerCard.Num;

            PlayingCard computerCard = new PlayingCard("Black", CardSuit.Spades);
            computerScore = computerCard.Num;

            if (playerScore > computerScore)
            {
                AddScore(GameName.HighCard, WinnerName.Player);
                feedback = $"{playerName} wins as {playerScore} is higher than {computerScore}";
            }

            else if (computerScore > playerScore)
            {
                AddScore(GameName.HighCard, WinnerName.Computer);
                feedback = $"Computer wins as {computerScore} is higher than {playerScore}";
            }

            else if (playerScore == computerScore)
            {
                AddScore(GameName.HighCard, WinnerName.Draw);
                feedback = $"Draw as {playerScore} matches {computerScore}";
            }

            return feedback;
        }

        private string playLowCardGame()
        {
            string feedback = ""; //1

            PlayingCard playerCard = new PlayingCard("Red", CardSuit.Diamonds);
            playerScore = playerCard.Num;

            PlayingCard computerCard = new PlayingCard("Black", CardSuit.Spades);
            computerScore = computerCard.Num;

            if (playerScore < computerScore)
            {
                AddScore(GameName.LowCard, WinnerName.Player);
                feedback = $"{playerName} wins as {playerScore} is lower than {computerScore}";
            }

            else if (computerScore < playerScore)
            {
                AddScore(GameName.LowCard, WinnerName.Computer);
                feedback = $"Computer wins as {computerScore} is lower than {playerScore}";
            }

            else if (playerScore == computerScore)
            {
                AddScore(GameName.LowCard, WinnerName.Draw);
                feedback = $"Draw as {playerScore} matches {computerScore}";
            }

            return feedback;
        }

        private string playWildEightsGame()
        {
            string feedback = "";

            TenSidedDice playerDice = new TenSidedDice("Blue");
            playerScore = playerDice.Num;
            TenSidedDice computerDice = new TenSidedDice("Red");
            computerScore = computerDice.Num;

            if (playerScore == computerScore)
            {
                AddScore(GameName.WildEights, WinnerName.Draw);
                feedback = $"Draw as {playerScore} matches {computerScore}";
            }

            else if (playerScore == 8)
            {
                AddScore(GameName.WildEights, WinnerName.Player);
                feedback = $"{playerName} wins as they got an eight";
            }

            else if (computerScore == 8)
            {
                AddScore(GameName.WildEights, WinnerName.Computer);
                feedback = $"Computer wins as they got an eight";
            }

            else if (playerScore > computerScore)
            {
                AddScore(GameName.WildEights, WinnerName.Player);
                feedback = $"{playerName} wins because {playerScore} is higher than {computerScore}";
            }

            else
            {
                AddScore(GameName.WildEights, WinnerName.Computer);
                feedback = $"Computer wins as {computerScore} is higher than {playerScore}";
            }

            return feedback;
        }

        private string playBlackJackGame()
        {
            string feedback = "";

            return feedback;
        }

        /// <summary>
        /// Enables the BtnPlayGame button when a user selects an option from the drop down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxGame.SelectedIndex != -1)
            {
                BtnPlayGame.Enabled = true;
                game = CbxGame.SelectedItem.ToString();
            }
        }

        private void CbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filteredStatistics = new GameStatistics();
            GameName filter = GetGameName(CbxGameFilter.Text);
            if (filter == GameName.None)
            {
                filteredStatistics = gameStatistics;
            }

            else
            {
                foreach (GameResult result in gameStatistics.Results)
                {
                    if (result.GameName == filter)
                    {
                        filteredStatistics.Add(result);
                    }
                }                
            }

            DisplayResultsInListView(filteredStatistics);
            DisplayStatisticsInListView(filteredStatistics);
        }

        private GameName GetGameName(string filterText)
        {
            GameName filter = GameName.None;

            if (CbxGameFilter.Text == "Dice")
            {
                filter = GameName.Dice;
            }

            else if (CbxGameFilter.Text == "Ten Sided Dice")
            {
                filter = GameName.TenSidedDice;
            }

            else if (CbxGameFilter.Text == "Low Card")
            {
                filter = GameName.LowCard;
            }

            else if (CbxGameFilter.Text == "High Card")
            {
                filter = GameName.HighCard;
            }

            else if (CbxGameFilter.Text == "Wild Eights")
            {
                filter = GameName.WildEights;
            }

            else if (CbxGameFilter.Text == "Blackjack")
            {
                filter = GameName.Blackjack;
            }

            return filter;
        }        

        private void CbxScoreFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxScoreFilter.Text == "Maximum Score")
            {
                filteredStatistics.Sort(new SortByMaximum());                
            }

            else if (CbxScoreFilter.Text == "Minimum Score")
            {
                filteredStatistics.Sort(new SortByMinimum());
            }

            else if (CbxScoreFilter.Text == "Game Name Ascending")
            {
                filteredStatistics.Sort(new SortByGameNameAscending());
            }

            else if (CbxScoreFilter.Text == "Game Name Descending")
            {
                filteredStatistics.Sort(new SortByGameNameDescending());
            }

            DisplayResultsInListView(filteredStatistics);
        }

        private void BtnTestListView_Click(object sender, EventArgs e)
        {
            GameStatistics stats = new GameStatistics();
            stats.Add(new GameResult(GameName.Dice, 4, 1, WinnerName.Player));
            stats.Add(new GameResult(GameName.Dice, 6, 6, WinnerName.Draw));
            stats.Add(new GameResult(GameName.Dice, 2, 4, WinnerName.Computer));
            stats.Add(new GameResult(GameName.Dice, 1, 6, WinnerName.Computer));
            stats.Add(new GameResult(GameName.TenSidedDice, 3, 9, WinnerName.Computer));

            DisplayResultsInListView(stats);
        }

        private void MitSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt) | *.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save File As";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                SaveFile((FileStream)saveFileDialog.OpenFile());             
            }
        }

        private void MitLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File (*.txt) | *.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Open File";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "txt";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                LoadFile(openFileDialog.FileName);
            }
        }

        private void MitQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveFile(FileStream fileStream)
        {
            foreach (GameResult result in gameStatistics.Results)
            {
                byte[] gameName = new UTF8Encoding().GetBytes(result.GameName.ToString() + "\n");
                byte[] playerScore = new UTF8Encoding().GetBytes(result.PlayerScore.ToString() + "\n");
                byte[] computerScore = new UTF8Encoding().GetBytes(result.ComputerScore.ToString() + "\n");
                byte[] winnerName = new UTF8Encoding().GetBytes(result.Winner.ToString() + "\n");

                fileStream.Write(gameName);
                fileStream.Write(playerScore);
                fileStream.Write(computerScore);
                fileStream.Write(winnerName);
            }

            fileStream.Flush();
            fileStream.Close();
        }

        private void LoadFile(string filePath)
        {
            string[] text = new string[0];
            try
            {
                text = File.ReadAllLines(filePath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < text.Length; i = i+4)
            {
                GameResult result;
                GameName gameName = GameName.Dice;
                int playerScore = 0;
                int computerScore = 0;
                WinnerName winnerName = WinnerName.Draw;

                string gameNameText = text[i];
                string playerScoreText = text[i+1];
                string computerScoreText = text[i+2];
                string winnerNameText = text[i+3];

                if (gameNameText == "Dice")
                    gameName = GameName.Dice;
                else if (gameNameText == "TenSidedDice")
                    gameName = GameName.TenSidedDice;
                else if (gameNameText == "LowCard")
                    gameName = GameName.LowCard;
                else if (gameNameText == "HighCard")
                    gameName = GameName.HighCard;
                else if (gameNameText == "WildEights")
                    gameName = GameName.WildEights;
                else if (gameNameText == "Blackjack")
                    gameName = GameName.Blackjack;
                else
                    MessageBox.Show($"The game {gameName} does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    playerScore = int.Parse(playerScoreText);
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    computerScore = int.Parse(computerScoreText);
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (winnerNameText == "Player")
                    winnerName = WinnerName.Player;
                else if (winnerNameText == "Computer")
                    winnerName = WinnerName.Computer;
                else if (winnerNameText == "Draw")
                    winnerName = WinnerName.Draw;
                else
                    MessageBox.Show($"The winner {gameName} is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                result = new GameResult(gameName, playerScore, computerScore, winnerName);
                gameStatistics.Add(result);
                
                DisplayResultsInListView(gameStatistics);
                DisplayStatisticsInListView(gameStatistics);
            }
        }
    }
}
