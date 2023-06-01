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

namespace WindowsFormsApp1.View
{
    public partial class OknoPrzegladaj : Form
    {
        List<Danie> dostepnePrzepisy = WczytajBazyDanych.WczytajDaneZBazy();
        public OknoPrzegladaj()
        {
            InitializeComponent();
            ProduktyListBox.Items.AddRange(dostepnePrzepisy.Select(przepis => przepis.Nazwa).ToArray());
        }

        private void ProduktyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NCH96Q8\SQLEXPRESS;Initial Catalog=Aplikacja;Integrated Security=True");
            if (string.IsNullOrEmpty(conn.ConnectionString))
            {
                conn.ConnectionString = @"Data Source=DESKTOP-NCH96Q8\SQLEXPRESS;Initial Catalog=Aplikacja;Integrated Security=True";
            }
            int selectedIndex = ProduktyListBox.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Danie wybranyPrzepis = dostepnePrzepisy[selectedIndex];
                OpisPrzepisow.Text = "Nazwa: " + wybranyPrzepis.Nazwa + Environment.NewLine +
                                      "Opis: " + wybranyPrzepis.Opis + Environment.NewLine +
                                      "Składniki: " + string.Join(", ", wybranyPrzepis.Skladniki);
            }
        }

    }
}
