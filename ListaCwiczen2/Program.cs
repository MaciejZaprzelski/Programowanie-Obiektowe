internal class Program
{
    private static void Main(string[] args)
    {
        //Zadania od 1 do 11
        Console.WriteLine("Hello, World!");
        string Car = "Moj samochod";
        ListaCwiczen2.Car objCar = new ListaCwiczen2.Car("BMW", 1969);
        objCar.Info();
        ListaCwiczen2.Car objCar2 = new ListaCwiczen2.Car("Volvo", 2020);
        objCar2.Info();
        objCar2 = objCar;
        objCar2.Info();
        objCar.srednieSpalanie = 0.05;
        Console.WriteLine("Cena paliwa {0}, dlugosc trasy {1}, koszt {2}", 5.69, 123, objCar.OliczKosztPrzejazdu(123, 5.69));

        //Zadania od 12 do 17
        Console.WriteLine();
        ListaCwiczen2.Osoba dyrektor = new ListaCwiczen2.Osoba("Abc", "Xyz", 1950, 83, 150, 1);
        dyrektor.panPani();
        Console.WriteLine("Wiek wynosi {0}", dyrektor.obliczWiek());
        ListaCwiczen2.Osoba pacjent = new ListaCwiczen2.Osoba("Def", "Efg", 1970, 50, 175, 1);
        Console.WriteLine("BMI = {0}", pacjent.obliczBMI());

        //Zadanie 18 Koszyk
        Console.WriteLine("\nZadanie 18 Koszyk");
        Towar itm1 = new Towar("Zeszyt", 2.5);
        Towar itm2 = new Towar("Dlugopis", 1.6);
        Towar itm3 = new Towar("Podrecznik", 25.99);
        Koszyk kosz = new Koszyk();
        kosz.dodaj(itm1);
        kosz.dodaj(itm2);
        kosz.dodaj(itm3);
        kosz.dodaj(itm1);
        kosz.zawartosc();
        kosz.sumaCeny();

        //Zadanie 19 Liczby zespolone
        Console.WriteLine("\nZadanie 19 Liczby Zespolone");
        ListaCwiczen2.Zespolone objZespolone = new ListaCwiczen2.Zespolone(17.34, 12.87, 8.76, 5.19);
        objZespolone.dzialania();
    }
}

internal class Towar
{
    public string nazwa;
    public double cena;
    public Towar(string nazwa, double cena)
    {
        this.nazwa = nazwa;
        this.cena = cena;
    }
}

internal class Koszyk
{
    private List<Towar> listaTowarow = new List<Towar>();

    public void dodaj(Towar towar)
    {
        listaTowarow.Add(towar);
    }
    public void zawartosc()
    {
        foreach(Towar p in listaTowarow)
        {
            Console.WriteLine(p.nazwa);
        }
    }
    public void sumaCeny()
    {
        double suma = 0;
        foreach(Towar p in listaTowarow)
        {
            suma += p.cena;
        }
        Console.WriteLine("Suma wynosi: {0:0.00}", suma);
    }
}