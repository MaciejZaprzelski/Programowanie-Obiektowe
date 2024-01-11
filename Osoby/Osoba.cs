using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Osoba
{
    protected string imie;
    protected string nazwisko;
    public Osoba()
    {

    }
    public Osoba(string imie, string nazwisko)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
    }
    public virtual void WypiszInfo()
    //public void WypiszInfo()
    {
        Console.WriteLine("Klasa Osoba!");
        Console.WriteLine("Imie: " + imie);
        Console.WriteLine("Nazwisko: " + nazwisko);
    }
}
