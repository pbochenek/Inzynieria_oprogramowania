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
    public partial class FormLogowanie : Form
    {
        public FormLogowanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if(this.textBox1.Text=="admin"&&this.textBox2.Text=="password")
            {
               
                FormMain main = new FormMain();
   
                main.Show();
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Niepoprawny login lub hasło.", "Błąd logowania");
            }
        }

    }
}
