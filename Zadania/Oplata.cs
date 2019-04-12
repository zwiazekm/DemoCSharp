using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Zadania
{
    public sealed class Oplata : Zadanie
    {
        private decimal kwotaPlatnosci;


        public Oplata(string tytul, decimal kwota, DateTime termin) :
            base(tytul, termin)
        {
            kwotaPlatnosci = kwota;
        }

        public void Splata(decimal kwotaSplaty)
        {
            kwotaPlatnosci -= kwotaSplaty;
        }

        public decimal KwotaDoSplaty
        {
            get
            {
                return kwotaPlatnosci;
            }
        }

        public override string OpisZadania()
        {
            var info = $"Opłata nr: {nrZadania}, " +
                $"tytuł: {tytulZadania}, " +
                $"status: {StatusZadania}, " +
                $"Termin: {DataZakonczenia}, " +
                $"Kwota: {KwotaDoSplaty}";
            return info;
        }

        public new string OpisZadania2()
        {
            var info = $"Opłata nr: {nrZadania}, " +
                $"tytuł: {tytulZadania}, " +
                $"status: {StatusZadania}, " +
                $"Termin: {DataZakonczenia}, " +
                $"Kwota: {KwotaDoSplaty}";
            return info;
        }

        public override string ToString()
        {
            return OpisZadania();
        }

        public override DateTime PlanowanyTermin { get => base.PlanowanyTermin; set => base.PlanowanyTermin = value; }
    }
}
