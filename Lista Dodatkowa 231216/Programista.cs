using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Programista : Pracownik
{
    //public void Pracuj()
    //public new void Pracuj()
    
    public override void Pracuj()
    {
        base.Pracuj();
        Console.WriteLine("Obowiązki programisty");        
    }
    
}
