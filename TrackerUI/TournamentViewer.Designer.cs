namespace TrackerUI
{
    partial class TournamentViewer
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
            ComboBox roundDropDown;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            VSlabel = new Label();
            ScoreButton = new Button();
            roundDropDown = new ComboBox();
            SuspendLayout();
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(148, 143);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(669, 58);
            roundDropDown.TabIndex = 3;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.ForeColor = Color.Green;
            headerLabel.Location = new Point(17, 47);
            headerLabel.Margin = new Padding(8, 0, 8, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(214, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            headerLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.ForeColor = Color.Green;
            tournamentName.Location = new Point(225, 47);
            tournamentName.Margin = new Padding(8, 0, 8, 0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(150, 50);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            tournamentName.TextAlign = ContentAlignment.TopCenter;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.ForeColor = Color.Green;
            roundLabel.Location = new Point(17, 146);
            roundLabel.Name = "roundLabel";
            roundLabel.RightToLeft = RightToLeft.Yes;
            roundLabel.Size = new Size(125, 50);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.ForeColor = Color.Green;
            unplayedOnlyCheckbox.Location = new Point(148, 246);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(269, 54);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.TextAlign = ContentAlignment.TopCenter;
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 50;
            matchupListBox.Location = new Point(17, 364);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(659, 302);
            matchupListBox.TabIndex = 6;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.ForeColor = Color.Green;
            teamOneName.Location = new Point(969, 248);
            teamOneName.Name = "teamOneName";
            teamOneName.RightToLeft = RightToLeft.Yes;
            teamOneName.Size = new Size(218, 50);
            teamOneName.TabIndex = 7;
            teamOneName.Text = "<team one>";
            teamOneName.Click += teamOneName_Click;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.ForeColor = Color.Green;
            teamOneScoreLabel.Location = new Point(969, 341);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.RightToLeft = RightToLeft.Yes;
            teamOneScoreLabel.Size = new Size(107, 50);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score";
            teamOneScoreLabel.Click += label1_Click;
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(1146, 334);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(100, 57);
            teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(1146, 577);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(100, 57);
            teamTwoScoreValue.TabIndex = 12;
            teamTwoScoreValue.TextChanged += teamTwoScoreValue_TextChanged;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.ForeColor = Color.Green;
            teamTwoScoreLabel.Location = new Point(969, 584);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.RightToLeft = RightToLeft.Yes;
            teamTwoScoreLabel.Size = new Size(107, 50);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.ForeColor = Color.Green;
            teamTwoName.Location = new Point(969, 476);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.RightToLeft = RightToLeft.Yes;
            teamTwoName.Size = new Size(215, 50);
            teamTwoName.TabIndex = 10;
            teamTwoName.Text = "<team two>";
            // 
            // VSlabel
            // 
            VSlabel.AutoSize = true;
            VSlabel.ForeColor = Color.Green;
            VSlabel.Location = new Point(1080, 406);
            VSlabel.Name = "VSlabel";
            VSlabel.RightToLeft = RightToLeft.Yes;
            VSlabel.Size = new Size(91, 50);
            VSlabel.TabIndex = 13;
            VSlabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            ScoreButton.FlatAppearance.BorderColor = Color.Silver;
            ScoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            ScoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            ScoreButton.FlatStyle = FlatStyle.Flat;
            ScoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreButton.ForeColor = SystemColors.MenuHighlight;
            ScoreButton.Location = new Point(1106, 28);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(116, 36);
            ScoreButton.TabIndex = 14;
            ScoreButton.Text = "Score";
            ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            AutoScaleDimensions = new SizeF(19F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1269, 749);
            Controls.Add(ScoreButton);
            Controls.Add(VSlabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(8, 10, 8, 10);
            Name = "TournamentViewer";
            Text = "Tournament Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label VSlabel;
        private Button ScoreButton;
    }
}