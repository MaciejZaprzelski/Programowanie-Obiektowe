using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Student : Osoba
{
    public int rok;
    public int numerGrupy;
    public int numerAlbumu;
    public Student(int rok, int numerGrupy, int numerAlbumu, string imie, string nazwisko, int rokUrodzenia) : base(imie, nazwisko, rokUrodzenia)
    {
        this.rok = rok;
        this.numerGrupy = numerGrupy;
        this.numerAlbumu = numerAlbumu;
    }
    public Student(int rok, int numerGrupy, int numerAlbumu, string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania) : base(imie, nazwisko, rokUrodzenia, miejsceZamieszkania)
    {
        this.rok = rok;
        this.numerGrupy = numerGrupy;
        this.numerAlbumu = numerAlbumu;
    }
    public void WypiszInfo()
    {
        Console.WriteLine("Imie: {0}\n" +
            "Nazwisko: {1}\n" +
            "Rok urodzenia: {2}", imie, nazwisko, rokUrodzenia);
        Console.WriteLine("Rok: {0}\n" +
            "Numer grupy: {1}\n" +
            "Numer albumu: {2}", rok, numerGrupy, numerAlbumu);
    }
    
}
