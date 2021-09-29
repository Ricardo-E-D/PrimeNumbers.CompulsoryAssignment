
namespace CompulsoryAssignment
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
            this.BtnGetPrimeNumbersSeq = new System.Windows.Forms.Button();
            this.TxtMinVal = new System.Windows.Forms.TextBox();
            this.TxtMaxVal = new System.Windows.Forms.TextBox();
            this.ListBoxOfPrimes = new System.Windows.Forms.ListBox();
            this.ListBoxPar = new System.Windows.Forms.ListBox();
            this.BtnGetPrimeNumbersPar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGetPrimeNumbersSeq
            // 
            this.BtnGetPrimeNumbersSeq.Location = new System.Drawing.Point(12, 58);
            this.BtnGetPrimeNumbersSeq.Name = "BtnGetPrimeNumbersSeq";
            this.BtnGetPrimeNumbersSeq.Size = new System.Drawing.Size(156, 23);
            this.BtnGetPrimeNumbersSeq.TabIndex = 0;
            this.BtnGetPrimeNumbersSeq.Text = "Get Prime Numbers";
            this.BtnGetPrimeNumbersSeq.UseVisualStyleBackColor = true;
            this.BtnGetPrimeNumbersSeq.Click += new System.EventHandler(this.BtnGetPrimeNumbersSeq_Click);
            // 
            // TxtMinVal
            // 
            this.TxtMinVal.Location = new System.Drawing.Point(12, 12);
            this.TxtMinVal.Name = "TxtMinVal";
            this.TxtMinVal.Size = new System.Drawing.Size(100, 22);
            this.TxtMinVal.TabIndex = 1;
            // 
            // TxtMaxVal
            // 
            this.TxtMaxVal.Location = new System.Drawing.Point(118, 12);
            this.TxtMaxVal.Name = "TxtMaxVal";
            this.TxtMaxVal.Size = new System.Drawing.Size(100, 22);
            this.TxtMaxVal.TabIndex = 2;
            // 
            // ListBoxOfPrimes
            // 
            this.ListBoxOfPrimes.FormattingEnabled = true;
            this.ListBoxOfPrimes.ItemHeight = 16;
            this.ListBoxOfPrimes.Location = new System.Drawing.Point(12, 87);
            this.ListBoxOfPrimes.Name = "ListBoxOfPrimes";
            this.ListBoxOfPrimes.Size = new System.Drawing.Size(368, 660);
            this.ListBoxOfPrimes.TabIndex = 3;
            // 
            // ListBoxPar
            // 
            this.ListBoxPar.FormattingEnabled = true;
            this.ListBoxPar.ItemHeight = 16;
            this.ListBoxPar.Location = new System.Drawing.Point(427, 87);
            this.ListBoxPar.Name = "ListBoxPar";
            this.ListBoxPar.Size = new System.Drawing.Size(368, 660);
            this.ListBoxPar.TabIndex = 7;
            // 
            // BtnGetPrimeNumbersPar
            // 
            this.BtnGetPrimeNumbersPar.Location = new System.Drawing.Point(427, 58);
            this.BtnGetPrimeNumbersPar.Name = "BtnGetPrimeNumbersPar";
            this.BtnGetPrimeNumbersPar.Size = new System.Drawing.Size(156, 23);
            this.BtnGetPrimeNumbersPar.TabIndex = 4;
            this.BtnGetPrimeNumbersPar.Text = "Get Prime Numbers";
            this.BtnGetPrimeNumbersPar.UseVisualStyleBackColor = true;
            this.BtnGetPrimeNumbersPar.Click += new System.EventHandler(this.BtnGetPrimeNumbersPar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sequential";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parallel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 759);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxPar);
            this.Controls.Add(this.BtnGetPrimeNumbersPar);
            this.Controls.Add(this.ListBoxOfPrimes);
            this.Controls.Add(this.TxtMaxVal);
            this.Controls.Add(this.TxtMinVal);
            this.Controls.Add(this.BtnGetPrimeNumbersSeq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetPrimeNumbersSeq;
        private System.Windows.Forms.TextBox TxtMinVal;
        private System.Windows.Forms.TextBox TxtMaxVal;
        private System.Windows.Forms.ListBox ListBoxOfPrimes;
        private System.Windows.Forms.ListBox ListBoxPar;
        private System.Windows.Forms.Button BtnGetPrimeNumbersPar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

