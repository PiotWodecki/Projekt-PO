using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [Serializable]
    public class PrzedzialCzasu
    {
        private DateTime poczatek;
        private DateTime koniec;

        public DateTime Poczatek { get => poczatek; set => poczatek = value; }
        public DateTime Koniec { get => koniec; set => koniec = value; }

        public PrzedzialCzasu()
        {
            poczatek = new DateTime();
            koniec = new DateTime();
        }

        public PrzedzialCzasu(DateTime t1, DateTime t2)
        {
            poczatek = t1;
            koniec = t2;
        }

    }
}
