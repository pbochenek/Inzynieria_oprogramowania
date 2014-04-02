using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BibliotekaSQL_v0._1
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void pokaz_wypozyczenia_Click(object sender, EventArgs e)
        {
            fillTableData("wyp");
        }

        private void pokaz_czytelnikow_Click(object sender, EventArgs e)
        {
            fillTableData("czyt");
        }

        private void fillTableData(string cowyswietlic)
        {
            string query;

            DBConnection new_con = new DBConnection();

            if (cowyswietlic == "wyp") query = new_con.getWypozyczenie();
            else if (cowyswietlic == "czyt") query = new_con.getCzytelnik();
            else query = null;

            new_con.getConnection().Open();

            //wykonaj polecenie języka SQL na danych połączeniu
            MySqlCommand cmdSel = new MySqlCommand(query, new_con.getConnection());
            DataTable tablica = new DataTable();             
            //Pobierz dane i zapisz w strukturze DataTable
            MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
            da.Fill(tablica);
            //wpisz dane do kontrolki DATAGRID
            dataGridView1.DataSource = tablica.DefaultView;

            new_con.getConnection().Close();
                
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Kliknales " + e.RowIndex + " wiersz.");
        }

    }
}
