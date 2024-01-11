namespace SimplePowerpointParserApplication
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBSourceFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBOutputFile = new System.Windows.Forms.TextBox();
            this.BtnBrowsePPT = new System.Windows.Forms.Button();
            this.BtnBrouwseOutput = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnParsePPT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME to Powerpoint Parser";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source File";
            // 
            // TBSourceFile
            // 
            this.TBSourceFile.Location = new System.Drawing.Point(27, 43);
            this.TBSourceFile.Name = "TBSourceFile";
            this.TBSourceFile.Size = new System.Drawing.Size(232, 20);
            this.TBSourceFile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output File";
            // 
            // TBOutputFile
            // 
            this.TBOutputFile.Location = new System.Drawing.Point(27, 100);
            this.TBOutputFile.Name = "TBOutputFile";
            this.TBOutputFile.Size = new System.Drawing.Size(232, 20);
            this.TBOutputFile.TabIndex = 4;
            // 
            // BtnBrowsePPT
            // 
            this.BtnBrowsePPT.Location = new System.Drawing.Point(280, 40);
            this.BtnBrowsePPT.Name = "BtnBrowsePPT";
            this.BtnBrowsePPT.Size = new System.Drawing.Size(29, 23);
            this.BtnBrowsePPT.TabIndex = 5;
            this.BtnBrowsePPT.Text = "...";
            this.BtnBrowsePPT.UseVisualStyleBackColor = true;
            this.BtnBrowsePPT.Click += new System.EventHandler(this.BtnBrowsePPT_Click);
            // 
            // BtnBrouwseOutput
            // 
            this.BtnBrouwseOutput.Location = new System.Drawing.Point(280, 97);
            this.BtnBrouwseOutput.Name = "BtnBrouwseOutput";
            this.BtnBrouwseOutput.Size = new System.Drawing.Size(29, 23);
            this.BtnBrouwseOutput.TabIndex = 6;
            this.BtnBrouwseOutput.Text = "...";
            this.BtnBrouwseOutput.UseVisualStyleBackColor = true;
            this.BtnBrouwseOutput.Click += new System.EventHandler(this.BtnBrouwseOutput_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(217, 251);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 7;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(308, 251);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnParsePPT
            // 
            this.BtnParsePPT.Location = new System.Drawing.Point(105, 143);
            this.BtnParsePPT.Name = "BtnParsePPT";
            this.BtnParsePPT.Size = new System.Drawing.Size(75, 23);
            this.BtnParsePPT.TabIndex = 9;
            this.BtnParsePPT.Text = "Parse PPT";
            this.BtnParsePPT.UseVisualStyleBackColor = true;
            this.BtnParsePPT.Click += new System.EventHandler(this.BtnParsePPT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnParsePPT);
            this.groupBox1.Controls.Add(this.TBSourceFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TBOutputFile);
            this.groupBox1.Controls.Add(this.BtnBrouwseOutput);
            this.groupBox1.Controls.Add(this.BtnBrowsePPT);
            this.groupBox1.Location = new System.Drawing.Point(27, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 176);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBSourceFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBOutputFile;
        private System.Windows.Forms.Button BtnBrowsePPT;
        private System.Windows.Forms.Button BtnBrouwseOutput;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnParsePPT;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

