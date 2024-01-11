using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trujkont : Figura
{
    public override void Pole()
    {
        Console.WriteLine("Pole trójkąta wynosi {0}", (a + b + c) / 2);
    }
}
