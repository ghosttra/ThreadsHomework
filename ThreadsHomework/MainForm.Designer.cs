namespace ThreadsHomework {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.nFromSD = new System.Windows.Forms.NumericUpDown();
            this.nToSD = new System.Windows.Forms.NumericUpDown();
            this.lFrom = new System.Windows.Forms.Label();
            this.lTo = new System.Windows.Forms.Label();
            this.lbSimpleDigits = new System.Windows.Forms.ListBox();
            this.bStartSD = new System.Windows.Forms.Button();
            this.bSuspendSD = new System.Windows.Forms.Button();
            this.bResumeSD = new System.Windows.Forms.Button();
            this.gbPrime = new System.Windows.Forms.GroupBox();
            this.gbFibonacci = new System.Windows.Forms.GroupBox();
            this.lbFibonacci = new System.Windows.Forms.ListBox();
            this.bResumeFibonacci = new System.Windows.Forms.Button();
            this.bStartFibonacci = new System.Windows.Forms.Button();
            this.bSuspendFibonacci = new System.Windows.Forms.Button();
            this.bStopPrime = new System.Windows.Forms.Button();
            this.bStopFibonacci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nFromSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToSD)).BeginInit();
            this.gbPrime.SuspendLayout();
            this.gbFibonacci.SuspendLayout();
            this.SuspendLayout();
            // 
            // nFromSD
            // 
            this.nFromSD.Location = new System.Drawing.Point(47, 21);
            this.nFromSD.Name = "nFromSD";
            this.nFromSD.Size = new System.Drawing.Size(120, 20);
            this.nFromSD.TabIndex = 0;
            // 
            // nToSD
            // 
            this.nToSD.Location = new System.Drawing.Point(202, 21);
            this.nToSD.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nToSD.Name = "nToSD";
            this.nToSD.Size = new System.Drawing.Size(120, 20);
            this.nToSD.TabIndex = 0;
            // 
            // lFrom
            // 
            this.lFrom.AutoSize = true;
            this.lFrom.Location = new System.Drawing.Point(12, 23);
            this.lFrom.Name = "lFrom";
            this.lFrom.Size = new System.Drawing.Size(33, 13);
            this.lFrom.TabIndex = 1;
            this.lFrom.Text = "From:";
            // 
            // lTo
            // 
            this.lTo.AutoSize = true;
            this.lTo.Location = new System.Drawing.Point(173, 23);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(23, 13);
            this.lTo.TabIndex = 1;
            this.lTo.Text = "To:";
            // 
            // lbSimpleDigits
            // 
            this.lbSimpleDigits.FormattingEnabled = true;
            this.lbSimpleDigits.Location = new System.Drawing.Point(15, 47);
            this.lbSimpleDigits.Name = "lbSimpleDigits";
            this.lbSimpleDigits.Size = new System.Drawing.Size(307, 95);
            this.lbSimpleDigits.TabIndex = 2;
            // 
            // bStartSD
            // 
            this.bStartSD.Location = new System.Drawing.Point(15, 148);
            this.bStartSD.Name = "bStartSD";
            this.bStartSD.Size = new System.Drawing.Size(152, 23);
            this.bStartSD.TabIndex = 3;
            this.bStartSD.Text = "Start";
            this.bStartSD.UseVisualStyleBackColor = true;
            this.bStartSD.Click += new System.EventHandler(this.bStartSD_Click);
            // 
            // bSuspendSD
            // 
            this.bSuspendSD.Location = new System.Drawing.Point(170, 148);
            this.bSuspendSD.Name = "bSuspendSD";
            this.bSuspendSD.Size = new System.Drawing.Size(152, 23);
            this.bSuspendSD.TabIndex = 4;
            this.bSuspendSD.Text = "Suspend";
            this.bSuspendSD.UseVisualStyleBackColor = true;
            this.bSuspendSD.Click += new System.EventHandler(this.bSuspendSD_Click);
            // 
            // bResumeSD
            // 
            this.bResumeSD.Location = new System.Drawing.Point(15, 177);
            this.bResumeSD.Name = "bResumeSD";
            this.bResumeSD.Size = new System.Drawing.Size(307, 23);
            this.bResumeSD.TabIndex = 4;
            this.bResumeSD.Text = "Resume";
            this.bResumeSD.UseVisualStyleBackColor = true;
            this.bResumeSD.Click += new System.EventHandler(this.bResumeSD_Click);
            // 
            // gbPrime
            // 
            this.gbPrime.Controls.Add(this.lbSimpleDigits);
            this.gbPrime.Controls.Add(this.bStopPrime);
            this.gbPrime.Controls.Add(this.bResumeSD);
            this.gbPrime.Controls.Add(this.nFromSD);
            this.gbPrime.Controls.Add(this.bSuspendSD);
            this.gbPrime.Controls.Add(this.nToSD);
            this.gbPrime.Controls.Add(this.bStartSD);
            this.gbPrime.Controls.Add(this.lFrom);
            this.gbPrime.Controls.Add(this.lTo);
            this.gbPrime.Location = new System.Drawing.Point(12, 12);
            this.gbPrime.Name = "gbPrime";
            this.gbPrime.Size = new System.Drawing.Size(338, 235);
            this.gbPrime.TabIndex = 5;
            this.gbPrime.TabStop = false;
            this.gbPrime.Text = "Prime numbers";
            // 
            // gbFibonacci
            // 
            this.gbFibonacci.Controls.Add(this.lbFibonacci);
            this.gbFibonacci.Controls.Add(this.bStopFibonacci);
            this.gbFibonacci.Controls.Add(this.bResumeFibonacci);
            this.gbFibonacci.Controls.Add(this.bStartFibonacci);
            this.gbFibonacci.Controls.Add(this.bSuspendFibonacci);
            this.gbFibonacci.Location = new System.Drawing.Point(356, 12);
            this.gbFibonacci.Name = "gbFibonacci";
            this.gbFibonacci.Size = new System.Drawing.Size(422, 235);
            this.gbFibonacci.TabIndex = 6;
            this.gbFibonacci.TabStop = false;
            this.gbFibonacci.Text = "Fibonacci numbers";
            // 
            // lbFibonacci
            // 
            this.lbFibonacci.FormattingEnabled = true;
            this.lbFibonacci.Location = new System.Drawing.Point(6, 19);
            this.lbFibonacci.Name = "lbFibonacci";
            this.lbFibonacci.Size = new System.Drawing.Size(410, 121);
            this.lbFibonacci.TabIndex = 5;
            // 
            // bResumeFibonacci
            // 
            this.bResumeFibonacci.Location = new System.Drawing.Point(6, 177);
            this.bResumeFibonacci.Name = "bResumeFibonacci";
            this.bResumeFibonacci.Size = new System.Drawing.Size(410, 23);
            this.bResumeFibonacci.TabIndex = 7;
            this.bResumeFibonacci.Text = "Resume";
            this.bResumeFibonacci.UseVisualStyleBackColor = true;
            this.bResumeFibonacci.Click += new System.EventHandler(this.bResumeFibonacci_Click);
            // 
            // bStartFibonacci
            // 
            this.bStartFibonacci.Location = new System.Drawing.Point(6, 148);
            this.bStartFibonacci.Name = "bStartFibonacci";
            this.bStartFibonacci.Size = new System.Drawing.Size(213, 23);
            this.bStartFibonacci.TabIndex = 6;
            this.bStartFibonacci.Text = "Start";
            this.bStartFibonacci.UseVisualStyleBackColor = true;
            this.bStartFibonacci.Click += new System.EventHandler(this.bStartFibonacci_Click);
            // 
            // bSuspendFibonacci
            // 
            this.bSuspendFibonacci.Location = new System.Drawing.Point(225, 148);
            this.bSuspendFibonacci.Name = "bSuspendFibonacci";
            this.bSuspendFibonacci.Size = new System.Drawing.Size(191, 23);
            this.bSuspendFibonacci.TabIndex = 8;
            this.bSuspendFibonacci.Text = "Suspend";
            this.bSuspendFibonacci.UseVisualStyleBackColor = true;
            this.bSuspendFibonacci.Click += new System.EventHandler(this.bSuspendFibonacci_Click);
            // 
            // bStopPrime
            // 
            this.bStopPrime.Location = new System.Drawing.Point(15, 206);
            this.bStopPrime.Name = "bStopPrime";
            this.bStopPrime.Size = new System.Drawing.Size(307, 23);
            this.bStopPrime.TabIndex = 4;
            this.bStopPrime.Text = "Stop";
            this.bStopPrime.UseVisualStyleBackColor = true;
            this.bStopPrime.Click += new System.EventHandler(this.bStopPrime_Click);
            // 
            // bStopFibonacci
            // 
            this.bStopFibonacci.Location = new System.Drawing.Point(6, 206);
            this.bStopFibonacci.Name = "bStopFibonacci";
            this.bStopFibonacci.Size = new System.Drawing.Size(410, 23);
            this.bStopFibonacci.TabIndex = 7;
            this.bStopFibonacci.Text = "Stop";
            this.bStopFibonacci.UseVisualStyleBackColor = true;
            this.bStopFibonacci.Click += new System.EventHandler(this.bStopFibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 256);
            this.Controls.Add(this.gbFibonacci);
            this.Controls.Add(this.gbPrime);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nFromSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToSD)).EndInit();
            this.gbPrime.ResumeLayout(false);
            this.gbPrime.PerformLayout();
            this.gbFibonacci.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nFromSD;
        private System.Windows.Forms.NumericUpDown nToSD;
        private System.Windows.Forms.Label lFrom;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.ListBox lbSimpleDigits;
        private System.Windows.Forms.Button bStartSD;
        private System.Windows.Forms.Button bSuspendSD;
        private System.Windows.Forms.Button bResumeSD;
        private System.Windows.Forms.GroupBox gbPrime;
        private System.Windows.Forms.GroupBox gbFibonacci;
        private System.Windows.Forms.ListBox lbFibonacci;
        private System.Windows.Forms.Button bResumeFibonacci;
        private System.Windows.Forms.Button bStartFibonacci;
        private System.Windows.Forms.Button bSuspendFibonacci;
        private System.Windows.Forms.Button bStopPrime;
        private System.Windows.Forms.Button bStopFibonacci;
    }
}

