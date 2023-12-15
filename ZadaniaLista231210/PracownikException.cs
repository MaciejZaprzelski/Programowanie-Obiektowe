using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class PracownikException : Exception
{
    public PracownikException() { }

    public PracownikException(string nazwisko) : base(String.Format("Niepoprawne nazwisko {0}", nazwisko))
    {

    }
}
