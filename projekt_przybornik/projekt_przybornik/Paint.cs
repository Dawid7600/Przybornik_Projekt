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
    public partial class Paint : Form
    {
        Graphics g;
        Form f1;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        public Paint()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        public Paint(Form f)
        {
            InitializeComponent();
            f1 = f;
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }
        // główne okno jest tylko wdioczne.
        private void Paint_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Visible = true;
        }

        private void Paint_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }
        /// <summary>
        /// Metoda wywołująca gdy w momencie przyciśnięcia przycisku na myszcze, zaczyna rysować 
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }
        /// <summary>
        /// Metoda wywołująca gdy w momencie puszczenia przycisku na myszcze, przestaje rysować
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        /// <summary>
        /// Metoda służąca do rysowania
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x !=-1 && y !=-1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        /// <summary>
        /// Metoda, która czyści okno
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        //wyczyść okno
        private void czysteOknoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
        }

        /// <summary>
        /// Metoda informująca kto wykonał aplikację
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paint by Dawid Horejda", "Info");
        }
    }
}
