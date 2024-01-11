using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class StudentPierwszegoRoku : Student
{
    public StudentPierwszegoRoku(int rok, int numerGrupy, int numerAlbumu, string imie, string nazwisko, int rokUrodzenia) : base(rok, numerGrupy, numerAlbumu, imie, nazwisko, rokUrodzenia)
    {
        this.rok = 1;
    }

    public StudentPierwszegoRoku(int rok, int numerGrupy, int numerAlbumu, string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania) : base(rok, numerGrupy, numerAlbumu, imie, nazwisko, rokUrodzenia, miejsceZamieszkania)
    {
    }
}