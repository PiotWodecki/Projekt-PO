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
    public partial class DadajSamochod : Form
    {
        private GlownyInterfejs glownyinterfejs;
        public DadajSamochod(GlownyInterfejs glowny)
        {
            InitializeComponent();
            glownyinterfejs = glowny;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kolor k = Kolor.czarny;
            string kolor = Convert.ToString(lKolor.SelectedItem);
            if (kolor.Equals("czarny"))
                k = Kolor.czarny;
            else if (kolor.Equals("bialy"))
                k = Kolor.bialy;
            else if (kolor.Equals("czerwony"))
                k = Kolor.czerwony;
            else if (kolor.Equals("niebieski"))
                k = Kolor.niebieski;


            Typ t = Typ.hatchback;
            string typ = Convert.ToString(lTyp.SelectedItem);
            if (typ.Equals("hatchback"))
                t = Typ.hatchback;
            if (typ.Equals("cabriolet"))
                t = Typ.cabriolet;
            if (typ.Equals("sedan"))
                t = Typ.sedan;
            if (typ.Equals("van"))
                t = Typ.van;
            if (typ.Equals("kombi"))
                t = Typ.kombi;

           
            glownyinterfejs.ListaSamochodow.Add(new Samochod(tMarka.Text, tModel.Text, k, t, tNR.Text));

            glownyinterfejs.ZmienListeSamochodow();
            this.Close();
        }

        private void DadajSamochod_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
