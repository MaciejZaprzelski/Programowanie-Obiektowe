using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractStorm
{
    public class A
    {
        public void FunkcjaZwykla() { Console.WriteLine("A FunkcjaZwykla()"); }
        public virtual void FunkcjaWirtualna() { Console.WriteLine("A FunkcjaWirtualna()"); FunkcjaWirtualna2(); }
        public virtual void FunkcjaWirtualna2() { Console.WriteLine("A FunkcjaWirtualna2()"); }
    }

    public class B : A
    {
        public void FunkcjaZwykla() { Console.WriteLine("B FunkcjaZwykla()"); }
        public virtual void FunkcjaWirtualna() { Console.WriteLine("B FunkcjaWirtualna()"); }
        public override void FunkcjaWirtualna2() { Console.WriteLine("B FunkcjaWirtualna2()"); }
    }

    public class C : B
    {
        public override void FunkcjaWirtualna() { Console.WriteLine("C FunkcjaWirtualna()"); }
    }

    public class D : C
    {
        public void FunkcjaZwykla() { Console.WriteLine("D FunkcjaZwykla()"); }
        public override void FunkcjaWirtualna() { Console.WriteLine("D FunkcjaWirtualna()"); }
        public override void FunkcjaWirtualna2() { Console.WriteLine("D FunkcjaWirtualna2()"); }
    }

    public abstract class E : D
    {
        public virtual void FunkcjaWirtualna() { Console.WriteLine("E FunkcjaWirtualna()"); }
        public abstract void FunkcjaWirtualna2();
    }

    public class F : E
    {
        public override void FunkcjaWirtualna() { Console.WriteLine("F FunkcjaWirtualna()"); }
        public override void FunkcjaWirtualna2() { Console.WriteLine("F FunkcjaWirtualna2()"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a)");
            A tempa = new B();
            tempa.FunkcjaWirtualna();
            /* 
             * A FunkcjaWirtualna()
             * B FunkcjaWirtualna2()
            */

            Console.WriteLine("b)");
            A tempb = new D();
            tempb.FunkcjaWirtualna();
            /*
             * A FunkcjaWirtualna()
             * D FunkcjaWirtualna2()
            */

            Console.WriteLine("c)");
            C tempc = new F();
            tempc.FunkcjaWirtualna();
            //tempc.NormalnaFunkcja(); //Brak tej funkcji w klasie C
            /*
             * D FunkcjaWirtualna()
            */

            Console.WriteLine("d)");
            D tempd = new F();
            tempd.FunkcjaWirtualna();
            //tempd.NormalnaFunkcja(); //Brak tej funkcji w klasie D
            /*
             * D FunkcjaWirtualna()
            */

            Console.ReadKey();
        }
    }
}
