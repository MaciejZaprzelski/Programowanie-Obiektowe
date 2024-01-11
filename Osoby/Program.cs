internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadania Dodatkowe 231216");
        Osoba osoba1 = new Osoba("Ork", "Wojownik");
        Student student1 = new Student(1, 2, 665, "Elf", "Mag");
        osoba1.WypiszInfo();
        student1.WypiszInfo();
        Osoba student2 = new Student(2, 3, 123, "Hobbit", "Włamywacz");
        //new spowoduje użycie metody WypiszInfo z klasy Osoba
        //virtual override użyje metody WypiszInfo z klasy Student
        student2.WypiszInfo();
    }
}