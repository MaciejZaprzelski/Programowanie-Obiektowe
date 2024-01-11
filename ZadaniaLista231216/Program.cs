internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista zadan 231216");
        Console.WriteLine("\nZadanie 1:");
        Osoba osoba1 = new Osoba("Ork", "Wojownik", 1969);
        osoba1.WypiszInfo();
        osoba1.ObliczWiek();
        Console.WriteLine("\nZadanie 2:");
        Student student1 = new Student(1, 2, 667, "Elf", "Mag", 2000);
        student1.WypiszInfo();
        student1.ObliczWiek();
        Console.WriteLine("\nZadanie 5:");
        Student student2 = new Student(2, 3, 132, "Hobbit", "Ogrodnik", 2001, "Shire");
        student2.WypiszInfo();
        student2.WypiszZamieszkanie(); //Do private klasa pochodna nie może się bezpośrednio odwołać
        Console.WriteLine("\nZadanie 6:");
        StudentPierwszegoRoku student1r1 = new StudentPierwszegoRoku(1, 2, 133, "Frodo", "Baggins", 1997);
        student1r1.WypiszInfo();
        Console.WriteLine("\nZadanie 7:");
        Osoba osoba2 = new Osoba("Goblin", "Szaman", 1955);
        osoba1 = student1;
        //student2 = osoba2; //rodzica nie można przypisać do potomka
        osoba1.WypiszInfo();
    }
}