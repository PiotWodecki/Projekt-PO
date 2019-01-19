using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Projekt
{
    public enum Kolor
    {
        bialy, niebieski, czerwony, czarny
    }
    public enum Typ
    {
        sedan,hatchback,kombi,van,cabriolet
    }

    [Serializable]
    [XmlRoot(ElementName = "Samochod")] 
    public class Samochod : IRezerwowalny
    {
        private string marka;
        private string model;
        private string numerRejestracyjny;
        private Kolor kolor;
        private Typ typ;
        private double cena;

        [XmlArrayItem("Dostepnosc")]
        public List<PrzedzialCzasu> dostepnosc;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string NumerRejestracyjny { get => numerRejestracyjny; set => numerRejestracyjny = value; }
        internal Kolor Kolory { get => kolor; set => kolor = value; }
        internal Typ Typ { get => typ; set => typ = value; }
        public double Cena { get => cena; set => cena = value; }


        
        public Samochod()
        {
            this.marka = "Toyota";
            this.model = "Yaris";
            this.dostepnosc = new List<PrzedzialCzasu>();
        }

        public Samochod(string marka, string model, Kolor kolor, Typ typ, string nr)
        {
            this.marka = marka;
            this.model = model;
            this.kolor = kolor;
            this.typ = typ;
            this.numerRejestracyjny = nr;
            this.dostepnosc = new List<PrzedzialCzasu>();
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();         
            sb.Append("Marka: " + marka);
            sb.Append(" Model: " + model);
            sb.Append(" Numer rejstracyjny: " + numerRejestracyjny);
            sb.Append(" Kolor: " + kolor);
            sb.Append(" Typ: " + typ);

            return sb.ToString();
        }
        public void Zarezerwuj(PrzedzialCzasu p)
        {
            PrzedzialCzasu przedzialCzasowy = Wynajem.SprawdzCzyWolny(this, p);
            if(przedzialCzasowy!=null)
            {
                if(!p.Poczatek.ToString("yyyy-MM-dd").Equals(przedzialCzasowy.Poczatek.ToString("yyyy-MM-dd"))) //sprawdzamy czy nie pokrywa sie z datą zarezerwowaną
                {
                    this.dostepnosc.Add(new PrzedzialCzasu(przedzialCzasowy.Poczatek, p.Poczatek));
                }
                if (!p.Koniec.ToString("yyyy-MM-dd").Equals(przedzialCzasowy.Koniec.ToString("yyyy-MM-dd")))
                {
                    this.dostepnosc.Add(new PrzedzialCzasu(p.Koniec,przedzialCzasowy.Koniec));
                }

                this.dostepnosc.Remove(przedzialCzasowy);
            }
            
        }




    }
}
