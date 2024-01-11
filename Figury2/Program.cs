internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Figury2 Zadania Dodatkowe 231216");
        Kwadrat2 kwadrat1 = new Kwadrat2(4);
        kwadrat1.ObliczPole();
        Trojkat trojkat1 = new Trojkat(3, 4, 5);
        trojkat1.ObliczPole();
        List<Figura2> figury2Lista = new List<Figura2>();
        figury2Lista.Add(new Kwadrat2(1));
        figury2Lista.Add(new Kwadrat2(2));
        figury2Lista.Add(new Kwadrat2(3));
        figury2Lista.Add(new Trojkat(6, 8, 10));
        figury2Lista.Add(new Trojkat(9, 12, 15));
        foreach (Figura2 e in figury2Lista)
            e.ObliczPole();
    }
}