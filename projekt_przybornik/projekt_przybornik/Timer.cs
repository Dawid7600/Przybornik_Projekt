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
    public partial class Timer : Form
    {
        private int quick = 1800;
        Form1 f1;
        private int alarmCounter;

        public Timer()
        {
            InitializeComponent();
        }
        //ustawienie, że okno z tyłu znika, głowne zostaje 
        public Timer(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void Timer_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Visible = true;
        }
        //wystartowanie timera

        /// <summary>
        /// Metoda startująca minutnik
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 
        private void start_btn_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1; // co jedną sekundę
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
        // ustawienia oraz zatrzymanie tiemra przy pozycji 00:00

        /// <summary>
        /// Metoda, która ustawia i zatrzymuje timer w pozycji 00:00
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void timer1_Tick(object sender, EventArgs e)
        {
            quick--;
            czas_lbl.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            if (quick == 0)
            {
                timer1.Stop();
                
            }
        }
        //zatrzymanie timera

        /// <summary>
        /// Metoda zatrzymująca minutnik
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 
        private void stop_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        /// <summary>
        /// Metoda informująca kto wykonał aplikację
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timer by Dawid Horejda", "Info");
        }
    }
    
}
