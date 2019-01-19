using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [Serializable]
    public class Klient : Osoba
    {
        private string miastoZamieszkania;
        private string ulicaZamieszkania;
        private string lokalZamieszkania;
        private string kodPocztowy;

        public string MiastoZamieszkania { get => miastoZamieszkania; set => miastoZamieszkania = value; }
        public string UlicaZamieszkania { get => ulicaZamieszkania; set => ulicaZamieszkania = value; }
        public string LokalZamieszkania { get => lokalZamieszkania; set => lokalZamieszkania = value; }
        public string KodPocztowy { get => kodPocztowy; set => kodPocztowy = value; }

        public Klient()
        {
            miastoZamieszkania = "";
            ulicaZamieszkania = "";
            lokalZamieszkania = null;
            kodPocztowy = "00-000";
        }
        public Klient(string imie, string nazwisko, string pesel, string numerDowodu, DateTime dataUrodzenia,
                     string miasto, string ulica, string lokal, string kod) 
            : base(imie, nazwisko, pesel, numerDowodu, dataUrodzenia)
        {
            this.miastoZamieszkania = miasto;
            this.ulicaZamieszkania = ulica;
            this.lokalZamieszkania = lokal;
            this.kodPocztowy = kod;
        }
    }
}
