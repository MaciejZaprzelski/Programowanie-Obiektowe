using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista zadan 231210");
        Car objCar1 = new Car();
        Car objCar2 = new Car(66.9, "Hjundaj");
        Console.WriteLine("\nKonstruktor domyslny:");
        objCar1.show();
        Console.WriteLine("\nKonstruktor przeciazony:");
        objCar2.show();
        Console.WriteLine("\nCar Create():");
        objCar2 = objCar2.Create();
        objCar2.show();
        objCar2 = null;
        GC.Collect();

        int liczba1, liczba2 = 30, liczba3 = 0;
        
        //liczba1 = 30 / 0; //dzielenie przez stala wynoszaca 0
        try
        {
            liczba1 = liczba2 / liczba3;
        }
        catch(Exception e)
        {
            Console.WriteLine("Dzielenie przez 0!");
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("FIANALLY!");
        }

        int[] table = new int[2];
        try
        {
            table[25] = 5;            
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("Index poza zakresem!");          
        }

        Console.WriteLine("Zadanie 1 Kalkulator:");
        //Obliczenia.Start();

        Console.WriteLine("Zadanie 2 nowy wyjatek sprawdzajacy, czy w nazwisku sa tylko litery:");
        Pracownik nowyPracownik;

        try
        {
            nowyPracownik = new Pracownik();
            nowyPracownik.nazwisko = "abc123";

            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(nowyPracownik.nazwisko))
                throw new PracownikException(nowyPracownik.nazwisko);
            else 
                Console.WriteLine("OK!");
        }
        catch(PracownikException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}