using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BibliotekaSQL_v0._1
{
    public class DBConnection
    {
        private string n_server;
        private string n_db;
        private string n_user;
        private string pass;
        private MySqlConnection conn;
        private string sql_select_wypozyczenie;
        private string sql_select_czytelnik;
        private string sql_select_ksiazka;
        private string sql_select_bibliotekarz;

        public DBConnection()
        {
            n_server = "db4free.net";
            n_db = "bibliotekadb";
            n_user = "pbochenek";
            pass = "qazxsw2";
            conn = new MySqlConnection(dbConnect());
            sql_select_wypozyczenie = "SELECT idWypozyczenie as `ID`, Ksiazka.Tytul as `Tytuł`, CONCAT(Czytelnik.CzytelnikImie,SPACE(1),Czytelnik.CzytelnikNazwisko) as `Czytelnik`, DataWypozyczenia as `Data Wypozyczenia`, DataZwrotu as `Data Zwrotu` FROM Wypozyczenie INNER JOIN Ksiazka ON idKsiazka=NR_Ksiazka INNER JOIN Czytelnik ON idCzytelnik=NR_Czytelnik";
            sql_select_czytelnik = "SELECT idCzytelnik as `ID`, CzytelnikImie as `Imię`, CzytelnikNazwisko as `Nazwisko`, Email as `e-mail`, NrTelefonu as `Nr Telefonu` FROM Czytelnik";
            sql_select_ksiazka = "SELECT * FROM Ksiazka";
            sql_select_bibliotekarz = "SELECT * FROM Bibliotekarz";
        }

        private string dbConnect()
        {
            string myConnection =
            "SERVER=" + n_server + ";" +
            "DATABASE=" + n_db + ";" +
            "UID=" + n_user + ";" +
            "PASSWORD=" + pass + ";";
            return myConnection;
        }

        public MySqlConnection getConnection()
        {
            return conn;
        }

        public string getWypozyczenie()
        {
            return sql_select_wypozyczenie;
        }

        public string getCzytelnik()
        {
            return sql_select_czytelnik;
        }
    }
}
