using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Zadania
{
    public interface IZadanie
    {
        void ZmienStatus(TypyStatusow nowyStatus);
        string Tytul { get; set; }
        string OpisZadania();

        int Numer { get; }
        
        DateTime PlanowanyTermin { get; set; }
    }
}
