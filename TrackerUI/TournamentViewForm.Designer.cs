
namespace TrackerUI
{
    partial class TournamentViewForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MatchUpListBox = new System.Windows.Forms.ListBox();
            this.Team1Name = new System.Windows.Forms.Label();
            this.team1ScoreLabel = new System.Windows.Forms.Label();
            this.team1ScoreVal = new System.Windows.Forms.TextBox();
            this.team2ScoreVal = new System.Windows.Forms.TextBox();
            this.team2ScoreLabel = new System.Windows.Forms.Label();
            this.team2Name = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(226, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentName.ForeColor = System.Drawing.Color.Aqua;
            this.tournamentName.Location = new System.Drawing.Point(227, 9);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(155, 50);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundLabel.Location = new System.Drawing.Point(21, 99);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(110, 41);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(137, 99);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(201, 39);
            this.roundDropdown.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox1.Location = new System.Drawing.Point(137, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(194, 39);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Unplayer Only";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MatchUpListBox
            // 
            this.MatchUpListBox.FormattingEnabled = true;
            this.MatchUpListBox.ItemHeight = 31;
            this.MatchUpListBox.Location = new System.Drawing.Point(32, 189);
            this.MatchUpListBox.Name = "MatchUpListBox";
            this.MatchUpListBox.Size = new System.Drawing.Size(306, 314);
            this.MatchUpListBox.TabIndex = 5;
            // 
            // Team1Name
            // 
            this.Team1Name.AutoSize = true;
            this.Team1Name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Team1Name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Team1Name.Location = new System.Drawing.Point(381, 199);
            this.Team1Name.Name = "Team1Name";
            this.Team1Name.Size = new System.Drawing.Size(156, 41);
            this.Team1Name.TabIndex = 6;
            this.Team1Name.Tag = "<team 1>";
            this.Team1Name.Text = "<team 1>";
            // 
            // team1ScoreLabel
            // 
            this.team1ScoreLabel.AutoSize = true;
            this.team1ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.team1ScoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.team1ScoreLabel.Location = new System.Drawing.Point(406, 251);
            this.team1ScoreLabel.Name = "team1ScoreLabel";
            this.team1ScoreLabel.Size = new System.Drawing.Size(95, 41);
            this.team1ScoreLabel.TabIndex = 7;
            this.team1ScoreLabel.Tag = "<team 1>";
            this.team1ScoreLabel.Text = "Score";
            // 
            // team1ScoreVal
            // 
            this.team1ScoreVal.Location = new System.Drawing.Point(507, 256);
            this.team1ScoreVal.Name = "team1ScoreVal";
            this.team1ScoreVal.Size = new System.Drawing.Size(125, 38);
            this.team1ScoreVal.TabIndex = 8;
            // 
            // team2ScoreVal
            // 
            this.team2ScoreVal.Location = new System.Drawing.Point(507, 455);
            this.team2ScoreVal.Name = "team2ScoreVal";
            this.team2ScoreVal.Size = new System.Drawing.Size(125, 38);
            this.team2ScoreVal.TabIndex = 11;
            // 
            // team2ScoreLabel
            // 
            this.team2ScoreLabel.AutoSize = true;
            this.team2ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.team2ScoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.team2ScoreLabel.Location = new System.Drawing.Point(406, 450);
            this.team2ScoreLabel.Name = "team2ScoreLabel";
            this.team2ScoreLabel.Size = new System.Drawing.Size(95, 41);
            this.team2ScoreLabel.TabIndex = 10;
            this.team2ScoreLabel.Tag = "<team 1>";
            this.team2ScoreLabel.Text = "Score";
            // 
            // team2Name
            // 
            this.team2Name.AutoSize = true;
            this.team2Name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.team2Name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.team2Name.Location = new System.Drawing.Point(381, 398);
            this.team2Name.Name = "team2Name";
            this.team2Name.Size = new System.Drawing.Size(156, 41);
            this.team2Name.TabIndex = 9;
            this.team2Name.Tag = "";
            this.team2Name.Text = "<team 2>";
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VersusLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VersusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.VersusLabel.Location = new System.Drawing.Point(507, 334);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(57, 43);
            this.VersusLabel.TabIndex = 12;
            this.VersusLabel.Tag = "";
            this.VersusLabel.Text = "VS";
            // 
            // ScoreButton
            // 
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreButton.Location = new System.Drawing.Point(735, 319);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(181, 76);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(942, 541);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.team2ScoreVal);
            this.Controls.Add(this.team2ScoreLabel);
            this.Controls.Add(this.team2Name);
            this.Controls.Add(this.team1ScoreVal);
            this.Controls.Add(this.team1ScoreLabel);
            this.Controls.Add(this.Team1Name);
            this.Controls.Add(this.MatchUpListBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TournamentViewForm";
            this.Text = "Tournament Viewer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox MatchUpListBox;
        private System.Windows.Forms.Label Team1Name;
        private System.Windows.Forms.Label team1ScoreLabel;
        private System.Windows.Forms.TextBox team1ScoreVal;
        private System.Windows.Forms.TextBox team2ScoreVal;
        private System.Windows.Forms.Label team2ScoreLabel;
        private System.Windows.Forms.Label team2Name;
        private System.Windows.Forms.Label VersusLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

