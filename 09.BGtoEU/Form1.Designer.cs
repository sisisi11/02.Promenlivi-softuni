namespace _09.BGtoEU
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
            this.labelConvert = new System.Windows.Forms.Label();
            this.labelCurrencies = new System.Windows.Forms.Label();
            this.numericUpDownAmmount = new System.Windows.Forms.NumericUpDown();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConvert
            // 
            this.labelConvert.AutoSize = true;
            this.labelConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConvert.Location = new System.Drawing.Point(12, 19);
            this.labelConvert.Name = "labelConvert";
            this.labelConvert.Size = new System.Drawing.Size(71, 20);
            this.labelConvert.TabIndex = 0;
            this.labelConvert.Text = "Convert";
            // 
            // labelCurrencies
            // 
            this.labelCurrencies.AutoSize = true;
            this.labelCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrencies.Location = new System.Drawing.Point(223, 19);
            this.labelCurrencies.Name = "labelCurrencies";
            this.labelCurrencies.Size = new System.Drawing.Size(122, 24);
            this.labelCurrencies.TabIndex = 1;
            this.labelCurrencies.Text = "BGN To EUR";
            // 
            // numericUpDownAmmount
            // 
            this.numericUpDownAmmount.Location = new System.Drawing.Point(117, 19);
            this.numericUpDownAmmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownAmmount.Name = "numericUpDownAmmount";
            this.numericUpDownAmmount.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownAmmount.TabIndex = 2;
            this.numericUpDownAmmount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelResult.Location = new System.Drawing.Point(95, 62);
            this.labelResult.Margin = new System.Windows.Forms.Padding(20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(135, 37);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Convert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 105);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.numericUpDownAmmount);
            this.Controls.Add(this.labelCurrencies);
            this.Controls.Add(this.labelConvert);
            this.Name = "Form1";
            this.Text = "CurrencyConventor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConvert;
        private System.Windows.Forms.Label labelCurrencies;
        private System.Windows.Forms.NumericUpDown numericUpDownAmmount;
        private System.Windows.Forms.Label labelResult;
    }
}

