namespace PIUGlab2_4
{
    partial class DetaliiMaterie
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
            this.tbNrInscrisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStergStud = new System.Windows.Forms.Button();
            this.lbStudenti = new System.Windows.Forms.ListBox();
            this.btnAdaugStud = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStergMat = new System.Windows.Forms.Button();
            this.btnAdaugMat = new System.Windows.Forms.Button();
            this.tbMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvNote = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNrInscrisi
            // 
            this.tbNrInscrisi.Location = new System.Drawing.Point(6, 34);
            this.tbNrInscrisi.Name = "tbNrInscrisi";
            this.tbNrInscrisi.ReadOnly = true;
            this.tbNrInscrisi.Size = new System.Drawing.Size(144, 22);
            this.tbNrInscrisi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Număr studenți înscriși:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNrInscrisi);
            this.groupBox1.Controls.Add(this.btnStergStud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbStudenti);
            this.groupBox1.Controls.Add(this.btnAdaugStud);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Studenți înscriși";
            // 
            // btnStergStud
            // 
            this.btnStergStud.Location = new System.Drawing.Point(79, 284);
            this.btnStergStud.Name = "btnStergStud";
            this.btnStergStud.Size = new System.Drawing.Size(71, 23);
            this.btnStergStud.TabIndex = 3;
            this.btnStergStud.Text = "Ștergere";
            this.btnStergStud.UseVisualStyleBackColor = true;
            this.btnStergStud.Click += new System.EventHandler(this.btnStergStud_Click);
            // 
            // lbStudenti
            // 
            this.lbStudenti.FormattingEnabled = true;
            this.lbStudenti.Location = new System.Drawing.Point(6, 66);
            this.lbStudenti.Name = "lbStudenti";
            this.lbStudenti.ScrollAlwaysVisible = true;
            this.lbStudenti.Size = new System.Drawing.Size(144, 212);
            this.lbStudenti.TabIndex = 2;
            this.lbStudenti.SelectedIndexChanged += new System.EventHandler(this.lbStudenti_SelectedIndexChanged);
            // 
            // btnAdaugStud
            // 
            this.btnAdaugStud.Location = new System.Drawing.Point(6, 284);
            this.btnAdaugStud.Name = "btnAdaugStud";
            this.btnAdaugStud.Size = new System.Drawing.Size(71, 23);
            this.btnAdaugStud.TabIndex = 2;
            this.btnAdaugStud.Text = "Adăugare";
            this.btnAdaugStud.UseVisualStyleBackColor = true;
            this.btnAdaugStud.Click += new System.EventHandler(this.btnAdaugStud_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStergMat);
            this.groupBox2.Controls.Add(this.btnAdaugMat);
            this.groupBox2.Controls.Add(this.tbMedia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lvNote);
            this.groupBox2.Location = new System.Drawing.Point(174, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 313);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note";
            // 
            // btnStergMat
            // 
            this.btnStergMat.Location = new System.Drawing.Point(95, 284);
            this.btnStergMat.Name = "btnStergMat";
            this.btnStergMat.Size = new System.Drawing.Size(86, 23);
            this.btnStergMat.TabIndex = 4;
            this.btnStergMat.Text = "Ștergere";
            this.btnStergMat.UseVisualStyleBackColor = true;
            this.btnStergMat.Click += new System.EventHandler(this.btnStergMat_Click);
            // 
            // btnAdaugMat
            // 
            this.btnAdaugMat.Location = new System.Drawing.Point(6, 284);
            this.btnAdaugMat.Name = "btnAdaugMat";
            this.btnAdaugMat.Size = new System.Drawing.Size(86, 23);
            this.btnAdaugMat.TabIndex = 4;
            this.btnAdaugMat.Text = "Adăugare";
            this.btnAdaugMat.UseVisualStyleBackColor = true;
            this.btnAdaugMat.Click += new System.EventHandler(this.btnAdaugMat_Click);
            // 
            // tbMedia
            // 
            this.tbMedia.Location = new System.Drawing.Point(6, 75);
            this.tbMedia.Name = "tbMedia";
            this.tbMedia.ReadOnly = true;
            this.tbMedia.Size = new System.Drawing.Size(175, 22);
            this.tbMedia.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Media:";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selectați un student din partea stângă pentru a vizualiza notele";
            // 
            // lvNote
            // 
            this.lvNote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvNote.HideSelection = false;
            this.lvNote.Location = new System.Drawing.Point(6, 110);
            this.lvNote.Name = "lvNote";
            this.lvNote.Size = new System.Drawing.Size(175, 168);
            this.lvNote.TabIndex = 0;
            this.lvNote.UseCompatibleStateImageBehavior = false;
            this.lvNote.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nota";
            // 
            // DetaliiMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(373, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DetaliiMaterie";
            this.Text = "Detalii ";
            this.Load += new System.EventHandler(this.DetaliiMaterie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNrInscrisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStergStud;
        private System.Windows.Forms.ListBox lbStudenti;
        private System.Windows.Forms.Button btnAdaugStud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvNote;
        private System.Windows.Forms.Button btnStergMat;
        private System.Windows.Forms.Button btnAdaugMat;
        private System.Windows.Forms.TextBox tbMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}