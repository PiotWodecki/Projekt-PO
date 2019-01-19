using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Media;

namespace Projekt
{
    public partial class GlownyInterfejs : Form
    {
        private List<Samochod> listaSamochodow;
        private List<Wynajem> listawynajmow;
        private List<Klient> listKlientow;

        public GlownyInterfejs()
        {
            InitializeComponent();

            listaSamochodow = new List<Samochod>();
            Listawynajmow = new List<Wynajem>();
            ListKlientow = new List<Klient>();
            
            OdczytajListeSamochodow();
            OdczytajListeKlientow();
            OdczytajListeWynajmow();
            ListaSam.DataSource = listaSamochodow;
        }

        internal List<Samochod> ListaSamochodow { get => listaSamochodow; set => listaSamochodow = value; }
        internal List<Klient> ListKlientow { get => listKlientow; set => listKlientow = value; }
        internal List<Wynajem> Listawynajmow { get => listawynajmow; set => listawynajmow = value; }

        public void ZmienListeSamochodow()
        {
            ZapiszListeSamochodow();
            ListaSam.DataSource = null;
            ListaSam.DataSource = listaSamochodow; 
            
        }
        
        public void ZapiszListeSamochodow()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Samochod>));
            StreamWriter sw = new StreamWriter("ListaSomochodow.xml");
            xs.Serialize(sw, this.listaSamochodow);
            sw.Close();
        }

        public void OdczytajListeSamochodow()
        {
            if (File.Exists("ListaSomochodow.xml")) { 
                XmlSerializer xs = new XmlSerializer(typeof(List<Samochod>));
                StreamReader tr = new StreamReader("ListaSomochodow.xml");
                this.listaSamochodow = (List<Samochod>)xs.Deserialize(tr);
                tr.Close();
            }
        }

        public void ZapiszListeKlientow()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Klient>));
            StreamWriter sw = new StreamWriter("ListaKlientow.xml");
            xs.Serialize(sw, this.listKlientow);
            sw.Close();
        }

        public void OdczytajListeKlientow()
        {
            if (File.Exists("ListaKlientow.xml"))
            { 
                XmlSerializer xs = new XmlSerializer(typeof(List<Klient>));
                StreamReader tr = new StreamReader("ListaKlientow.xml");
                this.listKlientow = (List<Klient>)xs.Deserialize(tr);
                tr.Close();
            }
        }

        public void ZapiszListeWynajmow()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Wynajem>));
            StreamWriter sw = new StreamWriter("ListaWynajem.xml");
            xs.Serialize(sw, this.Listawynajmow);
            sw.Close();
        }

        public void OdczytajListeWynajmow()
        {
            if (File.Exists("ListaWynajem.xml"))
            { 
                XmlSerializer xs = new XmlSerializer(typeof(List<Wynajem>));
                StreamReader tr = new StreamReader("ListaWynajem.xml");
                this.Listawynajmow = (List<Wynajem>)xs.Deserialize(tr);
                tr.Close();
            }
        }

        
        private void button1_Click(object sender, EventArgs e) // Dodaj samochod
        {
            DadajSamochod dodajSamochod = new DadajSamochod(this);
            dodajSamochod.ShowDialog();
        }

        
        private void button2_Click(object sender, EventArgs e) // Usun samochod
        {
            int index = ListaSam.SelectedIndex; 
            if(index >= 0) { 
                ListaSamochodow.RemoveAt(index);
                ZmienListeSamochodow();
            }
            else
            {
                MessageBox.Show("Musisz zaznaczyć pojazd!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SystemSounds.Exclamation.Play();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = ListaSam.SelectedIndex;
            if (index >= 0) 
            {
                Dostepnosc dostepnosc = new Dostepnosc(this,ListaSamochodow[index].dostepnosc); 
                dostepnosc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego rekordu", "Błąd", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SystemSounds.Exclamation.Play();
            }
            
        }
        
        private void button4_Click(object sender, EventArgs e) // wynajmij
        {
            DodajWynajem wynajem = new DodajWynajem(this);
            wynajem.ShowDialog();
        }
        
        private void button5_Click(object sender, EventArgs e) // dodaj klienta
        {
            DodajKlienta klient = new DodajKlienta(this);

            klient.ShowDialog();
        }

        private void GlownyInterfejs_Load(object sender, EventArgs e)
        {

        }
    }
}
