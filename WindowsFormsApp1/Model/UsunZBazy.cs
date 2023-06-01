using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    internal class UsunZBazy
    {
        public static void UsunDanieZBazyDanych(string NazwaDania)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NCH96Q8\SQLEXPRESS;Initial Catalog=Aplikacja;Integrated Security=True"))
            {
                conn.Open();
                string query = "DELETE FROM Potrawa WHERE Danie = @Nazwa";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Nazwa", NazwaDania);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
