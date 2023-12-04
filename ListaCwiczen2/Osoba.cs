using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCwiczen2
{
    internal class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public enum plec { K, M};
        public int myPlec;
        public int obliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }
        public double obliczBMI()
        {
            double BMI;
            BMI = (double)waga / ((double)wzrost / 100 * (double)wzrost / 100);
            if (BMI < 18.5)
                Console.WriteLine("Niedowaga!");
            else if (BMI > 30)
                Console.WriteLine("Otylosc!");
            else
                Console.WriteLine("Norma!");
            return BMI;
        }
        public void panPani()
        {
            if (myPlec == 0)
                Console.WriteLine("Dyrektorem jest pani {0} {1}", imie, nazwisko);
            else
                Console.WriteLine("Dyrektorem jest pan {0} {1}", imie, nazwisko);
        }
        public Osoba(string imie, string nazwisko, int rokUrodzenia, int waga, int wzrost, int km)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.waga = waga;
            this.wzrost = wzrost;
            if (km == 0)
                myPlec = (int)plec.K;
            else
                myPlec = (int)plec.M;
        }
    }
}
