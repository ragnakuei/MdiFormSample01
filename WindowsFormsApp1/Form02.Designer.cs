﻿namespace WindowsFormsApp1
{
    partial class Form02
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
            this.btnCloseForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseForm3
            // 
            this.btnCloseForm3.Location = new System.Drawing.Point(81, 56);
            this.btnCloseForm3.Name = "btnCloseForm3";
            this.btnCloseForm3.Size = new System.Drawing.Size(75, 23);
            this.btnCloseForm3.TabIndex = 0;
            this.btnCloseForm3.Text = "Close Form3";
            this.btnCloseForm3.UseVisualStyleBackColor = true;
            this.btnCloseForm3.Click += new System.EventHandler(this.btnCloseForm3_Click);
            // 
            // Form02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 150);
            this.Controls.Add(this.btnCloseForm3);
            this.Name = "Form02";
            this.Text = "Form02";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseForm3;
    }
}