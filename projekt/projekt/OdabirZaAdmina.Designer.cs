namespace projekt
{
    partial class OdabirZaAdmina
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
            this.btnClan = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClan
            // 
            this.btnClan.Location = new System.Drawing.Point(71, 48);
            this.btnClan.Name = "btnClan";
            this.btnClan.Size = new System.Drawing.Size(117, 54);
            this.btnClan.TabIndex = 0;
            this.btnClan.Text = "Članovi";
            this.btnClan.UseVisualStyleBackColor = true;
            this.btnClan.Click += new System.EventHandler(this.btnClan_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(66, 142);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(122, 56);
            this.btnIzvjestaj.TabIndex = 1;
            this.btnIzvjestaj.Text = " Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // OdabirZaAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnClan);
            this.Name = "OdabirZaAdmina";
            this.Text = "Odabir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClan;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}