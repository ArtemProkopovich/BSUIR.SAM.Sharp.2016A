namespace Lab3
{
    partial class MainForm
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
            this.runButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.firstNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(91, 71);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(93, 40);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Click";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(270, 12);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(455, 468);
            this.resultTextBox.TabIndex = 1;
            // 
            // firstNumericUpDown
            // 
            this.firstNumericUpDown.DecimalPlaces = 2;
            this.firstNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.firstNumericUpDown.Location = new System.Drawing.Point(12, 32);
            this.firstNumericUpDown.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            this.firstNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.firstNumericUpDown.Name = "firstNumericUpDown";
            this.firstNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.firstNumericUpDown.TabIndex = 2;
            this.firstNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Первая вероятность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вторая вероятность";
            // 
            // secondNumericUpDown
            // 
            this.secondNumericUpDown.DecimalPlaces = 2;
            this.secondNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.secondNumericUpDown.Location = new System.Drawing.Point(138, 32);
            this.secondNumericUpDown.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            this.secondNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.secondNumericUpDown.Name = "secondNumericUpDown";
            this.secondNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.secondNumericUpDown.TabIndex = 4;
            this.secondNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNumericUpDown);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.runButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.firstNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.NumericUpDown firstNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown secondNumericUpDown;
    }
}

