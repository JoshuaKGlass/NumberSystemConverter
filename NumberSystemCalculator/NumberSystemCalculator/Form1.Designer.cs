namespace NumberSystemCalculator
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.rdoDenary1 = new System.Windows.Forms.RadioButton();
            this.rdoHex1 = new System.Windows.Forms.RadioButton();
            this.rdoOctal1 = new System.Windows.Forms.RadioButton();
            this.rdoBinary1 = new System.Windows.Forms.RadioButton();
            this.grboxOptions1 = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDenary2 = new System.Windows.Forms.RadioButton();
            this.rdoHexadecimal2 = new System.Windows.Forms.RadioButton();
            this.rdoOctal2 = new System.Windows.Forms.RadioButton();
            this.rdoBinary2 = new System.Windows.Forms.RadioButton();
            this.grboxOptions1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(425, 193);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 0;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(239, 188);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(154, 25);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "Enter Number";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConvert.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(292, 248);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(201, 46);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(346, 307);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(83, 25);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // rdoDenary1
            // 
            this.rdoDenary1.AutoSize = true;
            this.rdoDenary1.Location = new System.Drawing.Point(32, 21);
            this.rdoDenary1.Name = "rdoDenary1";
            this.rdoDenary1.Size = new System.Drawing.Size(75, 21);
            this.rdoDenary1.TabIndex = 6;
            this.rdoDenary1.TabStop = true;
            this.rdoDenary1.Text = "Denary";
            this.rdoDenary1.UseVisualStyleBackColor = true;
            // 
            // rdoHex1
            // 
            this.rdoHex1.AutoSize = true;
            this.rdoHex1.Location = new System.Drawing.Point(32, 102);
            this.rdoHex1.Name = "rdoHex1";
            this.rdoHex1.Size = new System.Drawing.Size(109, 21);
            this.rdoHex1.TabIndex = 7;
            this.rdoHex1.TabStop = true;
            this.rdoHex1.Text = "Hexadecimal";
            this.rdoHex1.UseVisualStyleBackColor = true;
            // 
            // rdoOctal1
            // 
            this.rdoOctal1.AutoSize = true;
            this.rdoOctal1.Location = new System.Drawing.Point(32, 75);
            this.rdoOctal1.Name = "rdoOctal1";
            this.rdoOctal1.Size = new System.Drawing.Size(62, 21);
            this.rdoOctal1.TabIndex = 8;
            this.rdoOctal1.TabStop = true;
            this.rdoOctal1.Text = "Octal";
            this.rdoOctal1.UseVisualStyleBackColor = true;
            // 
            // rdoBinary1
            // 
            this.rdoBinary1.AutoSize = true;
            this.rdoBinary1.Location = new System.Drawing.Point(32, 48);
            this.rdoBinary1.Name = "rdoBinary1";
            this.rdoBinary1.Size = new System.Drawing.Size(69, 21);
            this.rdoBinary1.TabIndex = 9;
            this.rdoBinary1.TabStop = true;
            this.rdoBinary1.Text = "Binary";
            this.rdoBinary1.UseVisualStyleBackColor = true;
            // 
            // grboxOptions1
            // 
            this.grboxOptions1.Controls.Add(this.rdoDenary1);
            this.grboxOptions1.Controls.Add(this.rdoHex1);
            this.grboxOptions1.Controls.Add(this.rdoOctal1);
            this.grboxOptions1.Controls.Add(this.rdoBinary1);
            this.grboxOptions1.Location = new System.Drawing.Point(118, 31);
            this.grboxOptions1.Name = "grboxOptions1";
            this.grboxOptions1.Size = new System.Drawing.Size(200, 132);
            this.grboxOptions1.TabIndex = 10;
            this.grboxOptions1.TabStop = false;
            this.grboxOptions1.Text = "Select Number System";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(381, 79);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(48, 17);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "-- to --";
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(149, 363);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(499, 107);
            this.rtbResult.TabIndex = 14;
            this.rtbResult.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDenary2);
            this.groupBox1.Controls.Add(this.rdoHexadecimal2);
            this.groupBox1.Controls.Add(this.rdoOctal2);
            this.groupBox1.Controls.Add(this.rdoBinary2);
            this.groupBox1.Location = new System.Drawing.Point(523, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 132);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Number System";
            // 
            // rdoDenary2
            // 
            this.rdoDenary2.AutoSize = true;
            this.rdoDenary2.Location = new System.Drawing.Point(32, 21);
            this.rdoDenary2.Name = "rdoDenary2";
            this.rdoDenary2.Size = new System.Drawing.Size(75, 21);
            this.rdoDenary2.TabIndex = 6;
            this.rdoDenary2.TabStop = true;
            this.rdoDenary2.Text = "Denary";
            this.rdoDenary2.UseVisualStyleBackColor = true;
            // 
            // rdoHexadecimal2
            // 
            this.rdoHexadecimal2.AutoSize = true;
            this.rdoHexadecimal2.Location = new System.Drawing.Point(32, 102);
            this.rdoHexadecimal2.Name = "rdoHexadecimal2";
            this.rdoHexadecimal2.Size = new System.Drawing.Size(109, 21);
            this.rdoHexadecimal2.TabIndex = 7;
            this.rdoHexadecimal2.TabStop = true;
            this.rdoHexadecimal2.Text = "Hexadecimal";
            this.rdoHexadecimal2.UseVisualStyleBackColor = true;
            // 
            // rdoOctal2
            // 
            this.rdoOctal2.AutoSize = true;
            this.rdoOctal2.Location = new System.Drawing.Point(32, 75);
            this.rdoOctal2.Name = "rdoOctal2";
            this.rdoOctal2.Size = new System.Drawing.Size(62, 21);
            this.rdoOctal2.TabIndex = 8;
            this.rdoOctal2.TabStop = true;
            this.rdoOctal2.Text = "Octal";
            this.rdoOctal2.UseVisualStyleBackColor = true;
            // 
            // rdoBinary2
            // 
            this.rdoBinary2.AutoSize = true;
            this.rdoBinary2.Location = new System.Drawing.Point(32, 48);
            this.rdoBinary2.Name = "rdoBinary2";
            this.rdoBinary2.Size = new System.Drawing.Size(69, 21);
            this.rdoBinary2.TabIndex = 9;
            this.rdoBinary2.TabStop = true;
            this.rdoBinary2.Text = "Binary";
            this.rdoBinary2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.grboxOptions1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grboxOptions1.ResumeLayout(false);
            this.grboxOptions1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rdoDenary1;
        private System.Windows.Forms.RadioButton rdoHex1;
        private System.Windows.Forms.RadioButton rdoOctal1;
        private System.Windows.Forms.RadioButton rdoBinary1;
        private System.Windows.Forms.GroupBox grboxOptions1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDenary2;
        private System.Windows.Forms.RadioButton rdoHexadecimal2;
        private System.Windows.Forms.RadioButton rdoOctal2;
        private System.Windows.Forms.RadioButton rdoBinary2;
    }
}

