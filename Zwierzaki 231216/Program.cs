internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zwierzaki Lista 231216");
        Console.WriteLine("Obiekty klasy pies:");
        Pies pies1 = new Pies("Azor", 12, 13);
        Pies pies2 = new Pies("Burek", 22, 23);
        pies1.JakSiePoruszam();
        pies2.CoJem();
        Console.WriteLine("Pies2 " + pies2.imie + pies2.waga + pies2.rozmiar);
        pies2 = (Pies)pies1.Copy();
        Console.WriteLine("Pies1 " + pies1.imie + pies1.waga + pies1.rozmiar);
        Console.WriteLine("Pies2 " + pies2.imie + pies2.waga + pies2.rozmiar);
        //Płytka kopia może być w rodzicu natomiast głęboka kopia musi być w każdym potomku
        //Metoda głębokiej kopii w tym przypadku nie jest potrzebna, ponieważ w kalsach nie ma żadnych referencji
        Console.WriteLine("Obiekty klasy wilk:");
        Wilk wilk1 = new Wilk("Gerald", 45, 56);
        Wilk wilk2 = new Wilk("Czerwony Kapturek", 22, 23);
        wilk1.JakSiePoruszam();
        wilk1.CoJem();
        wilk1 = (Wilk)wilk2.Copy();
        Console.WriteLine("Obiekty klasy krokodyl:");

    }
}

interface CoRobie
{
    void JakSiePoruszam();
    void CoJem();
}
class Zwierze : CoRobie
{
    public virtual void JakSiePoruszam()
    {
        Console.WriteLine("Nic nie robię.");
    }
    public virtual void CoJem()
    {
        Console.WriteLine("Nic nie jem.");
    }
    public Object Copy()
    {
        return MemberwiseClone();
    }
}
class Pies : Zwierze
{
    public string imie;
    public int waga;
    public int rozmiar;

    public Pies(string imie, int waga, int rozmiar)
    {
        this.imie = imie;
        this.waga = waga;
        this.rozmiar = rozmiar;
    }
    public override void JakSiePoruszam()
    {
        Console.WriteLine("Chodze na smyczy.");
    }
    public override void CoJem()
    {
        Console.WriteLine("Jem konserwy.");
    }
}
class Wilk : Zwierze
{
    public string imie;
    public int waga;
    public int rozmiar;

    public Wilk(string imie, int waga, int rozmiar)
    {
        this.imie = imie;
        this.waga = waga;
        this.rozmiar = rozmiar;
    }
    public override void JakSiePoruszam()
    {
        Console.WriteLine("Chodze na czterech lapach.");
    }
    public override void CoJem()
    {
        Console.WriteLine("Jem owce.");
    }
}
class Rekin : Zwierze
{
    public string imie;
    public int waga;
    public int rozmiar;

    public Rekin(string imie, int waga, int rozmiar)
    {
        this.imie = imie;
        this.waga = waga;
        this.rozmiar = rozmiar;
    }
    public override void JakSiePoruszam()
    {
        Console.WriteLine("Pływam w oceanie.");
    }
    public override void CoJem()
    {
        Console.WriteLine("Jem ludzi.");
    }
}
class Krokodyl : Zwierze
{
    public string imie;
    public int waga;
    public int rozmiar;

    public Krokodyl(string imie, int waga, int rozmiar)
    {
        this.imie = imie;
        this.waga = waga;
        this.rozmiar = rozmiar;
    }
    public override void JakSiePoruszam()
    {
        Console.WriteLine("Pływam w Nilu.");
    }
    public override void CoJem()
    {
        Console.WriteLine("Jem Egipcjan.");
    }
}