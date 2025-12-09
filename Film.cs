using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzamin0306
{
    internal class Film
    {
        protected string tytul = "";
        protected int liczba_wypozyczen = 0;

        public string Tytul
        {
            get => tytul;
            set => tytul = value.Length > 20 ? value.Substring(0, 20) : value;
            //set { tytul = value.Length > 20 ? value.Substring(0,20) : value;}
        }
        public int Liczbawypozyczen
        {
            get => liczba_wypozyczen;

        }

        public void RealizacjaWypozyczen()
        {
            liczba_wypozyczen++;
        }

        public override string ToString()
        {
            return $"film ma nazwe {tytul} ,posiada wypozyczen: {liczba_wypozyczen}";

        }
    }
}


