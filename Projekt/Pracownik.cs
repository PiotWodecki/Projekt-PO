using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    enum Zajecie
    {
        kierowca,mechanik,ksiegowy,
    }
    [Serializable]
    public class Pracownik
    {
        private double wynagrodzenie;
        private int numerPracownika;
        private Zajecie zajecie;
        public static double premia = 30;
        private DateTime waznoscUmowy;

        public double Wynagrodzenie { get => wynagrodzenie; set => wynagrodzenie = value; }
        public int NumerPracownika
        {
            get
            {
                return numerPracownika;
            }
            set
            {
                if (numerPracownika > 0)
                    numerPracownika = value;
                else
                    throw new Exception("Numer musi być większy od 0");
            }
        }
        internal Zajecie Zajecie { get => zajecie; set => zajecie = value; }
        public DateTime WaznoscUmowy { get => waznoscUmowy; set => waznoscUmowy = value; }


    }
}
