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

        void FilmListazas()
        {
            listBoxFilmek.Items.Clear();
            var rendezo = (Rendezo)(rendezokListBox.SelectedItem);

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT id, cim, kiadas, hossz, rendezo_id 
                                FROM filmek
                                WHERE rendezo_id like @rendezo_id
                                ORDER BY cim";
            cmd.Parameters.AddWithValue("@rendezo_id", rendezo.Id);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var cim = reader.GetString("cim");
                    var hossz = reader.GetInt32("hossz");
                    var kiadas = reader.GetDateTime("kiadas");
                    var rendezo_id = reader.GetInt32("rendezo_id");
                    var film = new Film(id, cim, hossz, kiadas, rendezo_id);

                    listBoxFilmek.Items.Add(film);
                }
            }
        }

        void FilmListazasAll()
        {
            listBoxFilmek.Items.Clear();
            var rendezo = (Rendezo)(rendezokListBox.SelectedItem);

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT id, cim, kiadas, hossz, rendezo_id 
                                FROM filmek
                                ORDER BY cim";

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var cim = reader.GetString("cim");
                    var hossz = reader.GetInt32("hossz");
                    var kiadas = reader.GetDateTime("kiadas");
                    var rendezo_id = reader.GetInt32("rendezo_id");
                    var film = new Film(id, cim, hossz, kiadas, rendezo_id);

                    listBoxFilmek.Items.Add(film);
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

            textBoxNev.Text = "";
            textBoxSzarmazas.Text = "";
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
            cmd.Parameters.AddWithValue("@rendezo_id", rendezo.Id);
            cmd.ExecuteNonQuery();
            RendezoListazas();
        }

        private void rendezokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxFilmek.Visible = true;
            FilmListazas();
        }

        private void buttonFilmTorles_Click(object sender, EventArgs e)
        {
            var film = (Film)(listBoxFilmek.SelectedItem);
            if (listBoxFilmek.SelectedIndex == -1)
            {
                MessageBox.Show("Helo nemjio nincs kivlaszltva:)XD:D");
                return;
            }
            int film_id = listBoxFilmek.SelectedIndex;
            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM filmek WHERE id = @film_id";
            cmd.Parameters.AddWithValue("@film_id", film.Id);
            cmd.ExecuteNonQuery();
            FilmListazas();
        }

        private void buttonFilmFelvetel_Click(object sender, EventArgs e)
        {
            var rendezo = (Rendezo)(rendezokListBox.SelectedItem);
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO filmek (cim,kiadas,hossz,rendezo_id) VALUES(@cim, @kiadas, @hossz, @rendezo_id)";
            cmd.Parameters.AddWithValue("@cim", textBoxFilmCim.Text);
            cmd.Parameters.AddWithValue("@kiadas", dateTimePickerSzulDatum.Value);
            cmd.Parameters.AddWithValue("@hossz", numericUpDownFilmHossz.Value);
            cmd.Parameters.AddWithValue("@rendezo_id", rendezo.Id);
            cmd.ExecuteNonQuery();

            textBoxFilmCim.Text = "";
            numericUpDownFilmHossz.Value = 60;

            FilmListazas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxFilmek.Visible = true;
            FilmListazasAll();
        }
    }
}
