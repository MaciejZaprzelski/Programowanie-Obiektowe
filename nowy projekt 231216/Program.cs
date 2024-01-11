internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nowy projekt interfejs Lista Zadan 231216");
        Car car1 = new Car();
        Bicycle bike1 = new Bicycle();
        car1.Ride();
        bike1.Ride();
        Osoba osoba1 = new Osoba();
        osoba1.Graj();
        iGitarzysta osoba2 = new Osoba();
        osoba2.Graj();
        iSkrzypek osoba3 = new Osoba();
        osoba3.Graj();
    }
}
internal class Vehicle
{

}
internal class Car : Vehicle, IRideAble
{
    public void Ride()
    {
        Console.WriteLine("Jade samochodem!");
    }
}
internal class Bicycle : Vehicle, IRideAble
{
    public void Ride()
    {
        Console.WriteLine("Jade rowerem!");
    }
}
interface IRideAble
{
    void Ride();
}