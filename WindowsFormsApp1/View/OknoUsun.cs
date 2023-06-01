using APkaaa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class OknoUsun : Form
    {
        List<Danie> dostepnePrzepisy = WczytajBazyDanych.WczytajDaneZBazy();
        public OknoUsun()
        {
            InitializeComponent();
            PrzepisyListBox.Items.AddRange(dostepnePrzepisy.Select(przepis => przepis.Nazwa).ToArray());
        }

        private void UsunButton_Click(object sender, EventArgs e)
        {
            if (PrzepisyListBox.SelectedItem != null)
            {
                string nazwaPrzepisu = PrzepisyListBox.SelectedItem.ToString();
                Danie przepis = dostepnePrzepisy.FirstOrDefault(p => p.Nazwa == nazwaPrzepisu);
                if (przepis != null)
                {
                    dostepnePrzepisy.Remove(przepis);
                    PrzepisyListBox.Items.Remove(nazwaPrzepisu);
                    UsunZBazy.UsunDanieZBazyDanych(przepis.Nazwa);
                }
            }
        }
    }
}
