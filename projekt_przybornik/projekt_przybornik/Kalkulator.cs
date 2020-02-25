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
    public partial class Kalkulator : Form
    {
        Form1 d1;
        public Kalkulator()
        {
            InitializeComponent();
        }

        public Kalkulator(Form1 d)
        {
            InitializeComponent();
            d1 = d;

        }

        float n, a;
        Operations operation;

        /// <summary>
        /// Metoda wywołująca zamknięcie kalkulatora
        /// </summary>
        /// <param name="sender"></param> Obiekt wywołujący zdarzenie
        /// <param name="e"></param> Zawiera dane zdarzenia

        private void Kalkulator_FormClosing(object sender, FormClosingEventArgs e)
        {
            d1.Visible = true;
        }

        /// <summary>
        /// Metoda wywołująca informacje na temat kto wykonał aplikację
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kalkulator by Dawid Horejda", "Info");
        }
        /// <summary>
        /// Metody zawierające każdy przycisk na kalkulatorze z osobna
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 0;
        }

        private void przecinek_btn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ",";
        }

        /// <summary>
        /// Metoda zawierająca każdy przypadek, która może zostać wykonany na kalkulatorze
        /// </summary>
        public void compute()
        {
            switch (operation)
            {
                case Operations.Add:
                    a = n + float.Parse(textBox.Text);
                    textBox.Text = a.ToString();
                    break;
                case Operations.Substract:
                    a = n - float.Parse(textBox.Text);
                    textBox.Text = a.ToString();
                    break;
                case Operations.Multiply:
                    a = n * float.Parse(textBox.Text);
                    textBox.Text = a.ToString();
                    break;
                case Operations.Divide:
                    a = n / float.Parse(textBox.Text);
                    textBox.Text = a.ToString();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Metoda wywołująca dodawanie
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void plus_btn_Click(object sender, EventArgs e)
        {
            n = float.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            operation = changeOperation("Dodawanie");
            label1.Text = n.ToString() + "+";
        }

        /// <summary>
        /// Metoda wywołująca odejmowanie
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void minus_btn_Click(object sender, EventArgs e)
        {
            n = float.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            operation = changeOperation("Odejmowanie");
            label1.Text = n.ToString() + "-";
        }
        

        public static Operations changeOperation(String operationName)
        {
            switch (operationName)
            {
                case ("Dodawanie"):
                    return Operations.Add;
                case ("Odejmowanie"):
                    return Operations.Substract;
                case ("Mnozenie"):
                    return Operations.Multiply;
                case ("Dzielenie"):
                    return Operations.Divide;
                default:
                    return Operations.Unknown;
            }
        }

        /// <summary>
        /// Metoda wywołująca mnożenie
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void mnozenie_btn_Click(object sender, EventArgs e)
        {
            n = float.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            operation = changeOperation("Mnozenie");
            label1.Text = n.ToString() + "*";
        }
        /// <summary>
        /// Metoda wywołująca wynik danego równania
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void wynik_btn_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void NEW_btn_Click(object sender, EventArgs e)
        {
            int lenght = textBox.TextLength - 1;
            string text = textBox.Text;
            textBox.Clear();
            for (int i = 0; i < lenght; i++)
                textBox.Text = textBox.Text + text[i];
        }

        private void C_btn_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        /// <summary>
        /// Metoda wywołująca dzielenie
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void dzielenie_btn_Click(object sender, EventArgs e)
        {
            n = float.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            operation = changeOperation("dzielenie");
            label1.Text = n.ToString() + "/";
        }

        public enum Operations
        {
            Add = 1,
            Substract = 2,
            Multiply = 3,
            Divide = 4,
            Unknown = 5
        }

    }

}
