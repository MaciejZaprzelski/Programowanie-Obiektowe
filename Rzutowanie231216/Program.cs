internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Rzytowanie Lista Zadan 231216");
        BaseClass myObj = new BaseClass();
        DerrivedClass derObj1 = (DerrivedClass)myObj;
        NextDerrivedClass NxtObj1 = (NextDerrivedClass)myObj;
    }
}

internal class BaseClass
{

}
internal class DerrivedClass : BaseClass
{

}
internal class NextDerrivedClass : DerrivedClass
{

}