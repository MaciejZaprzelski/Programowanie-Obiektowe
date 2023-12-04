using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCwiczen2
{
    internal class Car
    {
        private string marka;
        private int rok;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;


        public Car(string marka, int rok)
        {
            this.marka = marka;
            if (rok < 1769)
            {
                Console.WriteLine("Za malo, 1769!");
                this.rok = 1769;
            }
            else if (rok > 2017)
            {
                Console.WriteLine("Za duza, 2017");
                this.rok = 2017;
            }
            else
                this.rok = rok;
        }
        public void Info()
        {
            Console.WriteLine("Marka: {0}\n" +
                "Rok: {1}", marka, rok);
        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy;
        }
        public double OliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }
    }
}
