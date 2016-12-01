namespace Lab4
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.inputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(190, 12);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(387, 492);
            this.resultTextBox.TabIndex = 0;
            // 
            // inputNumericUpDown
            // 
            this.inputNumericUpDown.DecimalPlaces = 2;
            this.inputNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputNumericUpDown.Location = new System.Drawing.Point(12, 28);
            this.inputNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.inputNumericUpDown.Name = "inputNumericUpDown";
            this.inputNumericUpDown.Size = new System.Drawing.Size(169, 20);
            this.inputNumericUpDown.TabIndex = 1;
            this.inputNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Интенсивность входного потока";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Интенсивность выходного потока";
            // 
            // outputNumericUpDown
            // 
            this.outputNumericUpDown.DecimalPlaces = 2;
            this.outputNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.outputNumericUpDown.Location = new System.Drawing.Point(12, 79);
            this.outputNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.outputNumericUpDown.Name = "outputNumericUpDown";
            this.outputNumericUpDown.Size = new System.Drawing.Size(169, 20);
            this.outputNumericUpDown.TabIndex = 3;
            this.outputNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(55, 124);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 516);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNumericUpDown);
            this.Controls.Add(this.resultTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.inputNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.NumericUpDown inputNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown outputNumericUpDown;
        private System.Windows.Forms.Button okButton;
    }
}

