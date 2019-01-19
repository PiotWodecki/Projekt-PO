using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Projekt
{
    public partial class DodajWynajem : Form
    {
       private GlownyInterfejs interfejs;
       public static List<Samochod> dostepneSamochody = new List<Samochod>();

        public DodajWynajem(GlownyInterfejs g)
        {
            InitializeComponent();
            interfejs = g;
        }

        private void DodajWynajem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime poczatek;
            DateTime koniec;
            poczatek = dateTimePickerPoczatek.Value;
            koniec = dateTimePickerKoniec.Value;
            DostepneSamochody.Items.Clear();
            if (poczatek.CompareTo(koniec) <= 0)
            {
                PrzedzialCzasu przedzial = new PrzedzialCzasu(poczatek,koniec);
                foreach (Samochod s in interfejs.ListaSamochodow)
                {
                    if(Wynajem.SprawdzCzyWolny(s,przedzial)!=null) 
                    {
                       
                        DostepneSamochody.Items.Add(s.ToString()); 
                        dostepneSamochody.Add(s);
                         
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Źle wprowadzona data!", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SystemSounds.Exclamation.Play();
            }
        }

        private void dateTimePickerKoniec_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //wynajmij
        {

            int index = DostepneSamochody.SelectedIndex;
            if (index >= 0)
            {
                string wybranySamochod = (string)DostepneSamochody.SelectedItem;
                Samochod samochod = null;
                foreach (Samochod s in interfejs.ListaSamochodow)
                {
                    if (s.ToString().Equals(wybranySamochod))
                    {
                        samochod = s;


                        break;
                    }
                }

                DaneKlienta dane = new DaneKlienta(this, interfejs, samochod,
                    dateTimePickerPoczatek.Value, dateTimePickerKoniec.Value, 
                    Wynajem.ObliczCene(samochod.Typ, dateTimePickerPoczatek.Value, dateTimePickerKoniec.Value));//do czego to jest//dodaje przycisk?
                dane.ShowDialog();
            }
            
                 MessageBox.Show("Nie wybrano żadnego rekordu", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SystemSounds.Exclamation.Play();
        }

        private void DostepneSamochody_OnSelectedIndexChange(object sender, EventArgs e) 
        {
            DateTime poczatek;
            DateTime koniec;
            poczatek = dateTimePickerPoczatek.Value;
            koniec = dateTimePickerKoniec.Value;
            string wybranySamochod = (string)DostepneSamochody.SelectedItem;
 
            foreach (Samochod s in interfejs.ListaSamochodow)
            {
                if (s.ToString().Equals(wybranySamochod))
                {
                    Typ typSamochodu = s.Typ;
                    lKoszt.Text = Wynajem.ObliczCene(typSamochodu, poczatek, koniec).ToString("C0");
                    break;
                }
            }


        }

        private void button3_Click(object sender, EventArgs e) // zamykanie
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PoliczDoLabela()
        {
            Typ t = Typ.cabriolet;      
            DateTime poczatek;
            DateTime koniec;
            poczatek = dateTimePickerPoczatek.Value;
            koniec = dateTimePickerKoniec.Value;
            lKoszt.Text = Wynajem.ObliczCene(t, poczatek, koniec).ToString("C0") + " zł";
        }
        private void lKoszt_Click(object sender, EventArgs e)
        {

            PoliczDoLabela();
        }
    }
}
