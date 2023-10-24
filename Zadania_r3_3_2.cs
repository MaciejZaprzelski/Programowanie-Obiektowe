namespace Zadania_r3_3_2
{
    internal class Zadania_r3_3_2
    {
        static void Main(string[] argv)
        {
            Zadanie3_1();
            Zadanie3_2();
            Zadanie3_3();
            Zadanie3_4();
            Zadanie3_5();
            Zadanie3_6();
            Zadanie3_7();
            Zadanie3_8();
            Zadanie3_9();
            Zad3_10();
            Zad3_11();
            Zad3_12();
            Zad3_13();
            Zadanie3_15();

        }
        private static void Zadanie3_1()
        {
            int rok;
            Console.WriteLine("Zadanie 3.1");
            Console.WriteLine("Podaj rok:");
            rok = int.Parse(Console.ReadLine());
            if (rok % 4 == 0)
            {
                if (rok % 100 == 0)
                {
                    if (rok % 400 == 0)
                        Console.WriteLine("Rok {0} jest przestepny!", rok);
                    else
                        Console.WriteLine("Rok {0} NIE jest przestepny!", rok);
                }
                else
                {
                    Console.WriteLine("Rok {0} jest przestepny!", rok);
                }
            }
            else
                Console.WriteLine("Rok {0} NIE jest przestepny!", rok);
            /*
             * Przykladowe dane:
             * 1900 nie jest
             * 2000 jest
             * 2004 jest
             * 2022 nie jest
             */
        }
        private static void Zadanie3_2()
        {
            int a, b;
            Console.WriteLine("\nZadanie 3.2");
            Console.WriteLine("Podaj dwie liczby (int):");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a % b == 0)
                Console.WriteLine("{0} jest dzielnikiem {1}", b, a);
            else
                Console.WriteLine("{0} NIE jest dzielnikiem {1}", b, a);
        }
        private static void Zadanie3_3()
        {
            int a, b, c, max, max2;
            Console.WriteLine("\nZadanie 3.3");
            Console.WriteLine("Podaj trzy liczby (int):");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            Console.WriteLine("max = " + max);
            max2 = a < b ? (b < c ? c : b) : (a < c ? c : a);
            Console.WriteLine("max2 = " + max2);
        }
        private static void Zadanie3_4()
        {
            double a, b, wynik;
            char znak;
            Console.WriteLine("\nZadanie 3.3");
            Console.WriteLine("Podaj dwie liczby (double):");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak +, -, /, *");
            znak = char.Parse(Console.ReadLine());
            if (znak == '+')
                wynik = a + b;
            else if (znak == '-')
                wynik = a - b;
            else if (znak == '*')
                wynik = a * b;
            else if (znak == '/')
                wynik = a / b;
            else
                wynik = a + b;
            Console.WriteLine("{0} {1} {2} = {3}", a, znak, b, wynik);
        }
        private static void Zadanie3_5()
        {
            double a, b, c, delta, x1, x2;
            Console.WriteLine("\nZadanie 3.5");
            Console.WriteLine("Podaj trzy wartosci trojmianu kwadratowego (double):");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;
            if(delta == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine("Jeden pierwiastek {0}", x1);
            }
            else if(delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Dwa pierwiastki {0} i {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Brak pierwiastkow!");
            }
            /*
             * Przykladowe dane:
             * 2, 4, 0 = 2 pierwiastki
             * 2, 4, 2 = 1 pierwiastek
             * 2, 4, 4 = 0 pirwiastkow
             */
        }
        private static void Zadanie3_6()
        {
            double waga, wzrost, bmi;
            Console.WriteLine("\nZadanie 3.6");
            Console.WriteLine("Podaj wage(kg) i wzrost(m):");
            
            waga = double.Parse(Console.ReadLine());
            wzrost = double.Parse(Console.ReadLine());
            bmi = waga / (wzrost * wzrost);

            if(bmi < 18.5)
            {
                Console.WriteLine("BMI = {0}, Niedowaga!", bmi);
            }
            else if(bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("BMI = {0}, Waga prawidlowa!", bmi);
            }
            else
            {
                Console.WriteLine("BMI = {0}, Nadwaga!", bmi);
            }
        }
        private static void Zadanie3_7()
        {
            string n;
            Console.WriteLine("\nZadanie 3.7");
            Console.WriteLine("Podaj dzien tygodnia (od 1 do 7)");
            n = Console.ReadLine();

            switch(n)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Wartosc poza zakresem!");
                    break;
            }

        }
       private static void Zadanie3_8()
        {
            double average;
            Console.WriteLine("\nZadanie 3.8");
            Console.WriteLine("Podaj srednia ocen:");
            average = double.Parse(Console.ReadLine());
            if (average >= 2.0 && average < 4.0)
                Console.WriteLine("Brak stypendium");
            else if (average >= 4.0 && average < 4.8)
                Console.WriteLine("Stypendium wynosi 350,00 zl");
            else if (average >= 4.8 && average <= 5.0)
                Console.WriteLine("Stypendium wynosi 550,00 zl");
            else
                Console.WriteLine("Blad!");
        }
        private static void Zadanie3_9()
        {
            int n;
            Console.WriteLine("\nZadanie 3.9");
            Console.WriteLine("Podaj ilosc wierszy (int):");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("(a)");
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("(b)");
            for(int i = n; i >= 1; i--)
            {
                for(int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("(c)");
            for(int i = 1; i <= n; i++)
            {
                //puste
                for(int j = n - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                //gwiazdki
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("(c2)");
            for(int i = n; i >= 1; i--)
            {
                for(int j = n - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for(int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("(d)");
            for(int i = 1; i <= n; i++)
            {
                //podstawy
                if (i == 1 || i == n)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                //boki
                else
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j == 1)
                            Console.Write("*");
                        else if (j == n)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
            }
        }

        private static void Zad3_10()
        {
            int liczba, silnia = 1;
            Console.WriteLine("\nZadanie 3_10");
            Console.WriteLine("n!, podaj liczbe (int):");
            liczba = int.Parse(Console.ReadLine());

            if (liczba == 0)
                Console.WriteLine("{0}! = {1}", liczba, silnia);
            else if (liczba > 0)
            {
                for (int i = 1; i <= liczba; i++)
                {
                    silnia *= i;
                }
                Console.WriteLine("{0}! = {1}", liczba, silnia);
            }
            else
                Console.WriteLine("Silnie nie moze byc ujemna!");

        }
        private static void Zad3_11()
        {
            int ile, suma;
            ile = suma = 0;
            Console.WriteLine("\nZadanie 3_11");
            for (int i = 1; suma <= 100; i++)
            {
                suma += i;
                ile++;
                //Console.Write("{0}, ", i);
            }
            Console.WriteLine("ile liczb = {0}, suma = {1}", ile, suma);
        }

        private static void Zad3_12()
        {
            int suma = 0, liczba;
            Console.WriteLine("\nZadanie 3_12");

            do
            {
                Console.WriteLine("Podaj liczbe calkowita, 0 konczy:");
                liczba = int.Parse(Console.ReadLine());
                suma += liczba;
            } while (liczba != 0);
            Console.WriteLine("Suma podanych liczb wynosi {0}", suma);
        }

        private static void Zad3_13()
        {
            int suma, n;
            suma = 0;
            Console.WriteLine("\nZadanie 3_13");
            Console.WriteLine("Podaj n:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if(i == 1)
                {
                    Console.WriteLine("{0} ", i);
                    suma += i;
                }
                else if (i % 2 == 1)
                {
                    suma += i;
                    Console.WriteLine("+{0}, {1}", i, suma);
                }                    
                else
                {
                    suma -= i;
                    Console.WriteLine("-{0}, {1}", i, suma);
                }                    
            }
            Console.WriteLine("suma = {0}", suma);

        }
        private static void Zadanie3_15()
        {
            int ileRazy = 0;
            Console.WriteLine("\nZadanie 3.15");
            for(int m5 = 0; m5 <= 2; m5++)
            {
                for(int m2 = 0; m2 <= 5; m2++)
                {
                    for(int m1 = 0; m1 <= 10; m1++)
                    {
                        if((5 * m5 + 2 * m2 + m1) == 10)
                        {
                            Console.WriteLine("{0}: 5zl * {1}, 2zl * {2}, 1zl * {3}", 
                                ++ileRazy, m5, m2, m1);
                        }
                    }
                }
            }
        }
    }
}
