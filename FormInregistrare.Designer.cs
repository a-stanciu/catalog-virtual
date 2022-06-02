namespace PIUGlab2_4
{
    partial class FormInregistrare
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtConfirmParola = new System.Windows.Forms.TextBox();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.errConfirmParola = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errParola = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmParola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errParola)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parolă:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmați parola:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(155, 67);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(180, 22);
            this.txtNume.TabIndex = 3;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(155, 93);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(180, 22);
            this.txtParola.TabIndex = 4;
            this.txtParola.UseSystemPasswordChar = true;
            this.txtParola.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            // 
            // txtConfirmParola
            // 
            this.txtConfirmParola.Location = new System.Drawing.Point(155, 119);
            this.txtConfirmParola.Name = "txtConfirmParola";
            this.txtConfirmParola.Size = new System.Drawing.Size(180, 22);
            this.txtConfirmParola.TabIndex = 5;
            this.txtConfirmParola.UseSystemPasswordChar = true;
            this.txtConfirmParola.TextChanged += new System.EventHandler(this.txtConfirmParola_TextChanged);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Enabled = false;
            this.btnInregistrare.Location = new System.Drawing.Point(216, 180);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(75, 23);
            this.btnInregistrare.TabIndex = 6;
            this.btnInregistrare.Text = "Înregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulare.Location = new System.Drawing.Point(297, 180);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(75, 23);
            this.btnAnulare.TabIndex = 7;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 43);
            this.label4.TabIndex = 8;
            this.label4.Text = "Introduceți numele dvs. și parola. Parola trebuie să conțină minim 8 caractere, o" +
    " literă și o cifră. Pentru a vă asigura că parola este corectă, introduceți-o di" +
    "n nou.";
            // 
            // errConfirmParola
            // 
            this.errConfirmParola.BlinkRate = 0;
            this.errConfirmParola.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errConfirmParola.ContainerControl = this;
            // 
            // errNume
            // 
            this.errNume.BlinkRate = 0;
            this.errNume.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errNume.ContainerControl = this;
            // 
            // errParola
            // 
            this.errParola.BlinkRate = 0;
            this.errParola.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errParola.ContainerControl = this;
            // 
            // FormInregistrare
            // 
            this.AcceptButton = this.btnInregistrare;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnAnulare;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.txtConfirmParola);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInregistrare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Înregistrare";
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmParola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errParola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtConfirmParola;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errConfirmParola;
        private System.Windows.Forms.ErrorProvider errNume;
        private System.Windows.Forms.ErrorProvider errParola;
    }
}