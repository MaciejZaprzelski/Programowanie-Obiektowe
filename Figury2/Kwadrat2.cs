using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Kwadrat2 : Figura2
{
    public Kwadrat2(int a)
    {
        this.a = a;
    }
    public override void ObliczPole()
    {
        Console.WriteLine("Pole kwadratu: {0}", a * a);
    }
}
