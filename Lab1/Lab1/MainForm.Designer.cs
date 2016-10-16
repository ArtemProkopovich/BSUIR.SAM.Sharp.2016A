namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.paramR0ErrorLabel = new System.Windows.Forms.Label();
            this.paramMErrorLabel = new System.Windows.Forms.Label();
            this.paramAErrorLabel = new System.Windows.Forms.Label();
            this.magicButton = new System.Windows.Forms.Button();
            this.paramRTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paramMTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paramATextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.paramR0ErrorLabel);
            this.groupBox.Controls.Add(this.paramMErrorLabel);
            this.groupBox.Controls.Add(this.paramAErrorLabel);
            this.groupBox.Controls.Add(this.magicButton);
            this.groupBox.Controls.Add(this.paramRTextBox);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.paramMTextBox);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.paramATextBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(657, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(351, 260);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Исходные величины";
            // 
            // paramR0ErrorLabel
            // 
            this.paramR0ErrorLabel.AutoSize = true;
            this.paramR0ErrorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paramR0ErrorLabel.Location = new System.Drawing.Point(116, 163);
            this.paramR0ErrorLabel.Name = "paramR0ErrorLabel";
            this.paramR0ErrorLabel.Size = new System.Drawing.Size(98, 13);
            this.paramR0ErrorLabel.TabIndex = 9;
            this.paramR0ErrorLabel.Text = "paramR0ErrorLabel";
            // 
            // paramMErrorLabel
            // 
            this.paramMErrorLabel.AutoSize = true;
            this.paramMErrorLabel.Location = new System.Drawing.Point(116, 104);
            this.paramMErrorLabel.Name = "paramMErrorLabel";
            this.paramMErrorLabel.Size = new System.Drawing.Size(93, 13);
            this.paramMErrorLabel.TabIndex = 8;
            this.paramMErrorLabel.Text = "paramMErrorLabel";
            // 
            // paramAErrorLabel
            // 
            this.paramAErrorLabel.AutoSize = true;
            this.paramAErrorLabel.Location = new System.Drawing.Point(116, 46);
            this.paramAErrorLabel.Name = "paramAErrorLabel";
            this.paramAErrorLabel.Size = new System.Drawing.Size(91, 13);
            this.paramAErrorLabel.TabIndex = 7;
            this.paramAErrorLabel.Text = "paramAErrorLabel";
            // 
            // magicButton
            // 
            this.magicButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.magicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.magicButton.Location = new System.Drawing.Point(99, 206);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(151, 32);
            this.magicButton.TabIndex = 6;
            this.magicButton.Text = "Magic";
            this.magicButton.UseVisualStyleBackColor = false;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // paramRTextBox
            // 
            this.paramRTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramRTextBox.Location = new System.Drawing.Point(119, 134);
            this.paramRTextBox.Name = "paramRTextBox";
            this.paramRTextBox.Size = new System.Drawing.Size(201, 26);
            this.paramRTextBox.TabIndex = 5;
            this.paramRTextBox.TextChanged += new System.EventHandler(this.paramRTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Параметр \'R0\'";
            // 
            // paramMTextBox
            // 
            this.paramMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramMTextBox.Location = new System.Drawing.Point(119, 75);
            this.paramMTextBox.Name = "paramMTextBox";
            this.paramMTextBox.Size = new System.Drawing.Size(201, 26);
            this.paramMTextBox.TabIndex = 3;
            this.paramMTextBox.TextChanged += new System.EventHandler(this.paramMTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Параметр \'M\'";
            // 
            // paramATextBox
            // 
            this.paramATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramATextBox.Location = new System.Drawing.Point(119, 17);
            this.paramATextBox.Name = "paramATextBox";
            this.paramATextBox.Size = new System.Drawing.Size(201, 26);
            this.paramATextBox.TabIndex = 1;
            this.paramATextBox.TextChanged += new System.EventHandler(this.paramATextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметр \'А\'";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(11, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 400);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(658, 279);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(350, 133);
            this.resultTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 422);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox paramRTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paramMTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paramATextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Label paramR0ErrorLabel;
        private System.Windows.Forms.Label paramMErrorLabel;
        private System.Windows.Forms.Label paramAErrorLabel;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

