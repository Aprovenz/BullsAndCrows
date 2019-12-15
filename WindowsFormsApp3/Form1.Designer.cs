namespace WindowsFormsApp3
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
            this.submitValue = new System.Windows.Forms.Button();
            this.guessValue = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.bulls = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bullsListBox = new System.Windows.Forms.ListBox();
            this.crowsListBox = new System.Windows.Forms.ListBox();
            this.bullsTotalCount = new System.Windows.Forms.TextBox();
            this.crowsTotalCount = new System.Windows.Forms.TextBox();
            this.attemptsCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitValue
            // 
            this.submitValue.Location = new System.Drawing.Point(6, 71);
            this.submitValue.Name = "submitValue";
            this.submitValue.Size = new System.Drawing.Size(173, 23);
            this.submitValue.TabIndex = 0;
            this.submitValue.Text = "Enter Value and Guess Count";
            this.submitValue.UseVisualStyleBackColor = true;
            this.submitValue.Click += new System.EventHandler(this.submitValue_Click);
            // 
            // guessValue
            // 
            this.guessValue.Location = new System.Drawing.Point(284, 41);
            this.guessValue.Name = "guessValue";
            this.guessValue.Size = new System.Drawing.Size(100, 23);
            this.guessValue.TabIndex = 1;
            this.guessValue.Text = "Submit Guess";
            this.guessValue.UseVisualStyleBackColor = true;
            this.guessValue.Click += new System.EventHandler(this.guessValue_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(60, 8);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 2;
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(284, 12);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(100, 20);
            this.guessBox.TabIndex = 3;
            // 
            // bulls
            // 
            this.bulls.AutoSize = true;
            this.bulls.Location = new System.Drawing.Point(459, 5);
            this.bulls.Name = "bulls";
            this.bulls.Size = new System.Drawing.Size(29, 13);
            this.bulls.TabIndex = 4;
            this.bulls.Text = "Bulls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crows";
            // 
            // bullsListBox
            // 
            this.bullsListBox.FormattingEnabled = true;
            this.bullsListBox.Location = new System.Drawing.Point(462, 28);
            this.bullsListBox.Name = "bullsListBox";
            this.bullsListBox.Size = new System.Drawing.Size(120, 82);
            this.bullsListBox.TabIndex = 8;
            // 
            // crowsListBox
            // 
            this.crowsListBox.FormattingEnabled = true;
            this.crowsListBox.Location = new System.Drawing.Point(646, 27);
            this.crowsListBox.Name = "crowsListBox";
            this.crowsListBox.Size = new System.Drawing.Size(120, 82);
            this.crowsListBox.TabIndex = 9;
            // 
            // bullsTotalCount
            // 
            this.bullsTotalCount.Location = new System.Drawing.Point(506, 2);
            this.bullsTotalCount.Name = "bullsTotalCount";
            this.bullsTotalCount.Size = new System.Drawing.Size(76, 20);
            this.bullsTotalCount.TabIndex = 10;
            // 
            // crowsTotalCount
            // 
            this.crowsTotalCount.Location = new System.Drawing.Point(692, 1);
            this.crowsTotalCount.Name = "crowsTotalCount";
            this.crowsTotalCount.Size = new System.Drawing.Size(74, 20);
            this.crowsTotalCount.TabIndex = 11;
            // 
            // attemptsCount
            // 
            this.attemptsCount.Location = new System.Drawing.Point(60, 34);
            this.attemptsCount.Name = "attemptsCount";
            this.attemptsCount.Size = new System.Drawing.Size(100, 20);
            this.attemptsCount.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Attempts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attemptsCount);
            this.Controls.Add(this.crowsTotalCount);
            this.Controls.Add(this.bullsTotalCount);
            this.Controls.Add(this.crowsListBox);
            this.Controls.Add(this.bullsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bulls);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.guessValue);
            this.Controls.Add(this.submitValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitValue;
        private System.Windows.Forms.Button guessValue;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label bulls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox bullsListBox;
        private System.Windows.Forms.ListBox crowsListBox;
        private System.Windows.Forms.TextBox bullsTotalCount;
        private System.Windows.Forms.TextBox crowsTotalCount;
        private System.Windows.Forms.TextBox attemptsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

