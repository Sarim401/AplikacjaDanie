using APkaaa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp1.View
{
    public partial class OknoDodaj : Form
    {
        List<string> listaProdukt = new List<string>();
        StringBuilder sb = new StringBuilder();
        List<Danie> dostepnePrzepisy = WczytajBazyDanych.WczytajDaneZBazy();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NCH96Q8\SQLEXPRESS;Initial Catalog=Aplikacja;Integrated Security=True");

        public OknoDodaj()
        {
            InitializeComponent();
            DodajSkladnikButton.Click += DodajSkladnikButton_Click;
        }

        private void DanieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodajSkladnikButton_Click(object sender, EventArgs e)
        {
            string skladnik = SkladnikiTextBox.Text;

            if (!string.IsNullOrWhiteSpace(skladnik))
            {
                PodgladSkladnikowTextBox.Text += skladnik + Environment.NewLine;
                listaProdukt.Add(skladnik);

                SkladnikiTextBox.Text = "";
            }
        }

        private void UsunSkladnikButton_Click(object sender, EventArgs e)
        {
            if (listaProdukt.Count > 0)
            {
                listaProdukt.RemoveAt(listaProdukt.Count - 1);
                PodgladSkladnikowTextBox.Clear();

                foreach (string produkt in listaProdukt)
                {
                    PodgladSkladnikowTextBox.AppendText(produkt + Environment.NewLine);
                }
            }
        }

        private void DodajDanieButton_Click(object sender, EventArgs e)
        {
            string nazwaDania = DanieTextBox.Text;
            string opisDania = OpisTextBox.Text;
            List<string> skladniki = new List<string>(listaProdukt);

            if (string.IsNullOrWhiteSpace(nazwaDania) || string.IsNullOrWhiteSpace(opisDania) || skladniki.Count == 0)
            {
                MessageBox.Show("Uzupełnij wszystkie pola przed dodaniem przepisu.");
                return;
            }
            sb.Clear();
            foreach (string skladnik in listaProdukt)
            {
                sb.Append(skladnik);
                sb.Append(" ");
            }
            string Skladniki = sb.ToString();

            String querry = $"INSERT INTO Potrawa (Danie, Opis, Skladniki) VALUES ('{nazwaDania}', '{opisDania}', '{Skladniki}')";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            Danie noweDanie = new Danie(nazwaDania, opisDania, skladniki);
            dostepnePrzepisy.Add(noweDanie);
            PodgladSkladnikowTextBox.Clear();
            DanieTextBox.Text = "";
            OpisTextBox.Text = "";
            MessageBox.Show("Dodano pomyślnie");
            listaProdukt.Clear();
        }
    }
}
