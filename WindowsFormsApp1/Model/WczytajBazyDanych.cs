using APkaaa;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model
{
    internal class WczytajBazyDanych
    {
        public static List<Danie> WczytajDaneZBazy()
        {
            List<Danie> dostepnePrzepisy = new List<Danie>();

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NCH96Q8\SQLEXPRESS;Initial Catalog=Aplikacja;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Danie, Opis, Skladniki FROM Potrawa";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nazwa = (string)reader["Danie"];
                            string opis = (string)reader["Opis"];
                            string skladniki = (string)reader["Skladniki"];
                            List<string> listaSkladnikow = skladniki.Split(' ').ToList();

                            Danie danie = new Danie(nazwa, opis, listaSkladnikow);
                            dostepnePrzepisy.Add(danie);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas wczytywania przepisów: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return dostepnePrzepisy;
            }
        }
    }
}
