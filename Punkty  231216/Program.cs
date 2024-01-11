internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Figury Lista 231316");
        Punkt punkt1 = new Punkt(10, 15, "punkt1");
        punkt1.Wyswietl();
        punkt1.PobierzDaneZKlawiatury();
        punkt1.Wyswietl();
        Punkt punkt2 = new Punkt(0, 2, "punkt2");
        punkt2 = (Punkt)punkt1.Clone();
        punkt2.Wyswietl();
        Kolo kolo1 = new Kolo(5, 10, 15, "kolo1");
        kolo1.PobierzDaneZKlawiatury();
        kolo1.Wyswietl();
        kolo1.LiczObwod();
        Kwadrat kwadrat1 = new Kwadrat(0, 0, 5, "kwadrat1");
        kwadrat1.LiczObwod();
        kwadrat1.Wyswietl();
        kwadrat1.PobierzDaneZKlawiatury();
        kwadrat1.LiczObwod();
        kwadrat1.Wyswietl();
    }
}
interface Polecenia
{
    void LiczObwod();
    void PobierzDaneZKlawiatury();
    void Wyswietl();
}
class Punkt : ICloneable, Polecenia
{
    public double X;
    public double Y;
    public string nazwa;

    public Punkt(double X, double Y, string nazwa)
    {
        this.X = X;
        this.Y = Y;
        this.nazwa = nazwa;
    }
    public Object Clone()
    {
        return MemberwiseClone();
    }
    public void LiczObwod()
    {
        Console.WriteLine("Pole punktu wynosi 0");
    }
    public void PobierzDaneZKlawiatury()
    {
        Console.WriteLine("Podaj X:");
        try
        {
            X = double.Parse(Console.ReadLine());
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Podaj Y:");
        try
        {
            Y = double.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public void Wyswietl()
    {
        Console.WriteLine(toString(0));
    }
    private string toString(int x)
    {
        switch(x)
        {
            default:
                return string.Format("{0}: ({1}; {2})", nazwa, X, Y);
        }
    }
}
class Kolo : ICloneable, Polecenia
{
    public Punkt O;
    public double r;
    public string nazwa;

    public Kolo(double X, double Y, double r, string nazwa)
    {
        O = new Punkt(X, Y, "srodek " + nazwa);
        this.r = r;
        this.nazwa = nazwa;
    }
    public Object Clone()
    {
        return MemberwiseClone();
    }
    public void LiczObwod()
    {
        Console.WriteLine("Obwód koła wynosi {0}", 2 * 3.14 * r);
    }
    public void PobierzDaneZKlawiatury()
    {
        Console.WriteLine("Środek koła:");
        O.PobierzDaneZKlawiatury();
        Console.WriteLine("Promień koła:");
        try
        {
            r = double.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public void Wyswietl()
    {
        Console.WriteLine(toString(1));
        Console.WriteLine(toString(5));
    }
    private string toString(int x)
    {
        switch(x)
        {
            case 1:
                return string.Format("Nazwa: {0}\nŚrodek: ({1}; {2})\nPromień: {3}", 
                   nazwa ,O.X, O.Y, r);
            case 2:
                return string.Format("Środek: ({0}; {1})", O.X, O.Y);
            case 3:
                return string.Format("Promień: {2}", r);
            default:
                return string.Format("Środek: ({0}; {1})\nPromień: {2}", O.X, O.Y, r);
        }        
    }
}
class Kwadrat : ICloneable, Polecenia
{
    public Punkt A;
    public Punkt B;
    public Punkt C;
    public Punkt D;
    public string nazwa;
    public Kwadrat(double x, double y, double r, string nazwa)
    {
        A = new Punkt(x, y, "A");
        B = new Punkt(x + r, y, "B");
        C = new Punkt(x + r, y - r, "C");
        D = new Punkt(x, y - r, "D");
        this.nazwa = nazwa;
    }
    public Object Clone()
    {
        return MemberwiseClone();
    }
    public void LiczObwod()
    {
        double a;
        a = MathF.Abs((float)(A.X-B.X));
        Console.WriteLine("Obwod {0}: {1}", nazwa, 4 * a);
    }
    public void PobierzDaneZKlawiatury()
    {
        double r = 1;
        Console.WriteLine("Podaj punkt A");
        A.PobierzDaneZKlawiatury();
        Console.WriteLine("Podaj długość boku:");
        try
        {
            r = double.Parse(Console.ReadLine());
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("r = " + r);
        }
        B.X = A.X + r;
        B.Y = A.Y;
        C.X = A.X + r;
        C.Y = A.Y - r;
        D.X = A.X;
        D.Y = A.Y - r;
    }
    public void Wyswietl()
    {
        Console.WriteLine(toString(4));
    }
    private string toString(int x)
    {
        switch(x)
        {
            default:
                return string.Format("A: ({0}; {1})\nB: ({2}; {3})\nC: ({4}; {5})\nD: ({6}; {7})", 
                    A.X, A.Y, B.X, B.Y, C.X, C.Y, D.X, D.Y);
        }
    }
}