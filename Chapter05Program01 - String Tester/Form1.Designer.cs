namespace Chapter05Program01New
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
            this.btnExist = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.txtReplaceChars = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRemoveResult = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubstringResult = new System.Windows.Forms.TextBox();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.txtEndIndex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.txtLastChar = new System.Windows.Forms.TextBox();
            this.lblLastIndexOf = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIndexOf = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchIndex = new System.Windows.Forms.TextBox();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.txtToLower = new System.Windows.Forms.TextBox();
            this.txtToUpper = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(622, 276);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(75, 23);
            this.btnExist.TabIndex = 74;
            this.btnExist.Text = "&Exist";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.BtnExist_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(9, 276);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 73;
            this.btnTest.Text = "&Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Location = new System.Drawing.Point(170, 243);
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.Size = new System.Drawing.Size(527, 20);
            this.txtReplaceResult.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Location = new System.Drawing.Point(9, 243);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(155, 17);
            this.label14.TabIndex = 71;
            this.label14.Text = "txtInput.Replace()";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(437, 217);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceWith.TabIndex = 70;
            this.txtReplaceWith.Text = "***";
            // 
            // txtReplaceChars
            // 
            this.txtReplaceChars.Location = new System.Drawing.Point(170, 216);
            this.txtReplaceChars.Name = "txtReplaceChars";
            this.txtReplaceChars.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceChars.TabIndex = 69;
            this.txtReplaceChars.Text = "1234567890";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Location = new System.Drawing.Point(9, 219);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(155, 17);
            this.label13.TabIndex = 68;
            this.label13.Text = "Find";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemoveResult
            // 
            this.txtRemoveResult.Location = new System.Drawing.Point(276, 191);
            this.txtRemoveResult.Name = "txtRemoveResult";
            this.txtRemoveResult.Size = new System.Drawing.Size(421, 20);
            this.txtRemoveResult.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Location = new System.Drawing.Point(276, 217);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(155, 17);
            this.label12.TabIndex = 66;
            this.label12.Text = "Replace with";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(170, 191);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(100, 20);
            this.txtRemove.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Location = new System.Drawing.Point(9, 191);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(155, 17);
            this.label11.TabIndex = 64;
            this.label11.Text = "txtInput.Remove()";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubstringResult
            // 
            this.txtSubstringResult.Location = new System.Drawing.Point(568, 165);
            this.txtSubstringResult.Name = "txtSubstringResult";
            this.txtSubstringResult.Size = new System.Drawing.Size(129, 20);
            this.txtSubstringResult.TabIndex = 63;
            // 
            // lblSubstring
            // 
            this.lblSubstring.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubstring.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSubstring.Location = new System.Drawing.Point(400, 165);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubstring.Size = new System.Drawing.Size(162, 19);
            this.lblSubstring.TabIndex = 62;
            this.lblSubstring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndIndex
            // 
            this.txtEndIndex.Location = new System.Drawing.Point(347, 164);
            this.txtEndIndex.Name = "txtEndIndex";
            this.txtEndIndex.Size = new System.Drawing.Size(47, 20);
            this.txtEndIndex.TabIndex = 61;
            this.txtEndIndex.Text = "7";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Location = new System.Drawing.Point(223, 164);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "for this many characters";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(170, 161);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(47, 20);
            this.txtStartIndex.TabIndex = 59;
            this.txtStartIndex.Text = "18";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(9, 162);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Extract Subscring from Index";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(650, 133);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(47, 20);
            this.txtLastIndexOf.TabIndex = 57;
            // 
            // txtLastChar
            // 
            this.txtLastChar.Location = new System.Drawing.Point(170, 135);
            this.txtLastChar.Name = "txtLastChar";
            this.txtLastChar.Size = new System.Drawing.Size(47, 20);
            this.txtLastChar.TabIndex = 56;
            this.txtLastChar.Text = "s";
            // 
            // lblLastIndexOf
            // 
            this.lblLastIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastIndexOf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLastIndexOf.Location = new System.Drawing.Point(223, 136);
            this.lblLastIndexOf.Name = "lblLastIndexOf";
            this.lblLastIndexOf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastIndexOf.Size = new System.Drawing.Size(421, 17);
            this.lblLastIndexOf.TabIndex = 55;
            this.lblLastIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(9, 136);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Search for last Character";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIndexOf
            // 
            this.lblIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndexOf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblIndexOf.Location = new System.Drawing.Point(223, 109);
            this.lblIndexOf.Name = "lblIndexOf";
            this.lblIndexOf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIndexOf.Size = new System.Drawing.Size(421, 17);
            this.lblIndexOf.TabIndex = 53;
            this.lblIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(9, 109);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Search for Character";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(9, 83);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "String ToLower()";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "String ToUpper()";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "String Length";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "String to test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchIndex
            // 
            this.txtSearchIndex.Location = new System.Drawing.Point(650, 106);
            this.txtSearchIndex.Name = "txtSearchIndex";
            this.txtSearchIndex.Size = new System.Drawing.Size(47, 20);
            this.txtSearchIndex.TabIndex = 47;
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.Location = new System.Drawing.Point(170, 106);
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(47, 20);
            this.txtSearchChar.TabIndex = 46;
            this.txtSearchChar.Text = "v";
            // 
            // txtToLower
            // 
            this.txtToLower.Location = new System.Drawing.Point(170, 80);
            this.txtToLower.Name = "txtToLower";
            this.txtToLower.Size = new System.Drawing.Size(527, 20);
            this.txtToLower.TabIndex = 45;
            // 
            // txtToUpper
            // 
            this.txtToUpper.Location = new System.Drawing.Point(170, 54);
            this.txtToUpper.Name = "txtToUpper";
            this.txtToUpper.Size = new System.Drawing.Size(527, 20);
            this.txtToUpper.TabIndex = 44;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(170, 29);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(47, 20);
            this.txtLength.TabIndex = 43;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(170, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(527, 20);
            this.txtInput.TabIndex = 42;
            this.txtInput.Text = "This is a test of various strting METHODS, 1234567890 and z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 308);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtReplaceResult);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.txtReplaceChars);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRemoveResult);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSubstringResult);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.txtEndIndex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.txtLastChar);
            this.Controls.Add(this.lblLastIndexOf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIndexOf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchIndex);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.txtToLower);
            this.Controls.Add(this.txtToUpper);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "String Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtReplaceResult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.TextBox txtReplaceChars;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRemoveResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSubstringResult;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.TextBox txtEndIndex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLastIndexOf;
        private System.Windows.Forms.TextBox txtLastChar;
        private System.Windows.Forms.Label lblLastIndexOf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIndexOf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchIndex;
        private System.Windows.Forms.TextBox txtSearchChar;
        private System.Windows.Forms.TextBox txtToLower;
        private System.Windows.Forms.TextBox txtToUpper;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtInput;
    }
}

