namespace Chapter05Program02
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFullDateTime = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtLongDate = new System.Windows.Forms.TextBox();
            this.txtShortDate = new System.Windows.Forms.TextBox();
            this.txtGeneralDateTime = new System.Windows.Forms.TextBox();
            this.txtLongtime = new System.Windows.Forms.TextBox();
            this.txtShortTime = new System.Windows.Forms.TextBox();
            this.txtDaysUntilNewYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Date and Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Long Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Short Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "General Date and Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Long Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Short Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Days until New Years";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFullDateTime
            // 
            this.txtFullDateTime.Location = new System.Drawing.Point(189, 9);
            this.txtFullDateTime.Name = "txtFullDateTime";
            this.txtFullDateTime.Size = new System.Drawing.Size(241, 20);
            this.txtFullDateTime.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 218);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(355, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtLongDate
            // 
            this.txtLongDate.Location = new System.Drawing.Point(189, 39);
            this.txtLongDate.Name = "txtLongDate";
            this.txtLongDate.Size = new System.Drawing.Size(241, 20);
            this.txtLongDate.TabIndex = 10;
            // 
            // txtShortDate
            // 
            this.txtShortDate.Location = new System.Drawing.Point(189, 68);
            this.txtShortDate.Name = "txtShortDate";
            this.txtShortDate.Size = new System.Drawing.Size(241, 20);
            this.txtShortDate.TabIndex = 11;
            // 
            // txtGeneralDateTime
            // 
            this.txtGeneralDateTime.Location = new System.Drawing.Point(189, 97);
            this.txtGeneralDateTime.Name = "txtGeneralDateTime";
            this.txtGeneralDateTime.Size = new System.Drawing.Size(241, 20);
            this.txtGeneralDateTime.TabIndex = 12;
            // 
            // txtLongtime
            // 
            this.txtLongtime.Location = new System.Drawing.Point(189, 126);
            this.txtLongtime.Name = "txtLongtime";
            this.txtLongtime.Size = new System.Drawing.Size(241, 20);
            this.txtLongtime.TabIndex = 13;
            // 
            // txtShortTime
            // 
            this.txtShortTime.Location = new System.Drawing.Point(189, 156);
            this.txtShortTime.Name = "txtShortTime";
            this.txtShortTime.Size = new System.Drawing.Size(241, 20);
            this.txtShortTime.TabIndex = 14;
            // 
            // txtDaysUntilNewYear
            // 
            this.txtDaysUntilNewYear.Location = new System.Drawing.Point(189, 182);
            this.txtDaysUntilNewYear.Name = "txtDaysUntilNewYear";
            this.txtDaysUntilNewYear.Size = new System.Drawing.Size(241, 20);
            this.txtDaysUntilNewYear.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 248);
            this.Controls.Add(this.txtDaysUntilNewYear);
            this.Controls.Add(this.txtShortTime);
            this.Controls.Add(this.txtLongtime);
            this.Controls.Add(this.txtGeneralDateTime);
            this.Controls.Add(this.txtShortDate);
            this.Controls.Add(this.txtLongDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtFullDateTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DateTime Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFullDateTime;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLongDate;
        private System.Windows.Forms.TextBox txtShortDate;
        private System.Windows.Forms.TextBox txtGeneralDateTime;
        private System.Windows.Forms.TextBox txtLongtime;
        private System.Windows.Forms.TextBox txtShortTime;
        private System.Windows.Forms.TextBox txtDaysUntilNewYear;
    }
}

