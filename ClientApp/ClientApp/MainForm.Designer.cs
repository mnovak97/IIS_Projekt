﻿
namespace ClientApp
{
    partial class MainForm
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
            this.btnXSD = new System.Windows.Forms.Button();
            this.btnRNG = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.btnJAXB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXSD
            // 
            this.btnXSD.Location = new System.Drawing.Point(327, 82);
            this.btnXSD.Name = "btnXSD";
            this.btnXSD.Size = new System.Drawing.Size(126, 23);
            this.btnXSD.TabIndex = 0;
            this.btnXSD.Text = "XSD Validacija";
            this.btnXSD.UseVisualStyleBackColor = true;
            this.btnXSD.Click += new System.EventHandler(this.btnXSD_Click);
            // 
            // btnRNG
            // 
            this.btnRNG.Location = new System.Drawing.Point(327, 129);
            this.btnRNG.Name = "btnRNG";
            this.btnRNG.Size = new System.Drawing.Size(126, 23);
            this.btnRNG.TabIndex = 1;
            this.btnRNG.Text = "RNG Validacija";
            this.btnRNG.UseVisualStyleBackColor = true;
            this.btnRNG.Click += new System.EventHandler(this.btnRNG_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(327, 173);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(126, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Pretraživanje entiteta";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.Location = new System.Drawing.Point(327, 220);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(126, 23);
            this.btnTemperatura.TabIndex = 3;
            this.btnTemperatura.Text = "Temperatura grada";
            this.btnTemperatura.UseVisualStyleBackColor = true;
            this.btnTemperatura.Click += new System.EventHandler(this.btnTemperatura_Click);
            // 
            // btnJAXB
            // 
            this.btnJAXB.Location = new System.Drawing.Point(327, 263);
            this.btnJAXB.Name = "btnJAXB";
            this.btnJAXB.Size = new System.Drawing.Size(126, 23);
            this.btnJAXB.TabIndex = 4;
            this.btnJAXB.Text = "JAXB";
            this.btnJAXB.UseVisualStyleBackColor = true;
            this.btnJAXB.Click += new System.EventHandler(this.btnJAXB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJAXB);
            this.Controls.Add(this.btnTemperatura);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRNG);
            this.Controls.Add(this.btnXSD);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXSD;
        private System.Windows.Forms.Button btnRNG;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnTemperatura;
        private System.Windows.Forms.Button btnJAXB;
    }
}