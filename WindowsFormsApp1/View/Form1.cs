using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.View;
using WindowsFormsApp1.ViewModel;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnDodajClick(object sender, EventArgs e)
        {
 
            OknoDodaj NoweOknoDodaj = new OknoDodaj();
            NoweOknoDodaj.Show();

        }

        private void OnPrzegladajClick(object sender, EventArgs e)
        {
            OknoPrzegladaj NoweOknoPrzegladaj = new OknoPrzegladaj();
            NoweOknoPrzegladaj.Show();
        }


        private void OnUsunClick(object sender, EventArgs e)
        {
            OknoUsun NoweOknoUsun = new OknoUsun();
            NoweOknoUsun.Show();
        }

    }
}
