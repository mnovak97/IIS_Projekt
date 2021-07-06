
namespace ClientApp
{
    partial class Temperatura
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
            this.lblGrad = new System.Windows.Forms.Label();
            this.txtImeGrada = new System.Windows.Forms.TextBox();
            this.lblTempGrad = new System.Windows.Forms.Label();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(248, 102);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(91, 13);
            this.lblGrad.TabIndex = 0;
            this.lblGrad.Text = "Upišite ime grada:";
            // 
            // txtImeGrada
            // 
            this.txtImeGrada.Location = new System.Drawing.Point(345, 99);
            this.txtImeGrada.Name = "txtImeGrada";
            this.txtImeGrada.Size = new System.Drawing.Size(100, 20);
            this.txtImeGrada.TabIndex = 1;
            // 
            // lblTempGrad
            // 
            this.lblTempGrad.AutoSize = true;
            this.lblTempGrad.Location = new System.Drawing.Point(231, 191);
            this.lblTempGrad.Name = "lblTempGrad";
            this.lblTempGrad.Size = new System.Drawing.Size(108, 13);
            this.lblTempGrad.TabIndex = 2;
            this.lblTempGrad.Text = "Temperatura za grad:";
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.Location = new System.Drawing.Point(345, 125);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(100, 23);
            this.btnTemperatura.TabIndex = 3;
            this.btnTemperatura.Text = "Temperatura";
            this.btnTemperatura.UseVisualStyleBackColor = true;
            this.btnTemperatura.Click += new System.EventHandler(this.btnTemperatura_Click);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(342, 191);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(0, 13);
            this.lblTemperatura.TabIndex = 4;
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 442);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.btnTemperatura);
            this.Controls.Add(this.lblTempGrad);
            this.Controls.Add(this.txtImeGrada);
            this.Controls.Add(this.lblGrad);
            this.Name = "Temperatura";
            this.Text = "Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.TextBox txtImeGrada;
        private System.Windows.Forms.Label lblTempGrad;
        private System.Windows.Forms.Button btnTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
    }
}