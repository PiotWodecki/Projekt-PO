using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [Serializable]
    public class Wynajem
    {
        private DateTime dataWypozyczenia;
        private DateTime dataZwrotu;
        private DateTime opoznienieZwrotu;
        private double cena;
        private static double oplataDodatkowa;
        public Samochod samochod;
        public Klient klient;

        public DateTime DataWypozyczenia { get => dataWypozyczenia; set => dataWypozyczenia = value; }
        public DateTime DataZwrotu { get => dataZwrotu; set => dataZwrotu = value; }
        public DateTime OpoznienieZwrotu { get => opoznienieZwrotu; set => opoznienieZwrotu = value; }
        public double Cena { get => cena; set => cena = value; }
        public static double OplataDodatkowa { get => oplataDodatkowa; set => oplataDodatkowa = value; }

        public Wynajem()
        {
            DateTime data = DateTime.Today;
            this.dataWypozyczenia = data;                   
            this.dataZwrotu = data.AddDays(1);

        }

        public Wynajem(DateTime wypozyczenie, DateTime zwrot) 
        {
            this.dataWypozyczenia = wypozyczenie;
            this.dataZwrotu = zwrot;
        }

        public Wynajem(Klient k, Samochod s, DateTime wypozyczenie, DateTime zwrot, double c)
        {
            this.klient = k;
            this.samochod = s;
            this.dataWypozyczenia = wypozyczenie;
            this.dataZwrotu = zwrot;
            this.cena = c;
        }

        public static PrzedzialCzasu SprawdzCzyWolny(Samochod s,PrzedzialCzasu p)
        {
            foreach(PrzedzialCzasu x in s.dostepnosc)
            {
                if (x.Poczatek.CompareTo(p.Poczatek) <= 0 && x.Koniec.CompareTo(p.Koniec) >= 0)
                    return x;
            }
            return null;
        }

        public static double ObliczCene(Typ t, DateTime wypozyczenie, DateTime zwrot)
        {
            TimeSpan liczbaDni = zwrot - wypozyczenie;
            int liczbaDniWypozyczenia = (int)Math.Ceiling(liczbaDni.TotalDays); 
            double cenaOdDnia=Global.Dict[t];
            double calkowitaCenaWynajmu = liczbaDniWypozyczenia * cenaOdDnia;       
            return calkowitaCenaWynajmu;
        }
    }
}

