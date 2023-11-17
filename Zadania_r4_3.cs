internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //zadanie_4_1();
        //zadanie_4_2();
        //zadanie_4_3();
        //zadanie_4_4();
        //zadanie_4_5();
        //zadanie_4_6();
        //zadanie_4_7();
        //zadanie_4_8();
        //zadanie_4_9();
        zadanie_4_10();
    }

    private static void zadanie_4_1()
    {
        int[] tablica = new int[5];

        Console.WriteLine("Zadanie 4.1");
        Console.WriteLine("Podaj 5 liczb calkowitych:");

        for (int i = 0; i < 5; i++)
            tablica[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Podane Liczby to:");
        for (int i = 0; i < 5; i++)
            Console.WriteLine(tablica[i]);
    }

    private static void zadanie_4_2()
    {
        int[] tab1 = new int[10];
        int[] tab2 = new int[10];
        int j = 0;
        Random losuj = new Random();

        Console.WriteLine("\nZadanie 4.2");

        for (int i = 0; i < 10; i++)
            tab1[i] = losuj.Next(100);
        
        Console.Write("Tab1: ");
        for (int i = 0; i < 10; i++)
            Console.Write("{0}, ", tab1[i]);
        Console.Write("\n");
        
        for (int i = 0; i < 10; i++)
            if (tab1[i] % 2 == 0)
                tab2[j++] = tab1[i];

        Console.Write("Tab1: ");
        for (int i = 0; i < j; i++)
            Console.Write("{0}, ", tab2[i]);
        Console.Write("\n");
    }

    private static void zadanie_4_3()
    {
        int[] tablica = new int[100];
        int max_war, max_poz, min_war, min_poz;
        int ile_dodatnich, suma;
        double srednia;
        Random rnd = new Random();

        Console.WriteLine("\nZadanie 4.3");

        for (int i = 0; i < 100; i++)
            tablica[i] = rnd.Next(1000) - 500;
        
        Console.Write("Tablica: ");
        for (int i = 0; i < 100; i++)
            Console.WriteLine("{0}: {1}", i, tablica[i]);
            //Console.Write("{0} ", tablica[i]);

        max_war = min_war = tablica[0];
        max_poz = min_poz = 0;
        for(int i = 1; i < 100; i++)
        {
            if(max_war < tablica[i])
            {
                max_war = tablica[i];
                max_poz = i;
            }
            if(min_war > tablica[i])
            {
                min_war = tablica[i];
                min_poz = i;
            }
        }
        Console.WriteLine("min_war = {0}, min_poz = {1}", min_war, min_poz);
        Console.WriteLine("max_war = {0}, max_poz = {1}", max_war, max_poz);

        suma = 0;
        for (int i = 0; i < 100; i++)
            suma += tablica[i];
        srednia = (double)suma / 100;
        Console.WriteLine("Srednia = {0}", srednia);

        ile_dodatnich = 0;
        for (int i = 0; i < 100; i++)
            if (tablica[i] >= 0)
            {
                Console.Write("{0} ", tablica[i]);
                ile_dodatnich++;
            }
                
        Console.Write("\nIle dodatnich: {0}\n", ile_dodatnich);
    }

    private static void zadanie_4_4()
    {
        int[] tab1 = new int[100];
        Random rnd = new Random();
        int czyJest, ileLiczb;

        Console.WriteLine("\nZadanie 4.4");

        for (int i = 0; i < 100; i++)
            tab1[i] = rnd.Next(1000);
        Array.Sort(tab1);
        Console.Write("Tab1: ");
        for (int i = 0; i < 100; i++)
            Console.Write("{0} ", tab1[i]);
        Console.Write("\n");

        ileLiczb = 0;
        for(int i = 0; i < 100; i++)
        {
            czyJest = 1;
            for(int j = 2; j < tab1[i] / 2; j++)
            {
                if (tab1[i] % j == 0)
                {
                    czyJest = 0;
                    break;
                }
            }
            if(czyJest == 1)
            {
                Console.Write("{0} ", tab1[i]);
                ileLiczb++;
            }
        }
        Console.WriteLine("Ile liczb pierwszych: {0}", ileLiczb);
    }

    private static void zadanie_4_5()
    {
        int n = 100;
        int[] tab1 = new int[n];
        int[] tab2 = new int[n];
        Random rnd = new Random();

        Console.WriteLine("\nZadanie 4.5");

        for (int i = 0; i < n; i++)
            tab1[i] = i;
        
       /*
        Console.WriteLine("Tab1 :");
        for (int i = 0; i < n; i++)
            Console.Write("{0} ", tab1[i]);
        Console.Write("\n");
        */
        for (int i = 0; i < n - 1; i++)
            tab2[i + 1] = tab1[i];
        tab2[0] = tab1[n - 1];

        Console.WriteLine("Tab2 :");
        for (int i = 0; i < n; i++)
            Console.Write("{0} ", tab2[i]);
        Console.Write("\n");
    }

    private static void zadanie_4_6()
    {
        double[,] tab1 = new double[5, 5];
        double suma = 0;
        Random rnd = new Random();

        Console.WriteLine("\nZadanie 4.6");

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                tab1[i, j] = rnd.NextDouble() * 100;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
                Console.Write("{0:00.00} ", tab1[i, j]);
            Console.Write("\n");
        }
        for (int i = 0; i < 5; i++)
            suma += tab1[i, i];
        Console.WriteLine("suma przekatnej = {0:0.00}", suma);
    }

    private static void zadanie_4_7()
    {
        int[,] tab1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] tab2 = new int[,] { { 7, 8, 9 }, { 1, 2, 4 } };
        int[,] tab_suma = new int[2, 3];

        Console.WriteLine("\nZadanie 4.7");

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 3; j++)
                tab_suma[i, j] = tab1[i, j] + tab2[i, j];

        Console.WriteLine("tab_suma:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write("{0} ", tab_suma[i, j]);
            Console.Write("\n");
        }        
    }

    private static void zadanie_4_8()
    {
        string[,] dniTygodnia;

        Console.WriteLine("\nZadanie 4.8");

        dniTygodnia = new string[3, 3]; // pamiętaj o zmianie rozmiaru tablicy
        dniTygodnia[0, 0] = "poniedzialek";
        dniTygodnia[0, 1] = "monday";
        dniTygodnia[0, 2] = "montag";
        dniTygodnia[1, 0] = "wtorek";
        dniTygodnia[1, 1] = "tuesday";
        dniTygodnia[1, 2] = "dienstag";
        dniTygodnia[2, 0] = "sroda";
        dniTygodnia[2, 1] = "wednesday";
        dniTygodnia[2, 2] = "mittwoch";

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write("{0} ", dniTygodnia[i, j]);
            Console.Write("\n");
        }
    }

    private static void zadanie_4_9()
    {
        string tekst;
        int ileWyrazow;
        bool czySpacja = true;

        Console.WriteLine("\nZadanie 4.9");
        Console.WriteLine("Napisz cos:");
        tekst = Console.ReadLine();
        /*
        ileWyrazow = tekst.Split(' ').Count();
        Console.WriteLine("Liczba wyrazow: {0}", ileWyrazow);
        */
        ileWyrazow = 0;
        for(int i = 0; i < tekst.Length; i++)
        {
            if (tekst[i] == ' ')
            {
                czySpacja = true;
            }
            else if(czySpacja)
            {
                ileWyrazow++;
                czySpacja = false;
            }
        }
        Console.WriteLine("Liczba wyrazow: {0}", ileWyrazow);
    }

    private static void zadanie_4_10()
    {
        string data;
        string[] miesiac = new string[] {"sty", "lut", "mar", "kwi",
                                        "maj", "cze", "lip", "sie",
                                        "wrz", "paz", "lis", "gru"};
        bool czyLiczba = false;
        int n;

        Console.WriteLine("\nZadanie 4.9");
        Console.WriteLine("Podaj date (DD-MM-RRRR):");
        data = Console.ReadLine();

        czyLiczba = int.TryParse(data.Substring(3, 2), out n);
        Console.WriteLine("n = {0} ", n);
        if (czyLiczba)
            if (n > 0 && n < 13)
                Console.WriteLine(miesiac[n - 1]);
            else
                Console.WriteLine("Poza zakresem");
        else
            Console.WriteLine("Zly format!");
    }
}