
namespace KlijentskaApp
{
    partial class Main
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
            this.btnPretrazivanje = new System.Windows.Forms.Button();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.btnJAXB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXSD
            // 
            this.btnXSD.Location = new System.Drawing.Point(324, 35);
            this.btnXSD.Name = "btnXSD";
            this.btnXSD.Size = new System.Drawing.Size(141, 23);
            this.btnXSD.TabIndex = 0;
            this.btnXSD.Text = "XSD validacija";
            this.btnXSD.UseVisualStyleBackColor = true;
            this.btnXSD.Click += new System.EventHandler(this.btnXSD_Click);
            // 
            // btnRNG
            // 
            this.btnRNG.Location = new System.Drawing.Point(324, 76);
            this.btnRNG.Name = "btnRNG";
            this.btnRNG.Size = new System.Drawing.Size(141, 23);
            this.btnRNG.TabIndex = 1;
            this.btnRNG.Text = "Relax NG validacija";
            this.btnRNG.UseVisualStyleBackColor = true;
            this.btnRNG.Click += new System.EventHandler(this.btnRNG_Click);
            // 
            // btnPretrazivanje
            // 
            this.btnPretrazivanje.Location = new System.Drawing.Point(324, 119);
            this.btnPretrazivanje.Name = "btnPretrazivanje";
            this.btnPretrazivanje.Size = new System.Drawing.Size(141, 23);
            this.btnPretrazivanje.TabIndex = 2;
            this.btnPretrazivanje.Text = "Pretraživanje entiteta";
            this.btnPretrazivanje.UseVisualStyleBackColor = true;
            this.btnPretrazivanje.Click += new System.EventHandler(this.btnPretrazivanje_Click);
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.Location = new System.Drawing.Point(324, 160);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(141, 23);
            this.btnTemperatura.TabIndex = 3;
            this.btnTemperatura.Text = "Temperatura grada";
            this.btnTemperatura.UseVisualStyleBackColor = true;
            this.btnTemperatura.Click += new System.EventHandler(this.btnTemperatura_Click);
            // 
            // btnJAXB
            // 
            this.btnJAXB.Location = new System.Drawing.Point(324, 200);
            this.btnJAXB.Name = "btnJAXB";
            this.btnJAXB.Size = new System.Drawing.Size(141, 23);
            this.btnJAXB.TabIndex = 4;
            this.btnJAXB.Text = "JAXB";
            this.btnJAXB.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJAXB);
            this.Controls.Add(this.btnTemperatura);
            this.Controls.Add(this.btnPretrazivanje);
            this.Controls.Add(this.btnRNG);
            this.Controls.Add(this.btnXSD);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXSD;
        private System.Windows.Forms.Button btnRNG;
        private System.Windows.Forms.Button btnPretrazivanje;
        private System.Windows.Forms.Button btnTemperatura;
        private System.Windows.Forms.Button btnJAXB;
    }
}