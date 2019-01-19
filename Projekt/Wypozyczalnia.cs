using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Wypozyczalnia
    {
        private string nazwaWypozyczalni;
        private string numerNIP;
        private string wlasciciel;


        public string NazwaWypozyczalni { get => nazwaWypozyczalni; set => nazwaWypozyczalni = value; }
        public string NumerNIP { get => numerNIP; set => numerNIP = value; }
        public string Wlasciciel { get => wlasciciel; set => wlasciciel = value; }

        public Wypozyczalnia()
        {
            this.nazwaWypozyczalni = "";
            this.numerNIP = "0000000000";
            this.wlasciciel = "";
        }

        public Wypozyczalnia(string nazwa, string NIP,string wlasciciel)
        {
            this.nazwaWypozyczalni = nazwa;
            this.numerNIP = NIP;
            this.wlasciciel = wlasciciel;
        }
    }
}
