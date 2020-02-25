namespace projekt_przybornik
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.paint_btn = new System.Windows.Forms.Button();
            this.friends_btn = new System.Windows.Forms.Button();
            this.kalkulator_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem1});
            this.infoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.infoToolStripMenuItem.Text = "Help";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem1.Text = "Info";
            this.infoToolStripMenuItem1.Click += new System.EventHandler(this.infoToolStripMenuItem1_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer_btn
            // 
            this.timer_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer_btn.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timer_btn.ForeColor = System.Drawing.Color.White;
            this.timer_btn.Location = new System.Drawing.Point(263, 181);
            this.timer_btn.Name = "timer_btn";
            this.timer_btn.Size = new System.Drawing.Size(169, 50);
            this.timer_btn.TabIndex = 1;
            this.timer_btn.Text = "Timer";
            this.timer_btn.UseVisualStyleBackColor = false;
            this.timer_btn.Click += new System.EventHandler(this.timer_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 318);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // paint_btn
            // 
            this.paint_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paint_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paint_btn.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paint_btn.ForeColor = System.Drawing.Color.White;
            this.paint_btn.Location = new System.Drawing.Point(40, 69);
            this.paint_btn.Name = "paint_btn";
            this.paint_btn.Size = new System.Drawing.Size(169, 50);
            this.paint_btn.TabIndex = 4;
            this.paint_btn.Text = "Paint";
            this.paint_btn.UseVisualStyleBackColor = false;
            this.paint_btn.Click += new System.EventHandler(this.paint_btn_Click);
            // 
            // friends_btn
            // 
            this.friends_btn.BackColor = System.Drawing.Color.Black;
            this.friends_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friends_btn.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.friends_btn.ForeColor = System.Drawing.Color.White;
            this.friends_btn.Location = new System.Drawing.Point(40, 181);
            this.friends_btn.Name = "friends_btn";
            this.friends_btn.Size = new System.Drawing.Size(169, 50);
            this.friends_btn.TabIndex = 5;
            this.friends_btn.Text = "Friends";
            this.friends_btn.UseVisualStyleBackColor = false;
            this.friends_btn.Click += new System.EventHandler(this.friends_Click);
            // 
            // kalkulator_btn
            // 
            this.kalkulator_btn.BackColor = System.Drawing.Color.Black;
            this.kalkulator_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kalkulator_btn.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kalkulator_btn.ForeColor = System.Drawing.Color.White;
            this.kalkulator_btn.Location = new System.Drawing.Point(263, 69);
            this.kalkulator_btn.Name = "kalkulator_btn";
            this.kalkulator_btn.Size = new System.Drawing.Size(169, 50);
            this.kalkulator_btn.TabIndex = 6;
            this.kalkulator_btn.Text = "Kalkulator";
            this.kalkulator_btn.UseVisualStyleBackColor = false;
            this.kalkulator_btn.Click += new System.EventHandler(this.kalkulator_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(475, 350);
            this.ControlBox = false;
            this.Controls.Add(this.kalkulator_btn);
            this.Controls.Add(this.friends_btn);
            this.Controls.Add(this.paint_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.timer_btn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Przybornik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button timer_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button paint_btn;
        private System.Windows.Forms.Button friends_btn;
        private System.Windows.Forms.Button kalkulator_btn;
    }
}

