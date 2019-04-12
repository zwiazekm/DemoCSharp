using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Zadania
{
    //public, internal, private
    public class Zadanie : DoZrobienia, IZadanie
    {
        //Zmienna statyczna
        private static int ostatniNrZadania = 0;
        //Zmienna na poziomie klasy - pole
        protected readonly int nrZadania;
        protected string tytulZadania;
        public DateTime DataRozpoczecia { get; private set; }
        public DateTime DataZakonczenia { get; set; }
        public TypyStatusow StatusZadania { get; private set; }
        public const string info = "Test zadania";

        //Metoda Statyczna
        private static int NowyNumer()
        {
            return ++ostatniNrZadania;
        }

        public static int OstatniNumer()
        {
            return ostatniNrZadania;
        }

        //KOnstruktor. Tworząc własny nie tworzy się domyślny.
        public Zadanie(string tytulZadania)
        {
            nrZadania = NowyNumer();
            this.tytulZadania = tytulZadania;
        }

        public Zadanie(string tytulZadania, DateTime dataZakonczenia)
        {
            nrZadania = NowyNumer();
            this.tytulZadania = tytulZadania;
            this.DataZakonczenia = dataZakonczenia;
        }

        public void RozpocznijZadanie(DateTime dataRozpoczecia)
        {
            this.DataRozpoczecia = dataRozpoczecia;
        }

        public virtual string OpisZadania()
        {
            var info = $"Zadanie nr: {nrZadania}, " +
                $"tytuł: {tytulZadania}, " +
                $"status: {StatusZadania}, " +
                $"data zakończenia: {DataZakonczenia}";
            return info;
        }

        public string OpisZadania2()
        {
            var info = $"Zadanie nr: {nrZadania}, " +
                $"tytuł: {tytulZadania}, " +
                $"status: {StatusZadania}, " +
                $"data zakończenia: {DataZakonczenia}";
            return info;
        }

        public void ZmienStatus(TypyStatusow nowyStatus)
        {
            if (((int)nowyStatus < -1) || ((int)nowyStatus > 2))
            {
                throw new FormatException("Błędny status zadania");
            }

            StatusZadania = nowyStatus;
        }

        public string GetTytul()
        {
            return tytulZadania;
        }

        public void SetTytul(string nowyTytul)
        {
            tytulZadania = nowyTytul;
        }

        public override string Szczegoly()
        {
            return "Szczegóły zadania";
        }

        public string Tytul
        {
            get
            {
                return tytulZadania;
            }
            set
            {
                if (value.Length == 0)
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

        public virtual DateTime PlanowanyTermin
        {
            get; set;
        }
    }
}
