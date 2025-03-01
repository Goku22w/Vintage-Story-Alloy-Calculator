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
            ((System.ComponentModel.ISupportInitialize)(this.IngotAmount)).BeginInit();
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
            "Silver Solder"});
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
            this.AlloyOutputLabel.Location = new System.Drawing.Point(22, 237);
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
            this.CalculateButton.Size = new System.Drawing.Size(86, 23);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AlloyOutputLabel);
            this.Controls.Add(this.AlloySelectorLabel);
            this.Controls.Add(this.IngotAmountLabel);
            this.Controls.Add(this.AlloySelector);
            this.Controls.Add(this.IngotAmount);
            this.Name = "Form1";
            this.Text = "Vintage Story Alloy Calculator (VSAC)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IngotAmount)).EndInit();
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
    }
}

