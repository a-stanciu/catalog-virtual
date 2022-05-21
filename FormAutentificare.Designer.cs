namespace PIUGlab2_4
{
    partial class FormAutentificare
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
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.linkInregistrare = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.cbNume = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Location = new System.Drawing.Point(290, 146);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(82, 23);
            this.btnAutentificare.TabIndex = 4;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // linkInregistrare
            // 
            this.linkInregistrare.AutoSize = true;
            this.linkInregistrare.Location = new System.Drawing.Point(12, 151);
            this.linkInregistrare.Name = "linkInregistrare";
            this.linkInregistrare.Size = new System.Drawing.Size(80, 13);
            this.linkInregistrare.TabIndex = 5;
            this.linkInregistrare.TabStop = true;
            this.linkInregistrare.Text = "Nu aveți cont?";
            this.linkInregistrare.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInregistrare_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pentru a accesa aplicația, introduceți numele și parola dvs.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parolă:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(128, 84);
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(177, 22);
            this.tbParola.TabIndex = 3;
            this.tbParola.UseSystemPasswordChar = true;
            // 
            // cbNume
            // 
            this.cbNume.FormattingEnabled = true;
            this.cbNume.Location = new System.Drawing.Point(128, 57);
            this.cbNume.Name = "cbNume";
            this.cbNume.Size = new System.Drawing.Size(177, 21);
            this.cbNume.TabIndex = 2;
            // 
            // FormAutentificare
            // 
            this.AcceptButton = this.btnAutentificare;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.cbNume);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkInregistrare);
            this.Controls.Add(this.btnAutentificare);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FormAutentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.FormAutentificare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.LinkLabel linkInregistrare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.ComboBox cbNume;
    }
}

