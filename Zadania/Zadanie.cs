using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Zadania
{
    //public, internal, private
    public class Zadanie
    {
        //Zmienna na poziomie klasy - pole
        private readonly int nrZadania;
        private string tytulZadania;
        public DateTime dataRozpoczecia;
        public DateTime dataZakonczenia;
        private int statusZadania;
        public const string info = "Test";
        //KOnstruktor. Tworząc własny nie tworzy się domyślny.
        public Zadanie(int nrZadania, string tytulZadania)
        {
            this.nrZadania = nrZadania;
            this.tytulZadania = tytulZadania;
        }

        public Zadanie(string tytulZadania, DateTime dataZakonczenia)
        {
            this.tytulZadania = tytulZadania;
            this.dataZakonczenia = dataZakonczenia;
        }

        public string OpisZadania()
        {
            var info = $"Zadanie nr: {nrZadania}, " +
                $"tytuł: {tytulZadania}, " +
                $"status: {statusZadania}, " +
                $"data zakończenia: {dataZakonczenia}";
            return info;
        }

        public void ZmienStatus(int nowyStatus)
        {
            if ((nowyStatus <0) || (nowyStatus >5))
            {
                throw new FormatException("Błędny status zadania");
            }

            statusZadania = nowyStatus;
        }

        public string Tytul
        {
            get
            {
                return tytulZadania;
            }
            set
            {
                if(value.Length ==0)
                {
                    throw new FormatException("Tytuł nie może być zerowej długości");
                }
                tytulZadania = value;
            }
        }

        public int Numer
        {
            get
            {
                return nrZadania;
            }
        }
    }
}
