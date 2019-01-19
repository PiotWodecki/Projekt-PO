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
    public partial class Dostepnosc : Form
    {
        private GlownyInterfejs g;
        private List<PrzedzialCzasu> listaprzedzialow;

        public Dostepnosc(GlownyInterfejs jakisinterfejs, List<PrzedzialCzasu> listaprzedzialowczasowych)
        {
            InitializeComponent();
            g = jakisinterfejs;
            dDostepnosc.Columns.Add("Od","Od"); 
            dDostepnosc.Columns.Add("Do","Do"); 
            listaprzedzialow = listaprzedzialowczasowych;
           
            if (listaprzedzialowczasowych != null)
            {
                foreach (PrzedzialCzasu przedzial in listaprzedzialowczasowych)
                {
                    dDostepnosc.Rows.Add(przedzial.Poczatek.ToString("yyyy-MM-dd"), przedzial.Koniec.ToString("yyyy-MM-dd"));//dodalismy to w nawiasie zeby nie poazywalo godzin
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//zamknij
        {
            this.Close();
        }

        private void dDostepnosc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Dodaj_Click(object sender, EventArgs e) //dodawanie
        {
            DateTime poczatek;
            DateTime koniec;
           
            poczatek = dateTimePickerPoczatek.Value;
            koniec = dateTimePickerKoniec.Value;
            if(poczatek.CompareTo(koniec)<=0)
            {
                this.listaprzedzialow.Add(new PrzedzialCzasu(poczatek, koniec));
                dDostepnosc.Rows.Add(poczatek.ToString("yyyy-MM-dd"), koniec.ToString("yyyy-MM-dd"));
                g.ZapiszListeSamochodow();
            }
            else
                MessageBox.Show("Wybrana data jest nieprawidłowa", "Błąd",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SystemSounds.Exclamation.Play();

        }

        private void button2_Click(object sender, EventArgs e)//usuwanie
        {
            if (dDostepnosc.SelectedRows.Count > 0 && dDostepnosc.SelectedRows[0].Index<this.listaprzedzialow.Count)//druga polowa warunku po to zeby nie wywalo jesli na nic nie klikniemy i nacisniemy usun//po co jest to 0 w nawiasie
            {
                int indeks = dDostepnosc.SelectedRows[0].Index;
                this.listaprzedzialow.RemoveAt(indeks);
                dDostepnosc.Rows.RemoveAt(indeks);
                g.ZapiszListeSamochodow();
            }
        }

        private void Dostepnosc_Load(object sender, EventArgs e)
        {

        }
        
    }
}
