internal class Zadania_r6
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        Console.WriteLine("PRACA DOMOWA rodzial 6, klasy.");

        //Zadanie 1
        Console.WriteLine("\nZadanie 1");
        Zadanie1_Prostokat obj_zad1 = new Zadanie1_Prostokat(10, 20);
        obj_zad1.pokaz();

        //Zadanie 2
        Console.WriteLine("\nZadanie 2");
        Zadanie1_Prostokat[] obj_zad2 = new Zadanie1_Prostokat[4];
        for (int i = 0; i < 4; i++)
            obj_zad2[i] = new Zadanie1_Prostokat(rnd.Next(1, 100), rnd.Next(1, 100));
        Console.WriteLine("FOR:");
        for (int i = 0; i < 4; i++)
            obj_zad2[i].pokaz();
        Console.WriteLine("FOREACH:");
        foreach (Zadanie1_Prostokat pnt in obj_zad2)
            pnt.pokaz();
        //Zadanie 3
        Zadanie3(obj_zad2);

        //Zadanie 4
        Console.WriteLine("\nZadanie 4");
        Zadanie4_Energia obj_zad4 = new Zadanie4_Energia(50.1, 120.8);
        Console.WriteLine("Energia start {0}\n" +
            "Eneriga teraz {1}",
            obj_zad4.pokaz_licznik_start, obj_zad4.zmiana_licznika_teraz);
        obj_zad4.zmiana_licznika_teraz = 420.34;
        Console.WriteLine("Zmiania energia teraz {0}", obj_zad4.zmiana_licznika_teraz);
        Console.WriteLine("Energia zuzyta {0}", obj_zad4.Energia());

        //Zadanie 5
        Console.WriteLine("\nZadanie 5");
        Zadanie6_Punkt obj_zad5 = new Zadanie6_Punkt(20.1, 31.6);
        obj_zad5.Pokaz();
        Console.WriteLine("Przesuniecie o [10; 14]");
        obj_zad5.Przesun(10, 14);
        obj_zad5.Pokaz();

        //Zadanie 6
        Console.WriteLine("\nZadanie 6");
        Zadanie6_Punkt[] obj_zad6 = new Zadanie6_Punkt[3];
        obj_zad6[0] = new Zadanie6_Punkt(2, 5);
        obj_zad6[1] = new Zadanie6_Punkt(4, 9);
        obj_zad6[2] = new Zadanie6_Punkt(46, 93);
        Zadanie6(obj_zad6);

        Zadanie6_Punkt[] obj_zad6_2 = new Zadanie6_Punkt[3];
        obj_zad6_2[0] = new Zadanie6_Punkt(2, 5);
        obj_zad6_2[1] = new Zadanie6_Punkt(4, 9);
        obj_zad6_2[2] = new Zadanie6_Punkt(46, 66);
        Zadanie6(obj_zad6_2);

        //Zadanie 7
        Console.WriteLine("\nZadanie 7");
        Zadanie7_Odcinek obj_zad7 = new Zadanie7_Odcinek(3, 3, -2, -2);
        Console.WriteLine("Odcinek = {0}", obj_zad7.Dlugosc_Odcinka());

        //Zadanie 8
        Console.WriteLine("\nZadanie 8");
        Zadanie8_Prostopadloscian obj_zad8_a = new Zadanie8_Prostopadloscian(2, 3, 2);
        Zadanie8_Prostopadloscian obj_zad8_b = new Zadanie8_Prostopadloscian(4, 3, 2);

        Console.WriteLine("Ob a = {0}\n" +
            "Ob b = {1}", obj_zad8_a.Objetosc(), obj_zad8_b.Objetosc());
        Console.WriteLine("Ob a z Ob b:");
        obj_zad8_a.Porownaj(obj_zad8_b.Objetosc());
        Console.WriteLine("Ob b z Ob b:");
        obj_zad8_b.Porownaj(obj_zad8_b.Objetosc());

        //Zadanie 9
        Console.WriteLine("\nZadanie 9");
        Zadanie9_prostokat stru_zad9;
        stru_zad9.dlugosc = 10;
        stru_zad9.szerokosc = 5;
        Console.WriteLine("P = {0}\n" +
            "Ob = {1}", Zadanie9_Pole(stru_zad9), Zadanie9_Ob(stru_zad9));
        Zadanie9_prostokat[] stru_zad9_tab = new Zadanie9_prostokat[4];
        for(int i = 0; i < 4; i++)
        {
            stru_zad9_tab[i].dlugosc = rnd.Next(1,10);
            stru_zad9_tab[i].szerokosc = rnd.Next(1, 10);
        }
        for (int i = 0; i < 4; i++)
            Console.WriteLine("{0}: dl = {1} sz = {2}",
               i, stru_zad9_tab[i].dlugosc, stru_zad9_tab[i].szerokosc);
        Zadanie9_Pokaz(stru_zad9_tab);

        //Zadanie 10
        Console.WriteLine("\nZadanie 10");
        Zadanie10_studnet[] stru_zad10_tab = new Zadanie10_studnet[5];
                
        for(int i = 0; i < 5; i++)
        {
            for (int j = 0; j < rnd.Next(5, 15); j++)
                stru_zad10_tab[i].Nazwisko += Convert.ToChar(rnd.Next(97, 122));
            stru_zad10_tab[i].Nazwisko = stru_zad10_tab[i].Nazwisko.First().ToString().ToUpper() + string.Join("", stru_zad10_tab[i].Nazwisko.Skip(1));

            stru_zad10_tab[i].punktyInformatyka = rnd.Next(0, 100);
            stru_zad10_tab[i].punktyMatematyka = rnd.Next(0, 100);
            stru_zad10_tab[i].punktyJezykObcy = rnd.Next(0, 100);

            Console.WriteLine("Nazwisko: {0}\n" +
                "Ptk inf: {1}\n" +
                "Ptk mat: {2}\n" +
                "Ptk obcy: {3}\n", 
                stru_zad10_tab[i].Nazwisko,
                stru_zad10_tab[i].punktyInformatyka,
                stru_zad10_tab[i].punktyMatematyka,
                stru_zad10_tab[i].punktyJezykObcy);            
        }
        Zadanie10_Punkty(stru_zad10_tab);
        
    }

    private static void Zadanie3(Zadanie1_Prostokat[] a)
    {   
        int max, maxIndex;
        maxIndex = 0;
        max = a[0].Pole;

        Console.WriteLine("\nZadanie 3");

        for (int i = 1; i < 4; i++)
        {
            if(max < a[i].Pole)
            {
                max = a[i].Pole;
                maxIndex = i;
            }
        }
        Console.WriteLine("Max pole = {0} na indeksie {1}", max, maxIndex);
    }

    private static void Zadanie6(Zadanie6_Punkt[] a)
    {
        //[x1, y1] = t * [x2, y2]
        double wynik;
        wynik = (a[1].gdzie_x - a[0].gdzie_x) * (a[2].gdzie_y - a[0].gdzie_y) - (a[2].gdzie_x - a[0].gdzie_x) * (a[1].gdzie_y - a[0].gdzie_y);
        if (wynik == 0)
            Console.WriteLine("Wektory sa wspolinionwe.");
        else
            Console.WriteLine("Wektory NIE sa wspolinionwe.");
    }

    private static double Zadanie9_Pole(Zadanie9_prostokat a)
    {
        return a.szerokosc * a.dlugosc;
    }
    private static double Zadanie9_Ob(Zadanie9_prostokat a)
    {
        return 2 * a.szerokosc + 2 * a.dlugosc;
    }
    private static void Zadanie9_Pokaz(Zadanie9_prostokat[] a)
    {
        foreach(Zadanie9_prostokat p in a)
        {
            Console.WriteLine("P = {0}, Ob = {1}", Zadanie9_Pole(p), Zadanie9_Ob(p));
        }
    }
    private static void Zadanie10_Punkty(Zadanie10_studnet[] a)
    {
        double wynik;
        Console.WriteLine("Zliczona punktacja:");
        foreach(Zadanie10_studnet pnt in a)
        {
            wynik = 0.5 * pnt.punktyInformatyka + 0.6 * pnt.punktyMatematyka + 0.2 * pnt.punktyJezykObcy;
            Console.WriteLine("{0}: {1:0.0}", pnt.Nazwisko, wynik);
        }
    }
}

internal class Zadanie1_Prostokat
{
    private int dlugosc;
    private int szerokosc;
    public int Pole
    {
        get { return dlugosc * szerokosc; }
    }

    public Zadanie1_Prostokat(int a, int b)
    {
        dlugosc = a;
        szerokosc = b;
    }

    private int pole()
    {
        return dlugosc * szerokosc;
    }
    private int obwod()
    {
        return 2 * dlugosc + 2 * szerokosc;
    }
    public void pokaz()
    {
        Console.WriteLine("P = {0}, Ob = {1}", pole(), obwod());
    }
}

internal class Zadanie4_Energia
{
    private double licznik_start;
    private double licznik_teraz;
    public double zmiana_licznika_teraz
    {
        get { return licznik_teraz; }
        set { licznik_teraz = value; }
    }
    public double pokaz_licznik_start
    {
        get { return licznik_start; }
    }

    public Zadanie4_Energia(double start)
    {
        licznik_start = start;
    }
    public Zadanie4_Energia(double start, double teraz )
    {
        licznik_start = start;
        licznik_teraz = teraz;
    }
    public double Energia()
    {
        return licznik_teraz - licznik_start;
    }
}

internal class Zadanie6_Punkt
{
    private double x;
    private double y;

    public double gdzie_x
    {  
        get { return x; }
    }
    public double gdzie_y
    {
        get { return y; }
    }


    public Zadanie6_Punkt(double a, double b)
    {
        x = a;
        y = b;
    }
    public void Przesun(double a, double b)
    {
        x += a;
        y += b;
    }
    public void Pokaz()
    {
        Console.WriteLine("x = {0}, y = {1}", x, y);
    }
}

internal class Zadanie7_Odcinek
{
    Zadanie6_Punkt A;
    Zadanie6_Punkt B;

    public Zadanie7_Odcinek(double Ax, double Ay, double Bx, double By)
    {
        A = new Zadanie6_Punkt(Ax, Ay);
        B = new Zadanie6_Punkt(Bx, By);
    }
    public double Dlugosc_Odcinka()
    {
        return Math.Sqrt(Math.Pow(B.gdzie_x - A.gdzie_x, 2) + Math.Pow(B.gdzie_y - A.gdzie_y, 2));
    }
}

internal class Zadanie8_Prostopadloscian
{
    double dlugosc;
    double szerokosc;
    double wysokosc;

    public Zadanie8_Prostopadloscian(double a, double b, double h)
    {
        dlugosc = a;
        szerokosc = b;
        wysokosc = h;
    }

    public double Objetosc()
    {
        return dlugosc * szerokosc * wysokosc;
    }
    public void Porownaj(double x)
    {
        if (Objetosc() != x)
            Console.WriteLine("Objetosci NIE sa rowne!");
        else
            Console.WriteLine("Objetosci sa rowne!");
    }
}

public struct Zadanie9_prostokat
{
    public double dlugosc;
    public double szerokosc;
}
public struct Zadanie10_studnet
{
    public string Nazwisko;
    public int punktyMatematyka;
    public int punktyInformatyka;
    public int punktyJezykObcy;
}