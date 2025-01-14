﻿namespace cryptographicApplication
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.textBoxKey1 = new System.Windows.Forms.TextBox();
            this.textBoxChiper1 = new System.Windows.Forms.TextBox();
            this.labelPlain = new System.Windows.Forms.Label();
            this.labelKey1 = new System.Windows.Forms.Label();
            this.labelCiper1 = new System.Windows.Forms.Label();
            this.labelKey2 = new System.Windows.Forms.Label();
            this.textBoxKey2 = new System.Windows.Forms.TextBox();
            this.textBoxCiper2 = new System.Windows.Forms.TextBox();
            this.labelCiper2 = new System.Windows.Forms.Label();
            this.labelCiper3 = new System.Windows.Forms.Label();
            this.textBoxChiper3 = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.labelSymbols = new System.Windows.Forms.Label();
            this.labelSymbolsAll = new System.Windows.Forms.Label();
            this.labelKey3 = new System.Windows.Forms.Label();
            this.labelKey4 = new System.Windows.Forms.Label();
            this.textBoxKey3 = new System.Windows.Forms.TextBox();
            this.textBoxKey4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(520, 689);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 34);
            this.buttonEncrypt.TabIndex = 10;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlain.Location = new System.Drawing.Point(23, 102);
            this.textBoxPlain.Multiline = true;
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(575, 67);
            this.textBoxPlain.TabIndex = 7;
            // 
            // textBoxKey1
            // 
            this.textBoxKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKey1.Location = new System.Drawing.Point(23, 193);
            this.textBoxKey1.Name = "textBoxKey1";
            this.textBoxKey1.Size = new System.Drawing.Size(575, 24);
            this.textBoxKey1.TabIndex = 8;
            // 
            // textBoxChiper1
            // 
            this.textBoxChiper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChiper1.Location = new System.Drawing.Point(23, 249);
            this.textBoxChiper1.Multiline = true;
            this.textBoxChiper1.Name = "textBoxChiper1";
            this.textBoxChiper1.Size = new System.Drawing.Size(575, 64);
            this.textBoxChiper1.TabIndex = 9;
            // 
            // labelPlain
            // 
            this.labelPlain.AutoSize = true;
            this.labelPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlain.Location = new System.Drawing.Point(20, 81);
            this.labelPlain.Name = "labelPlain";
            this.labelPlain.Size = new System.Drawing.Size(71, 18);
            this.labelPlain.TabIndex = 11;
            this.labelPlain.Text = "Plain text:";
            // 
            // labelKey1
            // 
            this.labelKey1.AutoSize = true;
            this.labelKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey1.Location = new System.Drawing.Point(20, 172);
            this.labelKey1.Name = "labelKey1";
            this.labelKey1.Size = new System.Drawing.Size(45, 18);
            this.labelKey1.TabIndex = 12;
            this.labelKey1.Text = "Key1:";
            // 
            // labelCiper1
            // 
            this.labelCiper1.AutoSize = true;
            this.labelCiper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCiper1.Location = new System.Drawing.Point(20, 228);
            this.labelCiper1.Name = "labelCiper1";
            this.labelCiper1.Size = new System.Drawing.Size(146, 18);
            this.labelCiper1.TabIndex = 13;
            this.labelCiper1.Text = "Polyaplhabetic Ciper:";
            // 
            // labelKey2
            // 
            this.labelKey2.AutoSize = true;
            this.labelKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey2.Location = new System.Drawing.Point(20, 325);
            this.labelKey2.Name = "labelKey2";
            this.labelKey2.Size = new System.Drawing.Size(45, 18);
            this.labelKey2.TabIndex = 14;
            this.labelKey2.Text = "Key2:";
            // 
            // textBoxKey2
            // 
            this.textBoxKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKey2.Location = new System.Drawing.Point(23, 344);
            this.textBoxKey2.Name = "textBoxKey2";
            this.textBoxKey2.Size = new System.Drawing.Size(575, 24);
            this.textBoxKey2.TabIndex = 15;
            // 
            // textBoxCiper2
            // 
            this.textBoxCiper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCiper2.Location = new System.Drawing.Point(23, 402);
            this.textBoxCiper2.Multiline = true;
            this.textBoxCiper2.Name = "textBoxCiper2";
            this.textBoxCiper2.Size = new System.Drawing.Size(575, 64);
            this.textBoxCiper2.TabIndex = 16;
            // 
            // labelCiper2
            // 
            this.labelCiper2.AutoSize = true;
            this.labelCiper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCiper2.Location = new System.Drawing.Point(20, 383);
            this.labelCiper2.Name = "labelCiper2";
            this.labelCiper2.Size = new System.Drawing.Size(141, 18);
            this.labelCiper2.TabIndex = 17;
            this.labelCiper2.Text = "Transposition Ciper:";
            // 
            // labelCiper3
            // 
            this.labelCiper3.AutoSize = true;
            this.labelCiper3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCiper3.Location = new System.Drawing.Point(20, 591);
            this.labelCiper3.Name = "labelCiper3";
            this.labelCiper3.Size = new System.Drawing.Size(205, 18);
            this.labelCiper3.TabIndex = 18;
            this.labelCiper3.Text = "Simple Monoalphabetic Ciper:";
            // 
            // textBoxChiper3
            // 
            this.textBoxChiper3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChiper3.Location = new System.Drawing.Point(23, 610);
            this.textBoxChiper3.Multiline = true;
            this.textBoxChiper3.Name = "textBoxChiper3";
            this.textBoxChiper3.Size = new System.Drawing.Size(575, 64);
            this.textBoxChiper3.TabIndex = 19;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(439, 689);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 34);
            this.buttonDecrypt.TabIndex = 20;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // labelSymbols
            // 
            this.labelSymbols.AutoSize = true;
            this.labelSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSymbols.Location = new System.Drawing.Point(20, 19);
            this.labelSymbols.Name = "labelSymbols";
            this.labelSymbols.Size = new System.Drawing.Size(123, 18);
            this.labelSymbols.TabIndex = 21;
            this.labelSymbols.Text = "Allowed symbols:";
            // 
            // labelSymbolsAll
            // 
            this.labelSymbolsAll.AutoSize = true;
            this.labelSymbolsAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelSymbolsAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSymbolsAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSymbolsAll.Location = new System.Drawing.Point(22, 42);
            this.labelSymbolsAll.Name = "labelSymbolsAll";
            this.labelSymbolsAll.Size = new System.Drawing.Size(372, 20);
            this.labelSymbolsAll.TabIndex = 22;
            this.labelSymbolsAll.Text = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            // 
            // labelKey3
            // 
            this.labelKey3.AutoSize = true;
            this.labelKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey3.Location = new System.Drawing.Point(23, 475);
            this.labelKey3.Name = "labelKey3";
            this.labelKey3.Size = new System.Drawing.Size(109, 18);
            this.labelKey3.TabIndex = 23;
            this.labelKey3.Text = "Key3: (number)";
            // 
            // labelKey4
            // 
            this.labelKey4.AutoSize = true;
            this.labelKey4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey4.Location = new System.Drawing.Point(22, 532);
            this.labelKey4.Name = "labelKey4";
            this.labelKey4.Size = new System.Drawing.Size(109, 18);
            this.labelKey4.TabIndex = 24;
            this.labelKey4.Text = "Key4: (number)";
            // 
            // textBoxKey3
            // 
            this.textBoxKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKey3.Location = new System.Drawing.Point(23, 498);
            this.textBoxKey3.Name = "textBoxKey3";
            this.textBoxKey3.Size = new System.Drawing.Size(575, 24);
            this.textBoxKey3.TabIndex = 25;
            // 
            // textBoxKey4
            // 
            this.textBoxKey4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKey4.Location = new System.Drawing.Point(23, 555);
            this.textBoxKey4.Name = "textBoxKey4";
            this.textBoxKey4.Size = new System.Drawing.Size(575, 24);
            this.textBoxKey4.TabIndex = 26;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 753);
            this.Controls.Add(this.textBoxKey4);
            this.Controls.Add(this.textBoxKey3);
            this.Controls.Add(this.labelKey4);
            this.Controls.Add(this.labelKey3);
            this.Controls.Add(this.labelSymbolsAll);
            this.Controls.Add(this.labelSymbols);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.textBoxChiper3);
            this.Controls.Add(this.labelCiper3);
            this.Controls.Add(this.labelCiper2);
            this.Controls.Add(this.textBoxCiper2);
            this.Controls.Add(this.textBoxKey2);
            this.Controls.Add(this.labelKey2);
            this.Controls.Add(this.labelCiper1);
            this.Controls.Add(this.labelKey1);
            this.Controls.Add(this.labelPlain);
            this.Controls.Add(this.textBoxChiper1);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxKey1);
            this.Controls.Add(this.textBoxPlain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Substitutional-Transpositional-Substitutional Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.TextBox textBoxKey1;
        private System.Windows.Forms.TextBox textBoxChiper1;
        private System.Windows.Forms.Label labelPlain;
        private System.Windows.Forms.Label labelKey1;
        private System.Windows.Forms.Label labelCiper1;
        private System.Windows.Forms.Label labelKey2;
        private System.Windows.Forms.TextBox textBoxKey2;
        private System.Windows.Forms.TextBox textBoxCiper2;
        private System.Windows.Forms.Label labelCiper2;
        private System.Windows.Forms.Label labelCiper3;
        private System.Windows.Forms.TextBox textBoxChiper3;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label labelSymbols;
        private System.Windows.Forms.Label labelSymbolsAll;
        private System.Windows.Forms.Label labelKey3;
        private System.Windows.Forms.Label labelKey4;
        private System.Windows.Forms.TextBox textBoxKey3;
        private System.Windows.Forms.TextBox textBoxKey4;
    }
}

