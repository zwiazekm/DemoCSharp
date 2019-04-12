using System;
using System.Collections.Generic;
using Szkolenie.Zadania;

namespace ObslugaZadan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestZadania();
                DoZrobienia dz = new Oplata("Rata 1", 234.34M, DateTime.Now.AddDays(5));
                IZadanie iz = new Oplata("Rata 1", 234.34M, DateTime.Now.AddDays(5));
                
                //Oplata o1 = new Oplata("Rata 1", 234.34M, DateTime.Now.AddDays(5));
                //o1.Splata(100M);
                //Console.WriteLine(o1.OpisZadania());

                //Zadanie zo = o1;
                //zo.Tytul = "Nowy tytu oplaty";
                //zo.ZmienStatus(TypyStatusow.Wykonywane);
                //Console.WriteLine(zo.OpisZadania());

                //Oplata o2 = (Oplata)zo;
                //Console.WriteLine(o2.OpisZadania());

                //Console.WriteLine("Polimorficznie:");
                //Console.WriteLine(o1.OpisZadania2());
                //Console.WriteLine(zo.OpisZadania2());
                //Console.WriteLine(o2.OpisZadania2());

                //Object obj1 = o2;
                //Console.WriteLine(obj1.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        private static void TestZadania()
        {
            try
            {
                Zadanie[] zadania = new Zadanie[5];
                List<Zadanie> listaZadan = new List<Zadanie>();

                Zadanie z1 = new Zadanie("Test1");
                zadania[0] = z1;
                listaZadan.Add(z1);
                
                z1.ZmienStatus(TypyStatusow.Wykonywane);
                
                z1.Tytul = "Test property 1";
                Zadanie z2 = new Zadanie("Test2", DateTime.Now.AddDays(30));
                zadania[1] = z2;
                listaZadan.Add(z2);
                
                z2.ZmienStatus((TypyStatusow)(-1));

                zadania[4] = new Zadanie("Test5");
                listaZadan.Add(zadania[4]);

                Oplata o1 = new Oplata("Ratra 1", 234.34M, DateTime.Now.AddDays(5));
                o1.Splata(100M);
                listaZadan.Add(o1);



                //Odczyt z Array zadania
                Console.WriteLine("Array:");
                foreach (var z in zadania)
                {
                    if (z != null)
                        Console.WriteLine(  z.OpisZadania());
                }
                //Odczyt z kolekcji listaZadan
                Console.WriteLine("Lista:");
                foreach (var z in listaZadan)
                {
                    Console.WriteLine(z.OpisZadania2());
                }
                Console.WriteLine($"Ostatni nr: {Zadanie.OstatniNumer()}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Błąd ogólny w test");
                throw; //ponowienie błędu
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.WriteLine("Po catch");
        }
    }
}
