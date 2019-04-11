using System;
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
                Zadanie z1 = new Zadanie(1, "Test1");
                
                z1.ZmienStatus(1);

                Zadanie z2 = new Zadanie("Test2", DateTime.Now.AddDays(30));
                z1.Tytul = "Test property 1";
                Console.WriteLine(z1.Tytul);
                Console.WriteLine(z1.OpisZadania());
                Console.WriteLine(z2.OpisZadania());
                
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
