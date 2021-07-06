
namespace ClientApp
{
    partial class RNGValidacija
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
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBrojMobitela = new System.Windows.Forms.Label();
            this.txtBrojMobitela = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblOIB = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.btnRNG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(327, 36);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(330, 52);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(148, 20);
            this.txtIme.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(327, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(330, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblBrojMobitela
            // 
            this.lblBrojMobitela.AutoSize = true;
            this.lblBrojMobitela.Location = new System.Drawing.Point(327, 158);
            this.lblBrojMobitela.Name = "lblBrojMobitela";
            this.lblBrojMobitela.Size = new System.Drawing.Size(67, 13);
            this.lblBrojMobitela.TabIndex = 4;
            this.lblBrojMobitela.Text = "Broj mobitela";
            // 
            // txtBrojMobitela
            // 
            this.txtBrojMobitela.Location = new System.Drawing.Point(330, 174);
            this.txtBrojMobitela.Name = "txtBrojMobitela";
            this.txtBrojMobitela.Size = new System.Drawing.Size(148, 20);
            this.txtBrojMobitela.TabIndex = 5;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(327, 218);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 6;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(330, 234);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(148, 20);
            this.txtAdresa.TabIndex = 7;
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(327, 278);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(25, 13);
            this.lblOIB.TabIndex = 8;
            this.lblOIB.Text = "OIB";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(330, 294);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(148, 20);
            this.txtOIB.TabIndex = 9;
            // 
            // btnRNG
            // 
            this.btnRNG.Location = new System.Drawing.Point(330, 337);
            this.btnRNG.Name = "btnRNG";
            this.btnRNG.Size = new System.Drawing.Size(148, 23);
            this.btnRNG.TabIndex = 10;
            this.btnRNG.Text = "Dodaj kupca";
            this.btnRNG.UseVisualStyleBackColor = true;
            this.btnRNG.Click += new System.EventHandler(this.btnRNG_Click);
            // 
            // RNGValidacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRNG);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtBrojMobitela);
            this.Controls.Add(this.lblBrojMobitela);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Name = "RNGValidacija";
            this.Text = "RNGValidacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBrojMobitela;
        private System.Windows.Forms.TextBox txtBrojMobitela;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Button btnRNG;
    }
}