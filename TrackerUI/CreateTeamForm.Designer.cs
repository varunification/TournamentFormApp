namespace TrackerUI
{
    partial class CreateTeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            teamNameLabel = new Label();
            teamNameValue = new TextBox();
            selectTeamMemberLabel = new Label();
            selectTeamMemberDropDown = new ComboBox();
            addTeamMemberButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            phoneValue = new TextBox();
            label3 = new Label();
            emailAddressValue = new TextBox();
            emailAddressLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            tournamentTeamMembersListBox = new ListBox();
            RemoveSelectedTeamMemberButton = new Button();
            createTeamButton = new Button();
            createTeamLabel = new Label();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new Point(24, 41);
            teamNameLabel.Margin = new Padding(2, 0, 2, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(70, 15);
            teamNameLabel.TabIndex = 0;
            teamNameLabel.Text = "Team Name";
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(24, 58);
            teamNameValue.Margin = new Padding(2);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(204, 23);
            teamNameValue.TabIndex = 3;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Location = new Point(24, 85);
            selectTeamMemberLabel.Margin = new Padding(2, 0, 2, 0);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(117, 15);
            selectTeamMemberLabel.TabIndex = 4;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(24, 101);
            selectTeamMemberDropDown.Margin = new Padding(2);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(204, 23);
            selectTeamMemberDropDown.TabIndex = 7;
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamMemberButton.Location = new Point(52, 132);
            addTeamMemberButton.Margin = new Padding(2);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(148, 29);
            addTeamMemberButton.TabIndex = 17;
            addTeamMemberButton.Text = "Add Member";
            addTeamMemberButton.UseVisualStyleBackColor = true;
            addTeamMemberButton.Click += addTeamMemberButton_Click_1;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.BackColor = Color.White;
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(phoneValue);
            addNewMemberGroupBox.Controls.Add(label3);
            addNewMemberGroupBox.Controls.Add(emailAddressValue);
            addNewMemberGroupBox.Controls.Add(emailAddressLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addNewMemberGroupBox.Location = new Point(24, 165);
            addNewMemberGroupBox.Margin = new Padding(2);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Padding = new Padding(2);
            addNewMemberGroupBox.Size = new Size(212, 166);
            addNewMemberGroupBox.TabIndex = 18;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.Location = new Point(28, 121);
            createMemberButton.Margin = new Padding(2);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(148, 36);
            createMemberButton.TabIndex = 18;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click_1;
            // 
            // phoneValue
            // 
            phoneValue.Location = new Point(76, 90);
            phoneValue.Margin = new Padding(2);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(128, 23);
            phoneValue.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 90);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 16;
            label3.Text = "Phone";
            // 
            // emailAddressValue
            // 
            emailAddressValue.Location = new Point(76, 68);
            emailAddressValue.Margin = new Padding(2);
            emailAddressValue.Name = "emailAddressValue";
            emailAddressValue.Size = new Size(128, 23);
            emailAddressValue.TabIndex = 15;
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new Point(4, 68);
            emailAddressLabel.Margin = new Padding(2, 0, 2, 0);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new Size(36, 15);
            emailAddressLabel.TabIndex = 14;
            emailAddressLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(76, 46);
            lastNameValue.Margin = new Padding(2);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(128, 23);
            lastNameValue.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(4, 46);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(76, 23);
            firstNameValue.Margin = new Padding(2);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(128, 23);
            firstNameValue.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(4, 23);
            firstNameLabel.Margin = new Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 10;
            firstNameLabel.Text = "First Name";
            // 
            // tournamentTeamMembersListBox
            // 
            tournamentTeamMembersListBox.FormattingEnabled = true;
            tournamentTeamMembersListBox.ItemHeight = 15;
            tournamentTeamMembersListBox.Location = new Point(257, 56);
            tournamentTeamMembersListBox.Margin = new Padding(2);
            tournamentTeamMembersListBox.Name = "tournamentTeamMembersListBox";
            tournamentTeamMembersListBox.Size = new Size(192, 259);
            tournamentTeamMembersListBox.TabIndex = 20;
            tournamentTeamMembersListBox.SelectedIndexChanged += tournamentTeamMembersListBox_SelectedIndexChanged;
            // 
            // RemoveSelectedTeamMemberButton
            // 
            RemoveSelectedTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            RemoveSelectedTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            RemoveSelectedTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            RemoveSelectedTeamMemberButton.FlatStyle = FlatStyle.Flat;
            RemoveSelectedTeamMemberButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveSelectedTeamMemberButton.Location = new Point(467, 165);
            RemoveSelectedTeamMemberButton.Margin = new Padding(2);
            RemoveSelectedTeamMemberButton.Name = "RemoveSelectedTeamMemberButton";
            RemoveSelectedTeamMemberButton.Size = new Size(87, 44);
            RemoveSelectedTeamMemberButton.TabIndex = 21;
            RemoveSelectedTeamMemberButton.Text = "Remove Selected";
            RemoveSelectedTeamMemberButton.UseVisualStyleBackColor = true;
            RemoveSelectedTeamMemberButton.Click += DeleteSelectedTeamMemberButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.Location = new Point(145, 351);
            createTeamButton.Margin = new Padding(2);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(268, 45);
            createTeamButton.TabIndex = 24;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click_1;
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamLabel.ForeColor = Color.RoyalBlue;
            createTeamLabel.Location = new Point(20, 11);
            createTeamLabel.Margin = new Padding(2, 0, 2, 0);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(104, 21);
            createTeamLabel.TabIndex = 25;
            createTeamLabel.Text = "Create Team";
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 428);
            Controls.Add(createTeamLabel);
            Controls.Add(createTeamButton);
            Controls.Add(RemoveSelectedTeamMemberButton);
            Controls.Add(tournamentTeamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Margin = new Padding(2);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label teamNameLabel;
        private TextBox teamNameValue;
        private Label selectTeamMemberLabel;
        private ComboBox selectTeamMemberDropDown;
        private Button addTeamMemberButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox addNewMemberGroupBox;
        private TextBox phoneValue;
        private Label label3;
        private TextBox emailAddressValue;
        private Label emailAddressLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private ListBox tournamentTeamMembersListBox;
        private Button RemoveSelectedTeamMemberButton;
        private Button createTeamButton;
        private Label createTeamLabel;
    }
}