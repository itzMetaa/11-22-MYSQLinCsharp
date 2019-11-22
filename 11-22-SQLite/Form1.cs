using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_22_SQLite
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Port=3307;Database=filmdb;Uid=root;Pwd=;");
            conn.Open();
            RendezoListazas();
            conn.Close();



        }

        void RendezoListazas()
        {
            rendezokListBox.Items.Clear();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT nev FROM rendezok ORDER BY nev";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nev = reader.GetString("nev");
                    rendezokListBox.Items.Add(nev);
                }
                
            }
        }
    }
}
