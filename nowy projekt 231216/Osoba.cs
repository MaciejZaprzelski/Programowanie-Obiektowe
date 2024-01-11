using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface iGitarzysta
{
    void Graj();
}
interface iSkrzypek
{
    void Graj();
}
internal class Osoba : iGitarzysta, iSkrzypek
{
    public void Graj()
    {
        Console.WriteLine("Gram ale nie wiem na czym");
    }
    void iGitarzysta.Graj()
    {
        Console.WriteLine("Gram na gitarze");
    }
    void iSkrzypek.Graj()
    {
        Console.WriteLine("Gram na skrzypcach");
    }
}
