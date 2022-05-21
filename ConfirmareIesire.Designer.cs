namespace PIUGlab2_4
{
    partial class ConfirmareIesire
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
            this.btnSalvati = new System.Windows.Forms.Button();
            this.btnNuSalvati = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doriți să salvați modificările efectuate?";
            // 
            // btnSalvati
            // 
            this.btnSalvati.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSalvati.Location = new System.Drawing.Point(85, 76);
            this.btnSalvati.Name = "btnSalvati";
            this.btnSalvati.Size = new System.Drawing.Size(75, 23);
            this.btnSalvati.TabIndex = 1;
            this.btnSalvati.Text = "Salvați";
            this.btnSalvati.UseVisualStyleBackColor = true;
            // 
            // btnNuSalvati
            // 
            this.btnNuSalvati.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNuSalvati.Location = new System.Drawing.Point(166, 76);
            this.btnNuSalvati.Name = "btnNuSalvati";
            this.btnNuSalvati.Size = new System.Drawing.Size(75, 23);
            this.btnNuSalvati.TabIndex = 2;
            this.btnNuSalvati.Text = "Nu salvați";
            this.btnNuSalvati.UseVisualStyleBackColor = true;
            // 
            // btnAnulare
            // 
            this.btnAnulare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulare.Location = new System.Drawing.Point(247, 76);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(75, 23);
            this.btnAnulare.TabIndex = 3;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            // 
            // ConfirmareIesire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnNuSalvati);
            this.Controls.Add(this.btnSalvati);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmareIesire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmare ieșire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvati;
        private System.Windows.Forms.Button btnNuSalvati;
        private System.Windows.Forms.Button btnAnulare;
    }
}