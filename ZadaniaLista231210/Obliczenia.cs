using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Obliczenia
{
    private static double liczba1;
    private static double liczba2;
    private static double wynik;

    public static void Start()
    {
        Console.WriteLine("Wybierz dzialanie (+, -, *, /, ^, ^-): ");
        switch(Console.ReadLine())
        {
            case "+":
                Dodawanie();
                break;
            case "-":
                Odejmowanie();
                break;
            case "*":
                Mnozenie();
                break;
            case "/":
                Dzielenie();
                break;
            case "^":
                Potegowanie();
                break;
            case "^-":
                Pierwiastkowanie();
                break;
            default:
                Dodawanie();
                break;
        }
        Console.WriteLine("Wynik = " + wynik);
    }
    private static double PobierzLiczbe()
    {
        double x = 0;
        bool p = true;
        while (p)
        {
            try
            {
                Console.WriteLine("Podaj liczbe:");
                x = double.Parse(Console.ReadLine());
                p = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                p = true;
            }
        }
        return x;
    }
    private static void Dodawanie()
    {
        double x;
        bool p = true;
        liczba1 = PobierzLiczbe();
        liczba2 = PobierzLiczbe();
        try
        {
            x = liczba1 + liczba2;
            p = true;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            p = false;
        }
        if (p == false)
            wynik = 0;
    }
    private static void Odejmowanie()
    {
        bool p = true;
        liczba1 = PobierzLiczbe();
        liczba2 = PobierzLiczbe();
        try
        {
            wynik = liczba1 - liczba2;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            p = false;
        }
        if (p == false)
            wynik = 0;
    }
    private static void Mnozenie()
    {
        bool p = true;
        liczba1 = PobierzLiczbe();
        liczba2 = PobierzLiczbe();
        try
        {
            wynik = liczba1 * liczba2;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            p = false;
        }
        if (p == false)
            wynik = 0;
    }
    private static void Dzielenie()
    {
        bool p = true;
        liczba1 = PobierzLiczbe();
        liczba2 = PobierzLiczbe();
        
        try
        {
            if (liczba2 == 0)
            {
                throw new Exception("Dzielenie przez zero!");
                wynik = 0;
            }
            else
            {
                wynik = liczba1 / liczba2;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    private static void Potegowanie()
    {
        bool p = true;
        liczba1 = PobierzLiczbe();
        liczba2 = PobierzLiczbe();
        try
        {
            wynik = Math.Pow(liczba1, liczba2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            p = false;
        }
        if (p == false)
            wynik = 0;
    }
    private static void Pierwiastkowanie() 
    {
        bool p = true;
        liczba1 = PobierzLiczbe();
        liczba2 = PobierzLiczbe();
        try
        {
            wynik = Math.Pow(liczba1, 1 / liczba2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            p = false;
        }
        if (p == false)
            wynik = 0;
    }
    
}
