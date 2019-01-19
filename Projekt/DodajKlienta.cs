using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class DodajKlienta : Form
    {
        private GlownyInterfejs g;

        public DodajKlienta(GlownyInterfejs gi)
        {
            InitializeComponent();
            g = gi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.ListKlientow.Add(
                new Klient(tImie.Text, tNazwisko.Text, tPesel.Text,tnrDowodu.Text,
                           dTdata.Value, tMiasto.Text, tUlica.Text, tLokal.Text, tKod.Text)
            );
            g.ZapiszListeKlientow();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajKlienta_Load(object sender, EventArgs e)
        {

        }
    }
}
