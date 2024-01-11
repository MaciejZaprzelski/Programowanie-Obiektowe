internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadanie 20 lista zadan 231216");
        Test obiekt1 = new Test();
        Test obiekt2 = new Test();
        Test obiekt3 = new Test();
        Test obiekt4 = new Test();
        
        obiekt1.liczba = 255;
        obiekt1.poleTestowe.slowo = "słowo";
        Console.WriteLine("obiekt1: " + obiekt1.liczba + " " + obiekt1.poleTestowe.slowo);
        obiekt2 = obiekt1; //referencja
        obiekt3 = (Test)obiekt1.Clone(); //kopiowanie płytkie
        obiekt4 = obiekt1.GlebokaKopia();
        obiekt1.liczba = 347;
        obiekt1.poleTestowe.slowo = "kaczka";
        Console.WriteLine("obiekt2: " + obiekt2.liczba + " " + obiekt2.poleTestowe.slowo);
        Console.WriteLine("obiekt3: " + obiekt3.liczba + " " + obiekt3.poleTestowe.slowo);
        Console.WriteLine("obiekt4: " + obiekt4.liczba + " " + obiekt4.poleTestowe.slowo);
        Console.WriteLine("obiekt1: " + obiekt1.liczba + " " + obiekt1.poleTestowe.slowo);
        
    }
}

class Test : ICloneable
{
    public int liczba;
    public Test2 poleTestowe;
    public Test()
    {
        poleTestowe = new Test2();
    }
    public Object Clone()
    {
        return MemberwiseClone();
    }
    public Test GlebokaKopia()
    {
        Test tempTest = new Test();
        tempTest.liczba = this.liczba;
        tempTest.poleTestowe.slowo = this.poleTestowe.slowo;
        return tempTest;
    }
}
class Test2
{
    public string slowo;
}