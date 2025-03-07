namespace Vintage_Story_Alloy_Calculator
{
    partial class Form1
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
            this.IngotAmount = new System.Windows.Forms.NumericUpDown();
            this.AlloySelector = new System.Windows.Forms.ComboBox();
            this.IngotAmountLabel = new System.Windows.Forms.Label();
            this.AlloySelectorLabel = new System.Windows.Forms.Label();
            this.AlloyOutputLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CalculateButton1 = new System.Windows.Forms.Button();
            this.HideSelectorLabel = new System.Windows.Forms.Label();
            this.HideAmountLabel = new System.Windows.Forms.Label();
            this.HideSelector = new System.Windows.Forms.ComboBox();
            this.HideAmount = new System.Windows.Forms.NumericUpDown();
            this.TaningOutputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IngotAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // IngotAmount
            // 
            this.IngotAmount.Location = new System.Drawing.Point(26, 72);
            this.IngotAmount.Name = "IngotAmount";
            this.IngotAmount.Size = new System.Drawing.Size(77, 20);
            this.IngotAmount.TabIndex = 0;
            // 
            // AlloySelector
            // 
            this.AlloySelector.FormattingEnabled = true;
            this.AlloySelector.Items.AddRange(new object[] {
            "Tin Bronze",
            "Bismuth Bronze",
            "Black Bronze",
            "Brass",
            "Cupronickel",
            "Molybdochalkos",
            "Electrum",
            "Lead Solder",
            "Silver Solder",
            "---Other Ingots---",
            "Meteoric Iron"});
            this.AlloySelector.Location = new System.Drawing.Point(279, 72);
            this.AlloySelector.Name = "AlloySelector";
            this.AlloySelector.Size = new System.Drawing.Size(121, 21);
            this.AlloySelector.TabIndex = 1;
            // 
            // IngotAmountLabel
            // 
            this.IngotAmountLabel.AutoSize = true;
            this.IngotAmountLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngotAmountLabel.Location = new System.Drawing.Point(22, 50);
            this.IngotAmountLabel.Name = "IngotAmountLabel";
            this.IngotAmountLabel.Size = new System.Drawing.Size(232, 19);
            this.IngotAmountLabel.TabIndex = 2;
            this.IngotAmountLabel.Text = "How many ingots do you want?";
            // 
            // AlloySelectorLabel
            // 
            this.AlloySelectorLabel.AutoSize = true;
            this.AlloySelectorLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlloySelectorLabel.Location = new System.Drawing.Point(275, 50);
            this.AlloySelectorLabel.Name = "AlloySelectorLabel";
            this.AlloySelectorLabel.Size = new System.Drawing.Size(191, 19);
            this.AlloySelectorLabel.TabIndex = 3;
            this.AlloySelectorLabel.Text = "Which Alloy do you want?";
            // 
            // AlloyOutputLabel
            // 
            this.AlloyOutputLabel.AutoSize = true;
            this.AlloyOutputLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlloyOutputLabel.Location = new System.Drawing.Point(22, 226);
            this.AlloyOutputLabel.Name = "AlloyOutputLabel";
            this.AlloyOutputLabel.Size = new System.Drawing.Size(59, 19);
            this.AlloyOutputLabel.TabIndex = 4;
            this.AlloyOutputLabel.Text = "BLANK";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(279, 99);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(86, 27);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CalculateButton1
            // 
            this.CalculateButton1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton1.Location = new System.Drawing.Point(279, 183);
            this.CalculateButton1.Name = "CalculateButton1";
            this.CalculateButton1.Size = new System.Drawing.Size(86, 27);
            this.CalculateButton1.TabIndex = 10;
            this.CalculateButton1.Text = "Calculate";
            this.CalculateButton1.UseVisualStyleBackColor = true;
            this.CalculateButton1.Click += new System.EventHandler(this.CalculateButton1_Click);
            // 
            // HideSelectorLabel
            // 
            this.HideSelectorLabel.AutoSize = true;
            this.HideSelectorLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideSelectorLabel.Location = new System.Drawing.Point(275, 134);
            this.HideSelectorLabel.Name = "HideSelectorLabel";
            this.HideSelectorLabel.Size = new System.Drawing.Size(86, 19);
            this.HideSelectorLabel.TabIndex = 9;
            this.HideSelectorLabel.Text = "What size?";
            // 
            // HideAmountLabel
            // 
            this.HideAmountLabel.AutoSize = true;
            this.HideAmountLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideAmountLabel.Location = new System.Drawing.Point(22, 134);
            this.HideAmountLabel.Name = "HideAmountLabel";
            this.HideAmountLabel.Size = new System.Drawing.Size(248, 19);
            this.HideAmountLabel.TabIndex = 8;
            this.HideAmountLabel.Text = "How many hides are you making?";
            // 
            // HideSelector
            // 
            this.HideSelector.FormattingEnabled = true;
            this.HideSelector.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Huge"});
            this.HideSelector.Location = new System.Drawing.Point(279, 156);
            this.HideSelector.Name = "HideSelector";
            this.HideSelector.Size = new System.Drawing.Size(121, 21);
            this.HideSelector.TabIndex = 7;
            // 
            // HideAmount
            // 
            this.HideAmount.Location = new System.Drawing.Point(26, 156);
            this.HideAmount.Name = "HideAmount";
            this.HideAmount.Size = new System.Drawing.Size(77, 20);
            this.HideAmount.TabIndex = 6;
            // 
            // TaningOutputLabel
            // 
            this.TaningOutputLabel.AutoSize = true;
            this.TaningOutputLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaningOutputLabel.Location = new System.Drawing.Point(22, 261);
            this.TaningOutputLabel.Name = "TaningOutputLabel";
            this.TaningOutputLabel.Size = new System.Drawing.Size(59, 19);
            this.TaningOutputLabel.TabIndex = 11;
            this.TaningOutputLabel.Text = "BLANK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 326);
            this.Controls.Add(this.TaningOutputLabel);
            this.Controls.Add(this.CalculateButton1);
            this.Controls.Add(this.HideSelectorLabel);
            this.Controls.Add(this.HideAmountLabel);
            this.Controls.Add(this.HideSelector);
            this.Controls.Add(this.HideAmount);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AlloyOutputLabel);
            this.Controls.Add(this.AlloySelectorLabel);
            this.Controls.Add(this.IngotAmountLabel);
            this.Controls.Add(this.AlloySelector);
            this.Controls.Add(this.IngotAmount);
            this.Name = "Form1";
            this.Text = "Vintage Story Alloy Calculator (VSAC) ++";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IngotAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IngotAmount;
        private System.Windows.Forms.ComboBox AlloySelector;
        private System.Windows.Forms.Label IngotAmountLabel;
        private System.Windows.Forms.Label AlloySelectorLabel;
        private System.Windows.Forms.Label AlloyOutputLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button CalculateButton1;
        private System.Windows.Forms.Label HideSelectorLabel;
        private System.Windows.Forms.Label HideAmountLabel;
        private System.Windows.Forms.ComboBox HideSelector;
        private System.Windows.Forms.NumericUpDown HideAmount;
        private System.Windows.Forms.Label TaningOutputLabel;
    }
}

