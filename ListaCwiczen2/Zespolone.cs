using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ListaCwiczen2
{
    internal class Zespolone
    {
        private Complex zesp1;
        private Complex zesp2;

        public Zespolone(double x1, double y1, double x2, double y2)
        {
            zesp1 = new Complex(x1, y1);
            zesp2 = new Complex(x2, y2);
        }
        public void dzialania()
        {
            Console.WriteLine("{0} + {1} = {2:0.00}", zesp1, zesp2,
                                          zesp1 + zesp2);
            Console.WriteLine("{0} - {1} = {2:0.00}", zesp1, zesp2,
                                                zesp1 - zesp2);
            Console.WriteLine("{0} * {1} = {2:0.00}", zesp1, zesp2,
                                                zesp1 * zesp2);
            Console.WriteLine("{0} / {1} = {2:0.00}", zesp1, zesp2,
                                                zesp1 / zesp2);
        }
    }
}
