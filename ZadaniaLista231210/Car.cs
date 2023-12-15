using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Car
{
    private double pojemnoscSilnika;
    private string marka;
    private static int iloscKol;

    public Car(double pojemnoscSilnika, string marka)
    {
        this.pojemnoscSilnika = pojemnoscSilnika;
        this.marka = marka;
    }
    public Car()
    {
        pojemnoscSilnika = 10.5;
        marka = "BMW";
    }
    static Car()
    {
        iloscKol = 4;
    }
    ~Car()
    {
        //MessageBox.Show("Zwalniam pamiec");
    }
    public Car Create()
    {
        Car retCar = new Car();
        return retCar;
    }

    public void show()
    {
        Console.WriteLine("Pojemnosc silnika: {0}\n" +
            "Marka: {1}\n" +
            "Ile kol: {2}", pojemnoscSilnika, marka, iloscKol);
    }
}
