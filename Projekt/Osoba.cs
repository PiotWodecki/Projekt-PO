using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [Serializable]
    public abstract class Osoba
    {
        private string imie;
        private string nazwisko;
        private string pesel;
        private string numerDowodu;
        private DateTime dataUrodzenia;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel { get => pesel; set => pesel = value; }
        public string NumerDowodu { get => numerDowodu; set => numerDowodu = value; }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }

        protected Osoba()
        {
            this.imie = "";
            this.nazwisko = "";
            this.pesel = "00000000000";
        }

        protected Osoba(string imie, string nazwisko, string pesel, string numerDowodu, DateTime dataUrodzenia)
        {

            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.numerDowodu = numerDowodu;
            this.dataUrodzenia = dataUrodzenia;
        }

        public override string ToString()
        {
            return this.imie + " " + this.nazwisko + " " + this.pesel;
        }
    }
}
