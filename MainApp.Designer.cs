using System.Windows.Forms;

namespace PIUGlab2_4
{
    partial class MainApp
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
            this.lvMaterii = new System.Windows.Forms.ListView();
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdaugare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStergere = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fișierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ieșireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adăugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ărileEfectuateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.căutareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obținețiAjutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMaterii
            // 
            this.lvMaterii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNume,
            this.columnHeaderNumar});
            this.lvMaterii.ContextMenuStrip = this.contextMenuStrip1;
            this.lvMaterii.HideSelection = false;
            this.lvMaterii.Location = new System.Drawing.Point(12, 27);
            this.lvMaterii.Name = "lvMaterii";
            this.lvMaterii.Size = new System.Drawing.Size(620, 253);
            this.lvMaterii.TabIndex = 0;
            this.lvMaterii.UseCompatibleStateImageBehavior = false;
            this.lvMaterii.View = System.Windows.Forms.View.Details;
            this.lvMaterii.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMaterii_MouseDoubleClick);
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume materie";
            this.columnHeaderNume.Width = 481;
            // 
            // columnHeaderNumar
            // 
            this.columnHeaderNumar.Text = "Număr studenți înscriși";
            this.columnHeaderNumar.Width = 132;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdaugare,
            this.toolStripMenuItemStergere});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 48);
            // 
            // toolStripMenuItemAdaugare
            // 
            this.toolStripMenuItemAdaugare.Name = "toolStripMenuItemAdaugare";
            this.toolStripMenuItemAdaugare.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItemAdaugare.Text = "Adăugare";
            this.toolStripMenuItemAdaugare.Click += new System.EventHandler(this.toolStripMenuItemAdaugare_Click);
            // 
            // toolStripMenuItemStergere
            // 
            this.toolStripMenuItemStergere.Name = "toolStripMenuItemStergere";
            this.toolStripMenuItemStergere.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItemStergere.Text = "Ștergere";
            this.toolStripMenuItemStergere.Click += new System.EventHandler(this.toolStripMenuItemStergere_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(557, 286);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Selectare";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fișierToolStripMenuItem,
            this.editareToolStripMenuItem,
            this.ajutorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fișierToolStripMenuItem
            // 
            this.fișierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.importareToolStripMenuItem,
            this.exportareToolStripMenuItem,
            this.toolStripSeparator1,
            this.ieșireToolStripMenuItem});
            this.fișierToolStripMenuItem.Name = "fișierToolStripMenuItem";
            this.fișierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fișierToolStripMenuItem.Text = "&Fișier";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.salvareToolStripMenuItem.Text = "&Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // importareToolStripMenuItem
            // 
            this.importareToolStripMenuItem.Name = "importareToolStripMenuItem";
            this.importareToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.importareToolStripMenuItem.Text = "I&mportare...";
            this.importareToolStripMenuItem.Click += new System.EventHandler(this.importareToolStripMenuItem_Click);
            // 
            // exportareToolStripMenuItem
            // 
            this.exportareToolStripMenuItem.Name = "exportareToolStripMenuItem";
            this.exportareToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exportareToolStripMenuItem.Text = "E&xportare...";
            this.exportareToolStripMenuItem.Click += new System.EventHandler(this.exportareToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // ieșireToolStripMenuItem
            // 
            this.ieșireToolStripMenuItem.Name = "ieșireToolStripMenuItem";
            this.ieșireToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ieșireToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ieșireToolStripMenuItem.Text = "&Ieșire";
            this.ieșireToolStripMenuItem.Click += new System.EventHandler(this.ieșireToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adăugareToolStripMenuItem,
            this.ștergereToolStripMenuItem,
            this.ărileEfectuateToolStripMenuItem,
            this.toolStripSeparator2,
            this.căutareToolStripMenuItem});
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editareToolStripMenuItem.Text = "&Editare";
            // 
            // adăugareToolStripMenuItem
            // 
            this.adăugareToolStripMenuItem.Name = "adăugareToolStripMenuItem";
            this.adăugareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.adăugareToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.adăugareToolStripMenuItem.Text = "&Adăugare";
            this.adăugareToolStripMenuItem.Click += new System.EventHandler(this.adăugareToolStripMenuItem_Click);
            // 
            // ștergereToolStripMenuItem
            // 
            this.ștergereToolStripMenuItem.Name = "ștergereToolStripMenuItem";
            this.ștergereToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.ștergereToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.ștergereToolStripMenuItem.Text = "&Ștergere";
            this.ștergereToolStripMenuItem.Click += new System.EventHandler(this.ștergereToolStripMenuItem_Click);
            // 
            // ărileEfectuateToolStripMenuItem
            // 
            this.ărileEfectuateToolStripMenuItem.Name = "ărileEfectuateToolStripMenuItem";
            this.ărileEfectuateToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.ărileEfectuateToolStripMenuItem.Text = "Anulați modificările efectuate";
            this.ărileEfectuateToolStripMenuItem.Click += new System.EventHandler(this.ărileEfectuateToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // căutareToolStripMenuItem
            // 
            this.căutareToolStripMenuItem.Name = "căutareToolStripMenuItem";
            this.căutareToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.căutareToolStripMenuItem.Text = "&Căutare";
            this.căutareToolStripMenuItem.Click += new System.EventHandler(this.căutareToolStripMenuItem_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obținețiAjutorToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajutorToolStripMenuItem.Text = "&Ajutor";
            // 
            // obținețiAjutorToolStripMenuItem
            // 
            this.obținețiAjutorToolStripMenuItem.Name = "obținețiAjutorToolStripMenuItem";
            this.obținețiAjutorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.obținețiAjutorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.obținețiAjutorToolStripMenuItem.Text = "&Obțineți ajutor";
            this.obținețiAjutorToolStripMenuItem.Click += new System.EventHandler(this.obținețiAjutorToolStripMenuItem_Click);
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.despreToolStripMenuItem.Text = "&Despre...";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(644, 321);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lvMaterii);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.Text = "Gestionare materii";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMaterii;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderNumar;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fișierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ieșireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adăugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ștergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obținețiAjutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private ToolStripMenuItem importareToolStripMenuItem;
        private ToolStripMenuItem exportareToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItemAdaugare;
        private ToolStripMenuItem toolStripMenuItemStergere;
        private ToolStripMenuItem ărileEfectuateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem căutareToolStripMenuItem;
    }
}