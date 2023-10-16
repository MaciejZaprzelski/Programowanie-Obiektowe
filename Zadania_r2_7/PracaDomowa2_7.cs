namespace Program
{
    class PracaDomowa2_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            zadanie2_1();
            zadanie2_2();
            zadanie2_3();
            zadanie2_4();
            zadanie2_5();
            zadanie2_6();
            zadanie2_7();
            zadanie2_8();
            zadanie2_9();
            zadanie2_10();

            Console.WriteLine("\nKoniec! Nacisnij jakis klawisz!");
            Console.ReadKey();
        }
        private static void zadanie2_1()
        {
            double C, F;
            Console.WriteLine("\nZadanie 2.1");
            Console.WriteLine("Podaj temperature w C: ");
            C = double.Parse(Console.ReadLine());
            F = 32.0 + 9.0 / 5.0 * C;
            Console.WriteLine("{0}C = {1}F.", C, F);
        }
        private static void zadanie2_2()
        {
            double a, b, c, delta;
            Console.WriteLine("\nZadanie 2.2");
            Console.WriteLine("Podaj a, b, c rownania kwadratowego: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            Console.WriteLine("{0}x^2 + {1}x + {2}", a, b, c);
            Console.WriteLine("Delta = {0}", delta);
        }
        private static void zadanie2_3()
        {
            double masa, wzrost, bmi;
            Console.WriteLine("\nZadanie 2.3");
            Console.WriteLine("Podaj mase(kg) i wzrost(m): ");
            masa = double.Parse(Console.ReadLine());
            wzrost = double.Parse(Console.ReadLine());
            bmi = masa / (wzrost * wzrost);
            Console.WriteLine("bmi = " + bmi);
        }
        private static void zadanie2_4()
        {
            int x = 100;
            Console.WriteLine("\nZadanie 2.4");
            Console.WriteLine(++x * 2); //101 * 2 = 202 (a)
        }
        private static void zadanie2_5()
        {
            Console.WriteLine("\nZadanie 2.5");
            int x = 2, y = 3;
            x *= y * 2; //2 * 3 * 2 = 12 (d)
            Console.WriteLine("x = " + x);
        }
        private static void zadanie2_6()
        {
            int x, y = 4;
            x = (y -= 2); //4 - 2 = 2, x = 2, y = 2
            x = y++; //x = 2, y = 3
            x = y--; //x = 3, y = 2
            Console.WriteLine("\nZadanie 2.6");
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
        private static void zadanie2_7()
        {
            int x, y = 5;
            x = ++y * 2; //6 * 2 = 12, x = 12, y = 6
            x = y++; //x = 6, y = 7
            x = y--; //x = 7, y = 6;
            Console.WriteLine("\nZadanie 2.7");
            Console.WriteLine(++y); //y = 7
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
        private static void zadanie2_8()
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);//1 && 1 = 1, x = 1, y = 1, z = 2 (a)
            Console.WriteLine("\nZadanie 2.8");
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
        }
        private static void zadanie2_9()
        {
            Console.WriteLine("\nZadanie 2.8");
            
            Console.WriteLine("a)");
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);            
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            /*
             * 1 > 1 && 4 == 4 && 2 > 0
             * F && T && T = F
             * koniunkcja przestaje byc wykonywana po napotkaniu zera, dlatego
             * zamiast y = 5, z = 1 
             * mamy
             * wynik = False, x = 2, y = 4, z = 2
             */

            Console.WriteLine("b)");
            x = 1; y = 4; z = 2;
            wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            /*
             * 1 > 1 & 4 == 4 && 2 > 0
             * F & T && T
             * Przy operatorze & warunek jest zawsze sprawdzany dla obu wyrażeń,
             * dlatego zostanie wykonane F & T ale już nie && T
             * wynik = False, x = 2, y = 5, z = 2
             */

            Console.WriteLine("c)");
            x = 1; y = 4; z = 2;
            wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            /*
             * 1 > 1 & 4 == 4 && 2 > 0
             * F & T & T
             * Stosujac operator & zostanie wykone kazde wyrazenie
             * wynik = False, x = 2, y = 5, z = 1
             */
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            Console.WriteLine("d)");
            x = 1; y = 3; z = 4;
            wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            /*
             * T || T || T
             * Wykonane zostanie tylko wyrazenie x == 1, poniewaz alternatywa
             * jest prawdziwa gdy jest w niej przynajmniej jedna jedynka
             * wynik = True, x = 1, y = 3, z = 4
             */

            Console.WriteLine("e)");
            x = 1; y = 3; z = 4;
            wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            /*
             * T | T || T
             * Operator | wymusza sprawdzenie obu wyrazen, analogicznie do &.
             * wynik = True, x = 1, y = 4, z = 4
             */

            Console.WriteLine("f)");
            x = 1; y = 3; z = 4;
            wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            /*
             * T | T | T
             * Zostana sprawdzone wszystkie wyrazenia
             * wynik = True, x = 1, y = 4, z = 5
             */
        }
        private static void zadanie2_10()
        {
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / powierzchnia;
            Console.WriteLine("\nZadanie2_10");
            Console.WriteLine(gestoscZaludnienia);
            /*
             * 10 / 100 = 0 Poniewaz operacja jest wykonywana w obszarze
             * liczb calkowitych. Aby otrzymac wynik 0,1 należy rzutowac
             * jedna z wartosci na typ zmiennopozycyjny.
             */
        }
    }
}