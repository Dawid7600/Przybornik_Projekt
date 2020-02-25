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
    public partial class Friends : Form
    {       //przeciazenie wyskakuje tylko jedno okno modalne
        Form1 c1;
        public Friends()
        {
            InitializeComponent();
        }

        public Friends(Form1 c)
        {
            InitializeComponent();
            c1 = c;
        }

        /// <summary>
        /// Metoda wywołująca zamknięcie listy kontaktów
        /// </summary>
        /// <param name="sender"></param> Obiekt wywołujący zdarzenie
        /// <param name="e"></param> Zawiera dane zdarzenia

        private void Friends_FormClosing(object sender, FormClosingEventArgs e)
        {
            c1.Visible = true;

        }
        //

        //dodawanie na liscie itd .

        /// <summary>
        /// Metoda dodające nowe dane do listy kontaktów
        /// </summary>
        /// <param name="sender"></param> Obiekt wywołujący zdarzenie
        /// <param name="e"></param> Zawiera dane zdarzenia
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textImie.Text) || string.IsNullOrEmpty(textNazwisko.Text))
                return;
            ListViewItem item = new ListViewItem(textImie.Text);
            item.SubItems.Add(textNazwisko.Text);
            item.SubItems.Add(textTelefon.Text);
            listView1.Items.Add(item);
            textImie.Clear();
            textNazwisko.Clear();
            textTelefon.Clear();
            textImie.Focus();
        }

        /// <summary>
        /// Metoda usuwania danych z listy
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);

        }

        /// <summary>
        /// Metoda wywołująca informacje na temat kto wykonał aplikacje
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie</param> 
        /// <param name="e">Zawiera dane zdarzenia</param> 

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Friends by Dawid Horejda", "Info");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
