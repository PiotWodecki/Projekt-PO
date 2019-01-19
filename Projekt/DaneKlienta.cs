using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Projekt
{
    

    public partial class DaneKlienta : Form
    {
        private DodajWynajem wyn;
        private GlownyInterfejs g;
        private Samochod s;
        private DateTime dataWypo;
        private DateTime dataOd;
        private double cena;

        public DaneKlienta(DodajWynajem w, GlownyInterfejs gi, Samochod sam, DateTime dw, DateTime dO, double c)
        {
            InitializeComponent();
            wyn = w;
            g = gi;
            lKlienci.DataSource = g.ListKlientow;
            this.s = sam;
            this.dataWypo = dw;
            this.dataOd = dO;
            this.cena = c;

            

        }

        private void DaneKlienta_Load(object sender, EventArgs e)
        {

        }

        private void Wynajmij(Wynajem w)
        {
            w.samochod.Zarezerwuj(new PrzedzialCzasu(w.DataWypozyczenia, w.DataZwrotu));
            g.Listawynajmow.Add(w);
            g.ZapiszListeWynajmow();
            g.ZapiszListeSamochodow();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//dodaj wynajem
        {
            if (lKlienci.SelectedIndex >= 0 && lKlienci.SelectedIndex < g.ListKlientow.Count)
            {
                Wynajem w = new Wynajem(g.ListKlientow[lKlienci.SelectedIndex], this.s, this.dataWypo, this.dataOd,
                    this.cena);
                Wynajmij(w);
            }
            // error 
                MessageBox.Show("Wybierz klienta!", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SystemSounds.Exclamation.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e) 
        {
            
        }

        private void button3_Click(object sender, EventArgs e) // dodaj 
        {
            Klient k = new Klient(tImie.Text, tNazwisko.Text, tPesel.Text, tnrDowodu.Text,
                dTdata.Value, tMiasto.Text, tUlica.Text, tLokal.Text, tKod.Text);
            g.ListKlientow.Add(k);
            g.ZapiszListeKlientow();

            lKlienci.DataSource = null;
            lKlienci.DataSource = g.ListKlientow;

            Wynajmij(new Wynajem(k, this.s, this.dataWypo, this.dataOd, this.cena));
        }
    }
}
