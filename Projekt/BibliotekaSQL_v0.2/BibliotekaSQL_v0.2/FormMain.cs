using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaSQL_v0._2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.labelData.Text = DateTime.Now.ToString();
   
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNewWypozyczenie newWyp = new FormNewWypozyczenie();
            newWyp.Show();
        }

        private void rejestracjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRejCzyt rejCzyt = new FormRejCzyt();
            rejCzyt.Show();
        }

        private void wyszukajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSzukWypozyczenie szukWyp = new FormSzukWypozyczenie();
            szukWyp.Show();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDodKs dodKs = new FormDodKs();
            dodKs.Show();
        }

        private void wyszukajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSzukKs szukKs = new FormSzukKs();
            szukKs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEdyWypozyczenie edyWyp = new FormEdyWypozyczenie();
            edyWyp.Show();
        }

        private void buttonSzczegoly_Click(object sender, EventArgs e)
        {
            FormEdyWypozyczenie edyWyp = new FormEdyWypozyczenie();
            edyWyp.Show();
        }
    }
}
