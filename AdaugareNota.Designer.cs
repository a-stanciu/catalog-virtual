namespace PIUGlab2_4
{
    partial class AdaugareNota
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
            this.numNota = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota:";
            // 
            // numNota
            // 
            this.numNota.Location = new System.Drawing.Point(54, 12);
            this.numNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(46, 22);
            this.numNota.TabIndex = 1;
            this.numNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNota.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "%";
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(146, 95);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 3;
            this.btnAdaugare.Text = "Adăugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(227, 95);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(75, 23);
            this.btnAnulare.TabIndex = 4;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(54, 38);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 6;
            // 
            // AdaugareNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(314, 130);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numNota);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdaugareNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adăugare notă";
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}