using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Trojkat : Figura2
{
    public Trojkat(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override void ObliczPole()
    {
        Console.WriteLine("Pole trójkata: {0}", (a + b + c) / 2);
    }
}