using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szkolenie.Zadania;
namespace ObslugaZadanWPF
{
    public class PersonContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Zadanie> Zadania { get; set; }
    }
}
