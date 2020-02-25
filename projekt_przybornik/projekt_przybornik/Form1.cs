using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_przybornik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //wyjście exit menu
        /// <summary>
        /// Metoda wywołująca okienko z zapytaniem o opuszczenie aplikacji
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Czy na pewno chcesz opuścić aplikacje?";
            const string caption = "Exit";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
        // info menu

        /// <summary>
        /// Metoda wywoływująca informacja na temat, kto wykonał projekt
        /// </summary>
        /// <param name="sender"> Obiekt wywołujący zdarzenie</param>
        /// <param name="e">Zawiera dane zdarzenia</param> 
        private void infoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Projekt został wykonany przez Dawid Horejda. Kontakt w58992.", "Info");
        }
        //wejście do nowego okna Timer

        /// <summary>
        /// Metoda wywołująca nowy obiekt, minutnik
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 
        /// 
        private void timer_btn_Click(object sender, EventArgs e)
        {
            
            Timer t = new Timer(this);
            this.Visible = false;
            t.ShowDialog();// tylko okno główne działa
        }

        /// <summary>
        /// Metoda wywołująca nowy obiekt, paint
        /// </summary>
        /// <param name="sender"> Obiekt wywołujący zdarzenie</param>
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void paint_btn_Click(object sender, EventArgs e)
        {
            Paint p = new Paint(this);
            this.Visible = false;
            p.ShowDialog();// tylko okno główne działa (modalne)
        }

        /// <summary>
        /// Metoda wywołująca nowy obiekt, listę kontaktów
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void friends_Click(object sender, EventArgs e)
        {
            Friends c = new Friends(this);
            this.Visible = false;
            c.ShowDialog();
        }

        /// <summary>
        /// Metoda wywołująca nowy obiekt, kalkulator
        /// </summary>
        /// <param name="sender"> Obiekt wywołujący zdarzenie</param>
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void kalkulator_btn_Click(object sender, EventArgs e)
        {
            Kalkulator d = new Kalkulator(this);
            this.Visible = false;
            d.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
