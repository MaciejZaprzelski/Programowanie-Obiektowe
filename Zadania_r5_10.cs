using System;

internal class Zadania_r5_10
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Zadanie_1(100));
        Zadanie_2();
        Zadanie_3();
        Zadanie_4();
        Zadanie_5();
        Zadanie_6();
        Zadanie_7();
        Zadanie_8();
        Zadanie_9();
        Zadanie_10();
    }

    private static double Zadanie_1(double F)
    {
        double C;

        Console.WriteLine("Zadanie 1");
        C = (F - 32) / 1.8;

        return C;
    }
    private static void Zadanie_2()
    {
        int a, b, x;
        bool c;
        Console.WriteLine("\nZadanie 2");
        Console.WriteLine("Podaj przedzail <a,b> i liczbe x (int):");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        x = int.Parse(Console.ReadLine());
        c = Zadanie_2a(a, b, x);
        if (c)
            Console.WriteLine("Liczba {0} jest w przedziale <{1}, {2}>", x, a, b);
        else
            Console.WriteLine("Liczba {0} NIE jest w przedziale <{1}, {2}>", x, a, b);

    }
    private static bool Zadanie_2a(int a, int b, int x)
    {
        if (x >= a && x <= b)
            return true;
        return false;
    }

    private static void Zadanie_3()
    {
        double x, y;
        double[] wek = new double[] { 3, 2 };
        Console.WriteLine("\nZadanie 3");
        Console.WriteLine("Podaj x i y punktu(double):");
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        Zadanie_3a(ref x, ref y, wek);
        Console.WriteLine("wek = [{0}, {1}], x = {2}, y = {3}", wek[0], wek[1], x, y);
    }
    private static void Zadanie_3a(ref double x, ref double y, double[] wektor)
    {
        x += wektor[0];
        y += wektor[1];
    }

    private static void Zadanie_4()
    {
        int[] tab = new int[10];
        int[] tabA = new int[10];
        Random rnd = new Random();
        Console.WriteLine("\nZadanie 4");

        for (int i = 0; i < 10; i++)
            tab[i] = rnd.Next(100);
        Console.Write("tab: ");
        for (int i = 0; i < 10; i++)
            Console.Write("{0} ", tab[i]);
        Console.Write("\n");

        tabA = Zadanie_4a(tab, 5);
        Console.Write("tabA: ");
        for (int i = 0; i < 10; i++)
            Console.Write("{0} ", tabA[i]);
        Console.Write("\n");

        Zadanie_4b(tab, 5);
        Console.Write("tab: ");
        for (int i = 0; i < 10; i++)
            Console.Write("{0} ", tab[i]);
        Console.Write("\n");
    }
    private static int[] Zadanie_4a(int[] tab, int x)
    {
        int[] tabR = new int[tab.Length];
        for (int i = 0; i < tab.Length; i++)
            tabR[i] = tab[i] * x;
        return tabR;
    }
    private static void Zadanie_4b(int[] tab, int x)
    {
        for (int i = 0; i < 10; i++)
            tab[i] *= x;
    }

    private static void Zadanie_5()
    {
        int x, y;
        char c;

        Console.WriteLine("\nZadanie 5");
        Console.WriteLine("Podaj dlugosc, szerokosc(int) i znak(char):");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        c = char.Parse(Console.ReadLine());

        Zadanie_5_Rysuj(x, y, c);
    }
    private static void Zadanie_5_Rysuj(int x, int y, char c)
    {
        Console.Write("\n");
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
                Console.Write("{0}", c);
            Console.Write("\n");
        }

        Console.Write("\n");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
                Console.Write("{0}", c);
            Console.Write("\n");
        }
    }
    private static void Zadanie_6()
    {
        string[] tab = new string[] { "Ala", "ma", "kota" };
        Console.WriteLine("\nZadanie 6");
        Zadanie_6a(tab, 5);
    }
    private static void Zadanie_6a(string[] tab, int x)
    {
        string[] tabA = new string[tab.Length];
        //for (int i = 0; i < tab.Length; i++)
        //   tabA[i] = tab[i];

        for (int i = 0; i < tabA.Length; i++)
            for (int j = 0; j < x; j++)
                tabA[i] += tab[i];
        for (int i = 0; i < tabA.Length; i++)
            Console.WriteLine("{0}", tabA[i]);
    }

    private static void Zadanie_7()
    {
        int x, n;
        Console.WriteLine("\nZadanie 7");
        Console.WriteLine("Podaj x i n(int):");
        x = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("W = {0}", Zadanie_7a(x, n));
    }
    private static int Zadanie_7a(int x, int n)
    {
        int W = 0;
        for (int i = 1; i <= n; i++)
            W += x + i;
        return W;
    }

    private static void Zadanie_8()
    {
        uint x;

        Console.WriteLine("\nZadanie 8");
        Console.WriteLine("Podaj liczbe (int):");
        x = uint.Parse(Console.ReadLine());
        Console.WriteLine("{0}: {1}", x, Zadanie_8a(x));
    }
    private static uint Zadanie_8a(uint x)
    {
        uint suma = 0;

        while (x > 0)
        {
            suma += x % 10;
            x /= 10;
        }

        return suma;
    }

    private static void Zadanie_9()
    {
        int x = 7;
        Console.WriteLine("\nZadanie 9");
        Console.WriteLine("iteracja  : f({0}) = {1}", x, Zadanie_9_iteracja(x));
        Console.WriteLine("rekurencja: f({0}) = {1}", x, Zadanie_9_iteracja(x));
    }

    public static int Zadanie_9_iteracja(int n)
    {
        int number = n - 1;
        int[] Fib = new int[number + 1];
        Fib[0] = 0;
        Fib[1] = 1;
        for (int i = 2; i <= number; i++)
        {
            Fib[i] = Fib[i - 2] + Fib[i - 1];
        }
        return Fib[number];
    }

    public static int Zadanie_9_Rek(int n)
    {
        if ((n == 0) || (n == 1))
        {
            return n;
        }
        else
            return Zadanie_9_Rek(n - 1) + Zadanie_9_Rek(n - 2);
    }

    public static void Zadanie_10()
    {
        Console.WriteLine("\nZadanie 10");
        Console.WriteLine("Wynik = {0}", Oblicz(5));

    }
    static int Oblicz(int n)
    {
        if (n <= 1) return (1);
        else return (n + Oblicz(n - 1)); //5 + 4 +3 + 2 + 1 = 15
    }
}