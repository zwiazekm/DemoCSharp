using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Typy danych
            /* Liczby całkowite: int, long, byte, uint
             * LIczby ułamkowe:
             *  - stałej długości: decimal
             *  - zmiennej długości: float, double
             *  Znak: char
             *  Tekst: string
             *  Data i Czas: DateTime, TimeSpan
             *  PrawdaFałsz: bool
             * */

            //Zmienne
            //Nazwa zmiennej:
            //    -musi zaczynać się od litery, 
            //    -nie może mieć spacji
            //    -nie może nazywać się jak instrukcja
            int wiek; //Deklaracja zmiennej 
            wiek = 20; //Przypisanie i zainicjowanie zmiennej
            string imie = "Testuś";//Deklaracja i zainicjowanie
            decimal kwota = 20.3M;

            /* Typy operatorów:
             * - Arytmetyczne: +, -, *, /, %
             * - Inkrementacja, dekrementacja: ++, --
             * - Porównania: ==, !=, <, >,  >=, <=, is - do sprawdzania typu referencyjnego
             * - łączenie tekstów: +
             * - Logiczne:  &, &&, |, ||, !
             * - Przypisania: =, +=, -=, *= 
             * - Warunkowy:  ?:
             */
             //Przyklad arytmetyczne
            int a = 5, b = 20;
            int c = a + b * 2 - 10;
            //Przklad inkrementacji
            int d = a++;
            //Console.WriteLine("d={0}, a={1}", d, a);
            //Console.WriteLine($"d={d}, a={a}");
            d++; d += 1; d = d + 1; //Wszystkie robią to samo
            //Przyklad łączenia tekstów
            string infoName = "Hello" + " Testus";
            //Przyklad Porownania i logiczne
            if (((a >= b) && (d==c)) || a<10) ;
            //Przykład przypisania
            a += 40; a = a + 40;
            a *= 5; a = a * 5;
            //Przyklad warunkowego
            string wynik = (a > 30) ? "Ok" : "Nie OK";


            //Konwersja
            //niejawna - z mniejszego do większego (szczególnego do ogólnego)
            int f = 45;

            long g = f;
            decimal h = f;
            g = (long)int.MaxValue + 1;
            checked
            {
                f = (int)g;
            }
            
            Console.WriteLine($"f={f}");
            Console.ReadLine();
        }
    }
}
