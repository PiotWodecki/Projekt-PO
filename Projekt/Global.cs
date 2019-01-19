using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public static class Global 
    {
        private static Dictionary<Typ, double> dict; 
        public static Dictionary<Typ, double> Dict { get => dict; set => dict = value; }

        static Global() 
        {
            Dict = new Dictionary<Typ, double>();
            dict.Add(Typ.cabriolet, 160.0);
            dict.Add(Typ.hatchback, 100.0);
            dict.Add(Typ.kombi, 120.0);
            dict.Add(Typ.sedan, 130.0);
            dict.Add(Typ.van, 150.0);
        }
        
        public static void DodajPozycje(Typ t, double cena)
        {
            Dict.Add(t,cena);
        }

        public static void UsunPozycje(Typ t)
        {
            dict.Remove(t);
        }
    
    }
}
