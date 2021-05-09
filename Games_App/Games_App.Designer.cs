
namespace Games_App
{
    partial class Games_App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblName = new System.Windows.Forms.Label();
            this.LblPickGame = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.CbxGame = new System.Windows.Forms.ComboBox();
            this.BtnPlayGame = new System.Windows.Forms.Button();
            this.LblGameResults = new System.Windows.Forms.Label();
            this.ColGameNumber = new System.Windows.Forms.ColumnHeader();
            this.ColGameName = new System.Windows.Forms.ColumnHeader();
            this.ColPlayerScore = new System.Windows.Forms.ColumnHeader();
            this.ColComputerScore = new System.Windows.Forms.ColumnHeader();
            this.ColWinner = new System.Windows.Forms.ColumnHeader();
            this.LsvGameResults = new System.Windows.Forms.ListView();
            this.LblStatistics = new System.Windows.Forms.Label();
            this.LsvStatistics = new System.Windows.Forms.ListView();
            this.ColNumOfWins = new System.Windows.Forms.ColumnHeader();
            this.ColPercentageWins = new System.Windows.Forms.ColumnHeader();
            this.ColAverageScore = new System.Windows.Forms.ColumnHeader();
            this.ColMinimumScore = new System.Windows.Forms.ColumnHeader();
            this.ColMaximumScore = new System.Windows.Forms.ColumnHeader();
            this.LblFilter = new System.Windows.Forms.Label();
            this.CbxGameFilter = new System.Windows.Forms.ComboBox();
            this.CbxScoreFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTestListView = new System.Windows.Forms.Button();
            this.MnsMain = new System.Windows.Forms.MenuStrip();
            this.MitFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MitSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MitLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.MitQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(33, 53);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(127, 23);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Enter Name:";
            // 
            // LblPickGame
            // 
            this.LblPickGame.AutoSize = true;
            this.LblPickGame.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPickGame.Location = new System.Drawing.Point(46, 115);
            this.LblPickGame.Name = "LblPickGame";
            this.LblPickGame.Size = new System.Drawing.Size(116, 23);
            this.LblPickGame.TabIndex = 1;
            this.LblPickGame.Text = "Pick Game:";
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxName.Location = new System.Drawing.Point(162, 37);
            this.TbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(285, 38);
            this.TbxName.TabIndex = 2;
            this.TbxName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // CbxGame
            // 
            this.CbxGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGame.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxGame.FormattingEnabled = true;
            this.CbxGame.Location = new System.Drawing.Point(162, 107);
            this.CbxGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxGame.Name = "CbxGame";
            this.CbxGame.Size = new System.Drawing.Size(285, 31);
            this.CbxGame.TabIndex = 3;
            this.CbxGame.SelectedIndexChanged += new System.EventHandler(this.CbxGame_SelectedIndexChanged);
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlayGame.Location = new System.Drawing.Point(87, 188);
            this.BtnPlayGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(126, 41);
            this.BtnPlayGame.TabIndex = 4;
            this.BtnPlayGame.Text = "Play Game";
            this.BtnPlayGame.UseVisualStyleBackColor = true;
            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            // 
            // LblGameResults
            // 
            this.LblGameResults.AutoSize = true;
            this.LblGameResults.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGameResults.Location = new System.Drawing.Point(22, 281);
            this.LblGameResults.Name = "LblGameResults";
            this.LblGameResults.Size = new System.Drawing.Size(140, 23);
            this.LblGameResults.TabIndex = 6;
            this.LblGameResults.Text = "Game Results";
            // 
            // ColGameNumber
            // 
            this.ColGameNumber.Name = "ColGameNumber";
            this.ColGameNumber.Text = "Game Number";
            this.ColGameNumber.Width = 150;
            // 
            // ColGameName
            // 
            this.ColGameName.Name = "ColGameName";
            this.ColGameName.Text = "Game Name";
            this.ColGameName.Width = 150;
            // 
            // ColPlayerScore
            // 
            this.ColPlayerScore.Name = "ColPlayerScore";
            this.ColPlayerScore.Text = "Player Score";
            this.ColPlayerScore.Width = 150;
            // 
            // ColComputerScore
            // 
            this.ColComputerScore.Name = "ColComputerScore";
            this.ColComputerScore.Text = "Computer Score";
            this.ColComputerScore.Width = 150;
            // 
            // ColWinner
            // 
            this.ColWinner.Name = "ColWinner";
            this.ColWinner.Text = "Winner";
            this.ColWinner.Width = 150;
            // 
            // LsvGameResults
            // 
            this.LsvGameResults.AllowColumnReorder = true;
            this.LsvGameResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColGameNumber,
            this.ColGameName,
            this.ColPlayerScore,
            this.ColComputerScore,
            this.ColWinner});
            this.LsvGameResults.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsvGameResults.HideSelection = false;
            this.LsvGameResults.Location = new System.Drawing.Point(22, 400);
            this.LsvGameResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LsvGameResults.Name = "LsvGameResults";
            this.LsvGameResults.Size = new System.Drawing.Size(938, 181);
            this.LsvGameResults.TabIndex = 5;
            this.LsvGameResults.UseCompatibleStateImageBehavior = false;
            this.LsvGameResults.View = System.Windows.Forms.View.Details;
            // 
            // LblStatistics
            // 
            this.LblStatistics.AutoSize = true;
            this.LblStatistics.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStatistics.Location = new System.Drawing.Point(22, 640);
            this.LblStatistics.Name = "LblStatistics";
            this.LblStatistics.Size = new System.Drawing.Size(156, 23);
            this.LblStatistics.TabIndex = 8;
            this.LblStatistics.Text = "Game Statistics";
            // 
            // LsvStatistics
            // 
            this.LsvStatistics.AllowColumnReorder = true;
            this.LsvStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColNumOfWins,
            this.ColPercentageWins,
            this.ColAverageScore,
            this.ColMinimumScore,
            this.ColMaximumScore});
            this.LsvStatistics.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsvStatistics.HideSelection = false;
            this.LsvStatistics.Location = new System.Drawing.Point(22, 667);
            this.LsvStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LsvStatistics.Name = "LsvStatistics";
            this.LsvStatistics.Size = new System.Drawing.Size(938, 77);
            this.LsvStatistics.TabIndex = 9;
            this.LsvStatistics.UseCompatibleStateImageBehavior = false;
            this.LsvStatistics.View = System.Windows.Forms.View.Details;
            // 
            // ColNumOfWins
            // 
            this.ColNumOfWins.Name = "ColNumOfWins";
            this.ColNumOfWins.Text = "Win Count";
            this.ColNumOfWins.Width = 150;
            // 
            // ColPercentageWins
            // 
            this.ColPercentageWins.Name = "ColPercentageWins";
            this.ColPercentageWins.Text = "Win Percentage";
            this.ColPercentageWins.Width = 150;
            // 
            // ColAverageScore
            // 
            this.ColAverageScore.Name = "ColAverageScore";
            this.ColAverageScore.Text = "Average Score";
            this.ColAverageScore.Width = 150;
            // 
            // ColMinimumScore
            // 
            this.ColMinimumScore.Name = "ColMinimumScore";
            this.ColMinimumScore.Text = "Minimum Score";
            this.ColMinimumScore.Width = 150;
            // 
            // ColMaximumScore
            // 
            this.ColMaximumScore.Name = "ColMaximumScore";
            this.ColMaximumScore.Text = "Maximum Score";
            this.ColMaximumScore.Width = 150;
            // 
            // LblFilter
            // 
            this.LblFilter.AutoSize = true;
            this.LblFilter.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFilter.Location = new System.Drawing.Point(22, 331);
            this.LblFilter.Name = "LblFilter";
            this.LblFilter.Size = new System.Drawing.Size(169, 23);
            this.LblFilter.TabIndex = 11;
            this.LblFilter.Text = "Show results for:";
            // 
            // CbxGameFilter
            // 
            this.CbxGameFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGameFilter.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxGameFilter.FormattingEnabled = true;
            this.CbxGameFilter.Items.AddRange(new object[] {
            "All",
            "Dice",
            "Ten Sided Dice",
            "Low Card",
            "High Card",
            "Wild Eights",
            "Blackjack"});
            this.CbxGameFilter.Location = new System.Drawing.Point(197, 328);
            this.CbxGameFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxGameFilter.Name = "CbxGameFilter";
            this.CbxGameFilter.Size = new System.Drawing.Size(183, 31);
            this.CbxGameFilter.TabIndex = 12;
            this.CbxGameFilter.SelectedIndexChanged += new System.EventHandler(this.CbxFilter_SelectedIndexChanged);
            // 
            // CbxScoreFilter
            // 
            this.CbxScoreFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxScoreFilter.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxScoreFilter.FormattingEnabled = true;
            this.CbxScoreFilter.Items.AddRange(new object[] {
            "None",
            "Maximum Score",
            "Minimum Score",
            "Game Name Ascending",
            "Game Name Descending"});
            this.CbxScoreFilter.Location = new System.Drawing.Point(655, 328);
            this.CbxScoreFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxScoreFilter.Name = "CbxScoreFilter";
            this.CbxScoreFilter.Size = new System.Drawing.Size(305, 31);
            this.CbxScoreFilter.TabIndex = 14;
            this.CbxScoreFilter.SelectedIndexChanged += new System.EventHandler(this.CbxScoreFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(541, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter by:";
            // 
            // BtnTestListView
            // 
            this.BtnTestListView.Location = new System.Drawing.Point(783, 822);
            this.BtnTestListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTestListView.Name = "BtnTestListView";
            this.BtnTestListView.Size = new System.Drawing.Size(177, 31);
            this.BtnTestListView.TabIndex = 15;
            this.BtnTestListView.Text = "Test Results List View";
            this.BtnTestListView.UseVisualStyleBackColor = true;
            this.BtnTestListView.Click += new System.EventHandler(this.BtnTestListView_Click);
            // 
            // MnsMain
            // 
            this.MnsMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MnsMain.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MitFile});
            this.MnsMain.Location = new System.Drawing.Point(0, 0);
            this.MnsMain.Name = "MnsMain";
            this.MnsMain.Size = new System.Drawing.Size(1080, 31);
            this.MnsMain.TabIndex = 17;
            // 
            // MitFile
            // 
            this.MitFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MitSave,
            this.MitLoad,
            this.MitQuit});
            this.MitFile.Name = "MitFile";
            this.MitFile.Size = new System.Drawing.Size(58, 27);
            this.MitFile.Text = "File";
            // 
            // MitSave
            // 
            this.MitSave.Name = "MitSave";
            this.MitSave.Size = new System.Drawing.Size(177, 28);
            this.MitSave.Text = "Save File";
            // 
            // MitLoad
            // 
            this.MitLoad.Name = "MitLoad";
            this.MitLoad.Size = new System.Drawing.Size(177, 28);
            this.MitLoad.Text = "Load";
            // 
            // MitQuit
            // 
            this.MitQuit.Name = "MitQuit";
            this.MitQuit.Size = new System.Drawing.Size(177, 28);
            this.MitQuit.Text = "Quit";
            // 
            // Games_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 904);
            this.Controls.Add(this.BtnTestListView);
            this.Controls.Add(this.CbxScoreFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxGameFilter);
            this.Controls.Add(this.LblFilter);
            this.Controls.Add(this.LsvStatistics);
            this.Controls.Add(this.LblStatistics);
            this.Controls.Add(this.LblGameResults);
            this.Controls.Add(this.LsvGameResults);
            this.Controls.Add(this.BtnPlayGame);
            this.Controls.Add(this.CbxGame);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.LblPickGame);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.MnsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MnsMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Games_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games App";
            this.Load += new System.EventHandler(this.Games_App_Load);
            this.MnsMain.ResumeLayout(false);
            this.MnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblPickGame;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.ComboBox CbxGame;
        private System.Windows.Forms.Button BtnPlayGame;
        private System.Windows.Forms.Label LblGameResults;
        private System.Windows.Forms.ColumnHeader ColGameNumber;
        private System.Windows.Forms.ColumnHeader ColGameName;
        private System.Windows.Forms.ColumnHeader ColPlayerScore;
        private System.Windows.Forms.ColumnHeader ColComputerScore;
        private System.Windows.Forms.ColumnHeader ColWinner;
        private System.Windows.Forms.ListView LsvGameResults;
        private System.Windows.Forms.Label LblStatistics;
        private System.Windows.Forms.ListView LsvStatistics;
        private System.Windows.Forms.ColumnHeader ColNumOfWins;
        private System.Windows.Forms.ColumnHeader ColPercentageWins;
        private System.Windows.Forms.ColumnHeader ColAverageScore;
        private System.Windows.Forms.ColumnHeader ColMinimumScore;
        private System.Windows.Forms.ColumnHeader ColMaximumScore;
        private System.Windows.Forms.Label LblFilter;
        private System.Windows.Forms.ComboBox CbxGameFilter;
        private System.Windows.Forms.ComboBox CbxScoreFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTestListView;
        private System.Windows.Forms.MenuStrip MnsMain;
        private System.Windows.Forms.ToolStripMenuItem MitFile;
        private System.Windows.Forms.ToolStripMenuItem MitSave;
        private System.Windows.Forms.ToolStripMenuItem MitLoad;
        private System.Windows.Forms.ToolStripMenuItem MitQuit;
    }
}

