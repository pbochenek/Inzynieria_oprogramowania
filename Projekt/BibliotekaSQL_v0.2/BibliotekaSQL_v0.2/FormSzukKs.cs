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
    public partial class FormSzukKs : Form
    {
        public FormSzukKs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEdyKs edyKs = new FormEdyKs();
            edyKs.Show();
        }
    }
}
