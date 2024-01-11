using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Student : Osoba
{
    private int rokStudiow;
    private int numerGrupy;
    private int numerAlbumu;
    public Student(int rokStudiow, int numerGrupy, int numerAlbumu, string imie, string nazwisko) : base(imie, nazwisko)
    {
        this.rokStudiow = rokStudiow;
        this.numerAlbumu = numerAlbumu;
        this.numerGrupy = numerGrupy;
    }
    public override void WypiszInfo()
    //public new void WypiszInfo()    
    {
        Console.WriteLine("Klasa Student!\n" +
            "Imie: {0}\n" +
            "Nazwisko: {1}\n" +
            "Rok: {2}\n" +
            "Grupa: {3}\n" +
            "Album: {4}", imie, nazwisko, rokStudiow, numerGrupy, numerAlbumu);
        base.WypiszInfo();
    }
}
