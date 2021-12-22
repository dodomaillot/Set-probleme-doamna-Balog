using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Set_probleme_doamna_balog
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            
            while(n!=0)
            {
                
                Console.WriteLine("Care problema doriti sa faceti ? (introduceti 0 pentru a opri programul)");
                Console.Write("Problema #: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Problema1();
                        break;

                    case 2:
                        Problema2();
                        break;

                    case 3:
                        Problema3();
                        break;

                    case 4:
                        Problema4();
                        break;

                    case 5:
                        Problema5();
                        break;

                    case 6:
                        Problema6();
                        break;

                    case 7:
                        Problema7();
                        break;

                    case 8:
                        Problema8();
                        break;
                    
                    case 9:
                        Problema9();
                        break;

                    case 10:
                        Problema10();
                        break;
                    
                    case 11:
                        Problema11();
                        break;
                    
                    case 12:
                        Problema12();
                        break;
                    
                    case 13:
                        Problema13();
                        break;
                        
                    case 14:
                        Problema14();
                        break;
                        
                    case 15:
                        Problema15();
                        break;
                        
                    case 16:
                        Problema16();
                        break;
                        
                    case 17:
                        Problema17();
                        break;
                        
                    case 18:
                        Problema18();
                        break;
                        /*
                    case 19:
                        Problema19();
                        break;
                        */
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static void Problema1()
        {
            double n;
            string grade;
            bool scriscorect = false;
            Console.WriteLine("Transformati din grade celsius in grade fahrenheit sau invers.");
            Console.Write("In ce grade va fi urmatoarea valoare: celsius sau fahrenheit ? ");
            grade = Console.ReadLine();
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            switch(grade)
            {
                case "celsius":
                    n = (n - 32) / 1.8;
                    scriscorect = true;
                    break;

                case "fahrenheit":
                    n = n * 1.8 + 32;
                    scriscorect = true;
                    break;
            }
            if (scriscorect)
                Console.Write(Math.Round(n, 2));
            else
                Console.Write("N-ati scris corect gradul dorit");
        }

        private static void Problema2()
        {
            int n;
            double op;
            string operatia;
            Console.WriteLine("Executarea unei operatie. Scrieti cuvantul operatorului dorit sau operatorul direct");
            Console.Write("Care operatie doriti: adunare(+), scadere(-), inmultire(*), impartire(/), radical(^) sau modul(||) ? ");
            operatia = Console.ReadLine();

            switch (operatia)
            {
                case "adunare":
                case "+":
                    n = int.Parse(Console.ReadLine());
                    n = n + int.Parse(Console.ReadLine());
                    Console.Write(n);
                    break;

                case "scadere":
                case "-":
                    n = int.Parse(Console.ReadLine());
                    n = n - int.Parse(Console.ReadLine());
                    Console.Write(n);
                    break;

                case "inmultire":
                case "*":
                    n = int.Parse(Console.ReadLine());
                    n = int.Parse(Console.ReadLine()) * n;
                    Console.Write(n);
                    break;

                case "impartire":
                case "/":
                    op = int.Parse(Console.ReadLine());
                    op = op / int.Parse(Console.ReadLine());
                    Console.Write(Math.Round(op, 2));
                    break;

                case "radical":
                case "^":
                    op = int.Parse(Console.ReadLine());
                    op = Math.Sqrt(op);
                    Console.Write(Math.Round(op, 2));
                    break;

                case "modul":
                case "||":
                    op = int.Parse(Console.ReadLine());
                    if (op < 0)
                        Console.Write(Math.Round(op - op * 2, 2));
                    else
                        Console.Write(Math.Round(op, 2));
                    break;
            }
        }

        private static void Problema3()
        {
            int i, j, k, pow;
            Console.WriteLine("Sa se determine restul impartirii numarului natural i^j la k");
            Console.Write("i = "); i = int.Parse(Console.ReadLine());
            Console.Write("j = "); j = int.Parse(Console.ReadLine());
            Console.Write("k = "); k = int.Parse(Console.ReadLine());

            pow = (int)Math.Pow(i, j);
            Console.Write(pow % k);
        }

        private static void Problema4()
        {
            int n, sum = 0;
            Console.WriteLine("Se verifica daca un numar este perfect. Este perfect daca este egal cu suma divizorilor lui diferiti de n(ex: 6=1+2+3)");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                    sum+=i;
            }
            if (sum == n)
                Console.Write(n + " este un numar perfect");
            else
                Console.Write(n + " nu este un numar perfect");
        }

        private static void Problema5()
        {
            int a, b, sumdiv = 0, sumtotperf = 0;
            Console.WriteLine("Se verifica cate numere dintr un interval [a,b] sunt perfect.");
            Console.WriteLine("Este perfect daca este egal cu suma divizorilor lui diferiti de n(ex: 6=1+2+3)");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i/2; j++)
                {
                    if (i % j == 0)
                        sumdiv += j;
                }
                if (sumdiv == i)
                    sumtotperf++; 
                sumdiv = 0;
            }
            if (sumtotperf != 1)
                Console.Write($"Sunt {sumtotperf} numere perfecte in intervalul [{a},{b}]");
            else
                Console.Write($"Este un singur numar perfect in intervalul [{a},{b}]");
        }

        private static void Problema6()
        {
            int a, b, sum_a = 0, sum_b = 0, sum_prieteni = 0;
            Console.WriteLine("Se verifica cate numere sunt \"prietene\" intr-un interval [a,b].");
            Console.WriteLine("Doua numere sunt \"prietene\" daca suma divizorilor numerelor sunt egale. Divizor diferiti de numarul insine");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b-1; i++)
            {
                for(int n = 1; n <= i/2; n++)
                {
                    if (i % n == 0)
                        sum_a += i;
                }
                for (int j = a+1; j <= b; j++)
                {
                    for (int m = 1; m <= j/2; m++)
                    {
                        if (i % m == 0)
                            sum_b += i;
                    }
                    if (sum_a == sum_b)
                        sum_prieteni++;
                    sum_b = 0;
                }
                sum_a = 0;
            }
            Console.Write($"Sunt/este {sum_prieteni} numere \"prietene\" in intervalul [{a},{b}]");
        }

        private static void Problema7()
        {
            int n, k, i, n_fact = 1, k_fact = 1, nmink = 1, nrcomb = 0;
            Console.WriteLine("Calculati numarul combinatiilor de n luate cate k.");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.Write("k = "); k = int.Parse(Console.ReadLine());

            if (n >= k && k > 0)
            {
                for (i = 1; i <= n; i++)
                    n_fact *= i;
                for (i = 1; i <= k; i++)
                    k_fact *= i;
                for (i = 1; i <= n - k; i++)
                    nmink *= i;
                nrcomb = n_fact /(k_fact * nmink);
                Console.Write(nrcomb);
            }
            else
                Console.Write("Numerele introduse nu sunt corecte.");
        }

        private static void Problema8()
        {
            int a, aritm = 0, sumdiv = 0;
            double armo = 0, geo = 1;
            Console.WriteLine("Calculati media aritmetica, geometrica si armonica a divizorilor unui numar a.");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            for(int i = 1; i<=a;i++)
            {
                if(a%i==0)
                {
                    aritm += i;
                    geo *= i;
                    armo += 1 / (double)i;
                    sumdiv++;
                }
                Console.WriteLine(aritm + " " + geo + " " + armo);
            }
            aritm /= sumdiv;
            geo = Math.Pow(geo, 1 / (double)sumdiv);
            armo = (double)sumdiv / armo;
            Console.WriteLine("Media aritmetica = " + aritm);
            Console.WriteLine("Media  gemometrica = " + Math.Round(geo, 2));
            Console.Write("Media armonica = " + Math.Round(armo,2));
        }

        private static void Problema9()
        {
            int a, b, cmmdc, a2, b2;
            Console.WriteLine("Cel mai mare divisor comun si cel mai mic multiplu comun pentru doua numere intregi a and b");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());

            if (a < b)
                (a, b) = (b, a);
            a2 = a;
            b2 = b;
            cmmdc = a % b;
            a = b;
            b = cmmdc;
            while (cmmdc != 0)
            {
                cmmdc = a % b;
                a = b;
                b = cmmdc;
            }
            Console.Write("cmmdc = " + a + "; cmmmc = " + a2 * b2 / a);
        }

        private static void Problema10()
        {
            int n, nr = 2;
            List<int> nrprim = new List<int>();
            bool prim = true;
            Console.WriteLine("Sa se afiseze primele n numere prime");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            if (n >= 1)
            {
                Console.Write(2 + " ");
                n--;
                nr++;
            }
            while(n != 0)
            {
                for (int i = 2; i <= nr / 2; i++)
                {
                    if (nr % i == 0)
                        prim = false;
                }
                if (prim == true)
                {
                    nrprim.Add(nr);
                    n--;
                }
                prim = true;
                nr++;
            }
            Console.Write(string.Join(" ", nrprim));
        }

        private static void Problema11()
        {
            int a, b, cmmdc;
            Console.WriteLine("Sa se verifice daca doua numere intregi a and b sunt prime intre ele");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            if (a < b)
                (a, b) = (b, a);
            cmmdc = a % b;
            a = b;
            b = cmmdc;
            while (cmmdc != 0)
            {
                cmmdc = a % b;
                a = b;
                b = cmmdc;
            }
            if (a == 1)
                Console.Write("Sunt prime intre ele");
            else
                Console.Write("Nu sunt prime intre ele");
        }

        private static void Problema12()
        {
            double celsius;
            Console.WriteLine("Afisarea unui tabel de temperatura Fahrenheit-Celsius");
            Console.WriteLine("Fahrenheit           Celsius");
            
            for(int i = 0; i<=300;i++)
            {
                celsius = Math.Round(((double)5 / 9),2)*(i-32);
                Console.WriteLine($"    {i}°F                    {Math.Round(celsius,2)}°C");
            }
        }

        private static void Problema13()
        {
            double Fahrenheit;
            Console.WriteLine("Afisarea unui tabel de temperatura Celsius-Fahrenheit");
            Console.WriteLine("Celsius           Fahrenheit");

            for (int i = 0; i <= 300; i++)
            {
                Fahrenheit = i*1.8 + 32;
                Console.WriteLine($"  {i}°C              {Math.Round(Fahrenheit, 2)}°F");
            }
        }

        private static void Problema14()
        {
            int min, max, n;
            Console.WriteLine("Se citeste mai multe nr intregi n pana la intalnirea lui 0. Sa se determine cel mai mic si cel mai mare nr citit");
            n = int.Parse(Console.ReadLine());
            min = max = n;
            while(n!=0)
            {
                n = int.Parse(Console.ReadLine());
                if (n > max && n != 0)
                    max = n;
                else if (n < min && n != 0)
                    min = n;
            }
            Console.Write($"Cel mai mare este {max} si cel mai mic este {min}");
        }

        private static void Problema15()
        {
            int n, sum = 1;
            Console.WriteLine("Calculati factorialul unui numar intreg n");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
                sum *= i;
            Console.Write("Factorialul lui " + n + " este egal cu " + sum);
        }

        private static void Problema16()
        {
            int n, r;
            Console.WriteLine("O carte are n foi si r randuri pe o pagina. Cate randuri are cartea ?");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.Write("r = "); r = int.Parse(Console.ReadLine());
            Console.Write(n * 2 * r);
        }

        private static void Problema17()
        {

        }

        private static void Problema18()
        {
            int a, b, calc;
            Console.WriteLine("Se introduce doua valori a si b, iar apoi se alege daca se doreste sa se calculeze media aritmetica(1) sau cea geometrica(2)");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            Console.Write("Ce doriti sa calculati ? "); calc = int.Parse(Console.ReadLine());
            if (a < 0 && b < 0)
                Console.Write("eroare!");
        }
    }
}
