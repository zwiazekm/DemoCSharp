using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Zadania
{
    public class ZarzadcaZadan
    {
        List<Zadanie> listaZadan = new List<Zadanie>();

        public void DodajZadanie(Zadanie noweZadanie)
        {
            //TODO: Dodać walidacje zadania
            listaZadan.Add(noweZadanie);
        }

        public void DodajZadanie(string tytul, DateTime termin )
        {
            //TODO: Dodać walidacje terminu
            Zadanie noweZadanie = new Zadanie(tytul, termin);
            //   listaZadan.Add(noweZadanie);
            DodajZadanie(noweZadanie);
        }

        public IEnumerable<Zadanie> Zadania()
        {
            return listaZadan;
        }

        public Zadanie WyswietlZadanie(int nrZadania)
        {
            var wynik = (from z in listaZadan
                        where z.Numer == nrZadania
                        select z).Single();

            var wynik2 = listaZadan.Where(z => z.Numer == nrZadania).Single();
            return wynik;
        }

        public List<string> ZadaniaNieZakonczone()
        {
            var wynik = from z in listaZadan
                        where z.StatusZadania != TypyStatusow.Zakonczone
                        //select new { Tytul = z.Tytul, Termin = z.PlanowanyTermin }
                        select z.Tytul;
            //return listaZadan
            //    .Where(z => z.StatusZadania != TypyStatusow.Zakonczone)
            //    .Select(z => z.Tytul).ToList();
            return wynik.ToList<string>();
        }
    }
}
