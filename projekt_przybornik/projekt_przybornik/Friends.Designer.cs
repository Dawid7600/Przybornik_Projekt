namespace projekt_przybornik
{
    partial class Friends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Friends));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Imie_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imie_lbl = new System.Windows.Forms.Label();
            this.nazwisko_lbl = new System.Windows.Forms.Label();
            this.textImie = new System.Windows.Forms.TextBox();
            this.textNazwisko = new System.Windows.Forms.TextBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.tel_lbl = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Imie_column,
            this.Nazwisko_column,
            this.Telefon_column});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 129);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(347, 246);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Imie_column
            // 
            this.Imie_column.Text = "Imie";
            // 
            // Nazwisko_column
            // 
            this.Nazwisko_column.Text = "Nazwisko";
            this.Nazwisko_column.Width = 66;
            // 
            // Telefon_column
            // 
            this.Telefon_column.Text = "Telefon";
            this.Telefon_column.Width = 225;
            // 
            // imie_lbl
            // 
            this.imie_lbl.AutoSize = true;
            this.imie_lbl.Location = new System.Drawing.Point(29, 32);
            this.imie_lbl.Name = "imie_lbl";
            this.imie_lbl.Size = new System.Drawing.Size(29, 13);
            this.imie_lbl.TabIndex = 1;
            this.imie_lbl.Text = "Imie:";
            // 
            // nazwisko_lbl
            // 
            this.nazwisko_lbl.AutoSize = true;
            this.nazwisko_lbl.Location = new System.Drawing.Point(29, 60);
            this.nazwisko_lbl.Name = "nazwisko_lbl";
            this.nazwisko_lbl.Size = new System.Drawing.Size(56, 13);
            this.nazwisko_lbl.TabIndex = 2;
            this.nazwisko_lbl.Text = "Nazwisko:";
            // 
            // textImie
            // 
            this.textImie.Location = new System.Drawing.Point(91, 29);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(146, 20);
            this.textImie.TabIndex = 3;
            // 
            // textNazwisko
            // 
            this.textNazwisko.Location = new System.Drawing.Point(91, 60);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(146, 20);
            this.textNazwisko.TabIndex = 4;
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(91, 89);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(146, 20);
            this.textTelefon.TabIndex = 5;
            // 
            // tel_lbl
            // 
            this.tel_lbl.AutoSize = true;
            this.tel_lbl.Location = new System.Drawing.Point(29, 89);
            this.tel_lbl.Name = "tel_lbl";
            this.tel_lbl.Size = new System.Drawing.Size(46, 13);
            this.tel_lbl.TabIndex = 6;
            this.tel_lbl.Text = "Telefon:";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(273, 27);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 38);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(273, 71);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 38);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 387);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.tel_lbl);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.textNazwisko);
            this.Controls.Add(this.textImie);
            this.Controls.Add(this.nazwisko_lbl);
            this.Controls.Add(this.imie_lbl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Friends";
            this.Text = "Friends";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Friends_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Imie_column;
        private System.Windows.Forms.ColumnHeader Nazwisko_column;
        private System.Windows.Forms.ColumnHeader Telefon_column;
        private System.Windows.Forms.Label imie_lbl;
        private System.Windows.Forms.Label nazwisko_lbl;
        private System.Windows.Forms.TextBox textImie;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.Label tel_lbl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}