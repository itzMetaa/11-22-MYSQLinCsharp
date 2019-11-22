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
        }

        void RendezoListazas()
        {
            rendezokListBox.Items.Clear();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, nev, szuletes, szarmazas FROM rendezok ORDER BY nev";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var szuletes = reader.GetDateTime("szuletes");
                    var szarmazas = reader.GetString("szarmazas");
                    var rendezo = new Rendezo(id, nev, szarmazas, szuletes);

                    rendezokListBox.Items.Add(rendezo);
                }
                
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO rendezok (nev,szuletes,szarmazas) VALUES(@nev, @szuletes, @szarmazas)";
            cmd.Parameters.AddWithValue("@nev", textBoxNev.Text);
            cmd.Parameters.AddWithValue("@szuletes", dateTimePickerSzulDatum.Value);
            cmd.Parameters.AddWithValue("@szarmazas", textBoxSzarmazas.Text);
            cmd.ExecuteNonQuery();

            RendezoListazas();
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            var rendezo = (Rendezo)(rendezokListBox.SelectedItem);
            if (rendezokListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Helo nemjio nincs kivlaszltva:)XD:D");
                return;
            }
            int rendezo_id = rendezokListBox.SelectedIndex;
            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM rendezok WHERE id = @rendezo_id";
            cmd.Parameters.AddWithValue("@redezo_id", rendezo.Id);

            cmd.ExecuteNonQuery();
            RendezoListazas();
        }
    }
}
