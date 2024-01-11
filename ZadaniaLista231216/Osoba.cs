using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Osoba
{
    protected string imie;
    protected string nazwisko;
    protected int rokUrodzenia;
    private string miejsceZamieszkania;

    public Osoba(string imie, string nazwisko, int rokUrodzenia)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.rokUrodzenia = rokUrodzenia;
    }
    public Osoba(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.rokUrodzenia = rokUrodzenia;
        this.miejsceZamieszkania = miejsceZamieszkania;
    }
    public void WypiszInfo()
    {
        Console.WriteLine("Imie: {0}\n" +
            "Nazwisko: {1}\n" +
            "Rok urodzenia: {2}", imie, nazwisko, rokUrodzenia);
    }
    public void WypiszZamieszkanie()
    {
        Console.WriteLine("Zamieszkanie: {0}", miejsceZamieszkania);
    }
    public void ObliczWiek()
    {
        Console.WriteLine("Wiek: {0}", DateTime.Now.Year - rokUrodzenia);
    }
}
