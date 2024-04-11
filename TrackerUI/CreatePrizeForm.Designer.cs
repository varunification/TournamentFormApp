namespace TrackerUI
{
    partial class CreatePrizeForm
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
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = Color.RoyalBlue;
            createPrizeLabel.Location = new Point(15, 11);
            createPrizeLabel.Margin = new Padding(2, 0, 2, 0);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(101, 21);
            createPrizeLabel.TabIndex = 25;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(130, 47);
            placeNumberValue.Margin = new Padding(2);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(106, 23);
            placeNumberValue.TabIndex = 27;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Location = new Point(22, 47);
            placeNumberLabel.Margin = new Padding(2, 0, 2, 0);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(82, 15);
            placeNumberLabel.TabIndex = 26;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(130, 72);
            placeNameValue.Margin = new Padding(2);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(106, 23);
            placeNameValue.TabIndex = 29;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Location = new Point(22, 74);
            placeNameLabel.Margin = new Padding(2, 0, 2, 0);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(70, 15);
            placeNameLabel.TabIndex = 28;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(130, 98);
            prizeAmountValue.Margin = new Padding(2);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(106, 23);
            prizeAmountValue.TabIndex = 31;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Location = new Point(22, 101);
            prizeAmountLabel.Margin = new Padding(2, 0, 2, 0);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(79, 15);
            prizeAmountLabel.TabIndex = 30;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(130, 141);
            prizePercentageValue.Margin = new Padding(2);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(106, 23);
            prizePercentageValue.TabIndex = 33;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Location = new Point(22, 142);
            prizePercentageLabel.Margin = new Padding(2, 0, 2, 0);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(94, 15);
            prizePercentageLabel.TabIndex = 32;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Location = new Point(158, 122);
            orLabel.Margin = new Padding(2, 0, 2, 0);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(38, 15);
            orLabel.TabIndex = 34;
            orLabel.Text = "--or--";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(66, 187);
            createPrizeButton.Margin = new Padding(2);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(130, 47);
            createPrizeButton.TabIndex = 35;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(324, 318);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Margin = new Padding(2);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}