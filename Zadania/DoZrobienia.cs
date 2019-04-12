using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Zadania
{
    public abstract class DoZrobienia
    {
        protected string tytul;
        protected bool zrobione;

        public virtual string Opis()
        {
            var info = $"Todo nr: {tytul}, zrobione: {zrobione}";
            return info;
        }

        public abstract string Szczegoly();
    }
}
