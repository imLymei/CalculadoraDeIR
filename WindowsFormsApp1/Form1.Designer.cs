namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DaysInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DailyInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WageOutput = new System.Windows.Forms.TextBox();
            this.IROutput = new System.Windows.Forms.TextBox();
            this.TotalWageOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CPFInput = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(104, 60);
            this.NameInput.Margin = new System.Windows.Forms.Padding(6);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(266, 29);
            this.NameInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // DaysInput
            // 
            this.DaysInput.Location = new System.Drawing.Point(190, 101);
            this.DaysInput.Margin = new System.Windows.Forms.Padding(6);
            this.DaysInput.Name = "DaysInput";
            this.DaysInput.Size = new System.Drawing.Size(180, 29);
            this.DaysInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dias trabalhados";
            // 
            // DailyInput
            // 
            this.DailyInput.Location = new System.Drawing.Point(170, 142);
            this.DailyInput.Margin = new System.Windows.Forms.Padding(6);
            this.DailyInput.Name = "DailyInput";
            this.DailyInput.Size = new System.Drawing.Size(200, 29);
            this.DailyInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor da diária";
            // 
            // WageOutput
            // 
            this.WageOutput.Location = new System.Drawing.Point(166, 268);
            this.WageOutput.Margin = new System.Windows.Forms.Padding(6);
            this.WageOutput.Name = "WageOutput";
            this.WageOutput.ReadOnly = true;
            this.WageOutput.Size = new System.Drawing.Size(215, 29);
            this.WageOutput.TabIndex = 8;
            // 
            // IROutput
            // 
            this.IROutput.Location = new System.Drawing.Point(166, 309);
            this.IROutput.Margin = new System.Windows.Forms.Padding(6);
            this.IROutput.Name = "IROutput";
            this.IROutput.ReadOnly = true;
            this.IROutput.Size = new System.Drawing.Size(215, 29);
            this.IROutput.TabIndex = 9;
            // 
            // TotalWageOutput
            // 
            this.TotalWageOutput.Location = new System.Drawing.Point(166, 350);
            this.TotalWageOutput.Margin = new System.Windows.Forms.Padding(6);
            this.TotalWageOutput.Name = "TotalWageOutput";
            this.TotalWageOutput.ReadOnly = true;
            this.TotalWageOutput.Size = new System.Drawing.Size(215, 29);
            this.TotalWageOutput.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salário base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor do IR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salário líquido";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(34, 207);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(336, 37);
            this.CalculateButton.TabIndex = 14;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CPFInput
            // 
            this.CPFInput.Location = new System.Drawing.Point(89, 19);
            this.CPFInput.Mask = "000-000-000\\.00";
            this.CPFInput.Name = "CPFInput";
            this.CPFInput.Size = new System.Drawing.Size(281, 29);
            this.CPFInput.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 397);
            this.Controls.Add(this.CPFInput);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalWageOutput);
            this.Controls.Add(this.IROutput);
            this.Controls.Add(this.WageOutput);
            this.Controls.Add(this.DailyInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DaysInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DaysInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DailyInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WageOutput;
        private System.Windows.Forms.TextBox IROutput;
        private System.Windows.Forms.TextBox TotalWageOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.MaskedTextBox CPFInput;
    }
}

