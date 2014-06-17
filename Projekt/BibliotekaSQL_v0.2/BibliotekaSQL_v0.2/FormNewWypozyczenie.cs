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
    public partial class FormNewWypozyczenie : Form
    {
        public FormNewWypozyczenie()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Pomyślnie dodano wypożyczenie!", "Dodanie wypożyczenia");
        }
    }
}
