namespace PIUGlab2_4
{
    partial class Despre
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiereÎnClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSO = new System.Windows.Forms.TextBox();
            this.lblVersiune = new System.Windows.Forms.TextBox();
            this.lblInstalat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalog virtual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "© 2022 Alin Stanciu";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aplicație realizată pentru tema 2 Proiectarea Interfețelor Utilizator și Grafică." +
    "";
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSO);
            this.groupBox1.Controls.Add(this.lblVersiune);
            this.groupBox1.Controls.Add(this.lblInstalat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date tehnice";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiereÎnClipboardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 26);
            // 
            // copiereÎnClipboardToolStripMenuItem
            // 
            this.copiereÎnClipboardToolStripMenuItem.Name = "copiereÎnClipboardToolStripMenuItem";
            this.copiereÎnClipboardToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.copiereÎnClipboardToolStripMenuItem.Text = "Copiere în clipboard";
            this.copiereÎnClipboardToolStripMenuItem.Click += new System.EventHandler(this.copiereÎnClipboardToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "SO:";
            // 
            // lblSO
            // 
            this.lblSO.BackColor = System.Drawing.SystemColors.Window;
            this.lblSO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSO.ContextMenuStrip = this.contextMenuStrip1;
            this.lblSO.Location = new System.Drawing.Point(72, 65);
            this.lblSO.Name = "lblSO";
            this.lblSO.ReadOnly = true;
            this.lblSO.Size = new System.Drawing.Size(221, 15);
            this.lblSO.TabIndex = 8;
            this.lblSO.TabStop = false;
            this.lblSO.Text = "[so]";
            // 
            // lblVersiune
            // 
            this.lblVersiune.BackColor = System.Drawing.SystemColors.Window;
            this.lblVersiune.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblVersiune.ContextMenuStrip = this.contextMenuStrip1;
            this.lblVersiune.Location = new System.Drawing.Point(72, 23);
            this.lblVersiune.Name = "lblVersiune";
            this.lblVersiune.ReadOnly = true;
            this.lblVersiune.Size = new System.Drawing.Size(221, 15);
            this.lblVersiune.TabIndex = 7;
            this.lblVersiune.TabStop = false;
            this.lblVersiune.Text = "[versiune]";
            // 
            // lblInstalat
            // 
            this.lblInstalat.BackColor = System.Drawing.SystemColors.Window;
            this.lblInstalat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInstalat.ContextMenuStrip = this.contextMenuStrip1;
            this.lblInstalat.Location = new System.Drawing.Point(72, 44);
            this.lblInstalat.Name = "lblInstalat";
            this.lblInstalat.ReadOnly = true;
            this.lblInstalat.Size = new System.Drawing.Size(221, 15);
            this.lblInstalat.TabIndex = 9;
            this.lblInstalat.TabStop = false;
            this.lblInstalat.Text = "[cale]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Instalat la:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Versiunea:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(236, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Închidere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Despre
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(323, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Despre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despre";
            this.Load += new System.EventHandler(this.Despre_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiereÎnClipboardToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lblSO;
        private System.Windows.Forms.TextBox lblVersiune;
        private System.Windows.Forms.TextBox lblInstalat;
    }
}