using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Set_probleme_doamna_balog
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = 1;

            while (n!=0)
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
                    case 19:
                        Problema19();
                        break;

                    case 20:
                        Problema20();
                        break;
                    
                    case 21:
                        Problema21();
                        break;
                    
                    case 22:
                        Problema22();
                        break;
                    
                    case 23:
                        Problema23();
                        break;
                    
                    case 24:
                        Problema24();
                        break;
                    
                    case 25:
                        Problema25();
                        break;
                    
                    case 26:
                        Problema26();
                        break;
                    
                    case 27:
                        Problema27();
                        break;
                    
                    case 28:
                        Problema28();
                        break;
                    
                    case 29:
                        Problema29();
                        break;
                    
                    case 30:
                        Problema30();
                        break;
                    
                    case 31:
                        Problema31();
                        break;
                    
                    case 32:
                        Problema32();
                        break;
                    
                    case 33:
                        Problema33();
                        break;
                    
                    case 34:
                        Problema34();
                        break;
                    
                    case 35:
                        Problema35();
                        break;
                    
                    case 36:
                        Problema36();
                        break;
                    
                    case 37:
                        Problema37();
                        break;
                    
                    case 38:
                        Problema38();
                        break;
                    
                    case 39:
                        Problema39();
                        break;
                    
                    case 40:
                        Problema40();
                        break;
                    
                    case 41:
                        Problema41();
                        break;

                    case 42:
                        Problema42();
                        break;
                    
                    case 43:
                        Problema43();
                        break;

                    case 44:
                        Problema44();
                        break;
                        
                    case 45:
                        Problema45();
                        break;
                    
                    case 46:
                        Problema46();
                        break;
                    
                    case 47:
                        Problema47();
                        break;
                    
                    case 48:
                        Problema48();
                        break;
                    
                    case 49:
                        Problema49();
                        break;
                    
                    case 50:
                        Problema50();
                        break;
                    
                    case 51:
                        Problema51();
                        break;
                    
                    case 52:
                        Problema52();
                        break;
                    
                    case 53:
                        Problema53();
                        break;
                    
                    case 54:
                        Problema54();
                        break;
                        
                    case 55:
                        Problema55();
                        break;
                    
                    case 56:
                        Problema56();
                        break;
                    
                    case 57:
                        Problema57();
                        break;
                    
                    case 58:
                        Problema58();
                        break;
                        
                    case 59:
                        Problema59();
                        break;
                    
                    case 60:
                        Problema60();
                        break;
                    
                    case 61:
                        Problema61();
                        break;
                    
                    case 62:
                        Problema62();
                        break;
                   
                   case 63:
                       Problema63();
                       break;
                   
                   case 64:
                       Problema64();
                       break;
                   
                   case 65:
                       Problema65();
                       break;
                   
                   case 66:
                       Problema66();
                       break;
                   
                   case 67:
                       Problema67();
                       break;
                   
                   case 68:
                       Problema68();
                       break;
                   
                   case 69:
                       Problema69();
                       break;

                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }

        #region Programe cu numere si secvente

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
            int x, t;

            Console.WriteLine("Sa se calculeze viteza v de miscare a punctului material, la momentul t aflandu se la distanta x fata de origine");
            Console.Write("t(in sec) = "); t = int.Parse(Console.ReadLine());
            Console.Write("x(in m) = "); x = int.Parse(Console.ReadLine());

            Console.Write($"Viteza punctului material la momentul t este de: {x/t} m/s");
            //distance sur temps
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
            else if (calc != 1 && calc != 2)
                SystemSounds.Asterisk.Play();
            else if (calc == 1)
                Console.Write($"Media aritmetica este egala cu {(a + b) / 2}");
            else if (calc == 2)
                Console.Write($"Media geometrica este egala cu {Math.Round(Math.Pow(a * b, 1 / (double)2), 2)}");
        }

        private static void Problema19()
        {
            int a, b, c;
            string calc;

            Console.WriteLine("Dati trei numere a, b si c(laturi unui triunghi). Sa se calculeze aria sau perimetrul.");
            Console.Write("Doriti sa calculati aria sau perimetrul ? "); calc = Console.ReadLine();
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            Console.Write("c = "); c = int.Parse(Console.ReadLine());


            if (calc == "aria")
                Console.Write("aria este egala cu " + Math.Round(Math.Sqrt(((a + b + c) / 2) * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)), 2));
            else if (calc == "perimetrul")
                Console.Write("perimetrul este egal cu " + (a + b + c));
            else
                Console.Write("Nu ati scris corect cuvantul");
        }

        private static void Problema20()
        {
            int n, nr = 0;
            double aritm = 0;
            
            Console.WriteLine("Sa se calculeze media aritmetica dintr un sir. Sirul dureaza pana la intalnirea lui 0");
            n = int.Parse(Console.ReadLine());
            
            while(n != 0)
            {
                aritm += (double)n; nr++;
                n = int.Parse(Console.ReadLine());
            }
            aritm /= (double)nr;
            
            Console.Write("Media aritmetica a sirului este egal cu " + Math.Round(aritm,2));
        }

        private static void Problema21()
        {
            int n, p, k, sum = 0, nb;
            
            Console.WriteLine("Cate dintre cele n numere din sir impartite la p dau retul k");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.Write("p = "); p = int.Parse(Console.ReadLine());
            Console.Write("k = "); k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                nb = int.Parse(Console.ReadLine());
                if (nb % p == k)
                    sum++;
            }
            
            Console.Write($"Sunt/ este {sum} numere/numar din sir care impartit(e) la {p} dau restul {k}");
        }

        private static void Problema22()
        {
            int n1, n2, sum = 0;
            
            Console.WriteLine("Sa se calculeze produsul a doua numere n1 si n2 prin adunari repetate");
            Console.Write("n1 = "); n1 = int.Parse(Console.ReadLine());
            Console.Write("n2 = "); n2 = int.Parse(Console.ReadLine());
            
            if (n1 < n2)
                for (int i = 0; i < n1; i++)
                    sum += n2;
            else
                for (int i = 0; i < n2; i++)
                    sum += n1;
            
            Console.Write($"Produsul numerelor {n1} si {n2} este egal cu {sum}");
        }

        private static void Problema23()
        {
            int n1, n2, sum = 0, rem;
            
            Console.WriteLine("Sa se efectueze impartirea numarului n1 la numarul n2 prin scaderi repetate");
            Console.Write("n1 = "); n1 = int.Parse(Console.ReadLine());
            Console.Write("n2 = "); n2 = int.Parse(Console.ReadLine());
            rem = n1;

            while(n1 >= n2)
            {
                n1 -= n2;
                sum++;
            }

            Console.Write($"Rezultatul inmultirii este egal cu {sum}");
        }

        private static void Problema24()
        {
            int n, sum = 0, rem;

            Console.WriteLine("Cate cifre contine numarul natural n");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            rem = n;

            while(n != 0)
            {
                sum++;
                n /= 10;
            }

            if (rem > 9 || rem < -9)
                Console.Write($"Numarul {rem} contine {sum} cifre");
            else
                Console.Write("Ati citit un cifru");
        }

        private static void Problema25()
        {
            int n, firstn, inv = 0;

            Console.WriteLine("Sa se verifice daca un numar este palindrom(daca citi invers este acelas numar)");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            firstn = n;

            while(n != 0)
            {
                inv = inv * 10 + n % 10;
                n /= 10;
            }

            if (firstn == inv)
                Console.Write(firstn + " este un numar palindrom");
            else
                Console.Write(firstn + " nu este un numar palindrom");
        }

        private static void Problema26()
        {
            int m;
            bool prim = true;

            Console.WriteLine("Sa se afiseze toate numerele prime mai mici sau egale cu un numar m");
            Console.Write("m = "); m = int.Parse(Console.ReadLine());
            
            for(int i = 2; i <= m; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                        prim = false;
                if (prim == true)
                    Console.Write(i + " ");
                prim = true;
            }
        }

        private static void Problema27()
        {
            int n, m, nr = 2, test, sum = 0;
            bool prim = true;

            Console.WriteLine("Sa se afiseze primele n numere prime care au suma cifrelor < || = cu m");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.Write("m = "); m = int.Parse(Console.ReadLine());

            while(n != 0)
            {
                for (int i = 2; i <= nr / 2; i++)
                    if (nr % i == 0)
                        prim = false;
                test = nr;
                if(prim == true)
                {
                    while (test != 0)
                    {
                        sum += test % 10;
                        test /= 10;
                    }
                    if (sum <= m)
                    {
                        Console.Write(nr + " "); 
                        n--;
                    }
                    sum = 0;
                    
                }
                prim = true;
                nr++;
            }
                
        }

        private static void Problema28()
        {
            int inv = 0, nr;
            bool prim = true;

            Console.WriteLine("Sa se afiseze toate numerele de 3 cifre care, citite inverse, sunt tot numere prime");
            
            for(int i = 100; i < 1000; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                        prim = false;
                if(prim == true)
                {
                    nr = i;
                    while(nr != 0)
                    {
                        inv = inv * 10 + nr % 10;
                        nr /= 10;
                    }
                    for (int d = 2; d <= inv / 2; d++)
                        if (inv % d == 0)
                            prim = false;
                    if (prim == true)
                        Console.Write(i + " ");
                    inv = 0;
                }
                prim = true;
            }
        }

        private static void Problema29()
        {
            int n, sum = 0, rep;

            Console.WriteLine("Sa se listeze toate numerele < || = decat n, a caror suma a cifrelor este divizibila cu 5");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            for(int i = 5; i <= n; i++)
            {
                rep = i;
                while(rep != 0)
                {
                    sum += rep % 10;
                    rep /= 10;
                }
                if (sum % 5 == 0)
                    Console.Write(i + " ");
                sum = 0;
            }
        }

        private static void Problema30()
        {
            string nbvoulu = string.Empty, nbdonnee;
            int basevoulu, sau;

            Console.WriteLine("Sa se transforme un numar din baza 10 in baza p<10 sau sa se transforme din baza p<10 in baza 10");
            Console.Write("Scrieti 1 daca vreti din baza 10 sau 2 daca vreti din baza p: "); sau = int.Parse(Console.ReadLine());
            Console.Write("p = "); basevoulu = int.Parse(Console.ReadLine()); 
            Console.Write("dati numarul ce trebe transformat: "); nbdonnee = Console.ReadLine();

            int rest = 0, sosie = Convert.ToInt32(nbdonnee);

            if (sau == 1 && basevoulu < 10)
            {
                while (sosie != 0)
                {
                    rest = sosie % basevoulu;
                    sosie /= basevoulu;


                    if (rest >= 10)
                    {
                        for (char alf = 'A'; alf <= 'F'; alf++)
                            if (alf == rest + 55)
                            {
                                nbvoulu = alf.ToString() + nbvoulu;
                                break;
                            }
                    }
                    else
                        nbvoulu = rest.ToString() + nbvoulu;
                }
                Console.Write("Rezultatul final: " + nbvoulu);
            }
            else if (sau == 2 && basevoulu < 10)
            {
                int puissance = basevoulu, sep;
                sep = Convert.ToInt32((nbdonnee[nbdonnee.Length - 1]).ToString());

                for (int index = nbdonnee.Length - 2; index >= 0; index--)
                {
                    sep += Convert.ToInt32(nbdonnee.Substring(index, 1)) * puissance;
                    puissance *= basevoulu;
                }
                nbvoulu = sep.ToString();
                Console.Write("Rezultatul final: " + nbvoulu);
            }
            else
                Console.Write("baza data este mai mare decat 10 sau nu ati introdus 1 sau 2 la alegere");
        }

        private static void Problema31()
        {
            int n;
            bool prim = true;

            Console.WriteLine("Sa se genereze toate numerele prime < || = decat n");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            for( int i = 2; i <= n;i++)
            {
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                        prim = false;
                if (prim == true)
                    Console.Write(i + " ");
                prim = true;
            }
        }

        private static void Problema32()
        {
            int n, m, nr = 2, test, sum = 0;
            bool prim = true;

            Console.WriteLine("Sa se afiseze primele n numere prime care au suma cifrelor mai mic sau egal decat m");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.Write("m = "); m = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                for (int i = 2; i <= nr / 2; i++)
                    if (nr % i == 0)
                        prim = false;
                test = nr;
                if (prim == true)
                {
                    while (test != 0)
                    {
                        sum += test % 10;
                        test /= 10;
                    }
                    if (sum <= m)
                    {
                        Console.Write(nr + " ");
                        n--;
                    }
                    sum = 0;

                }
                prim = true;
                nr++;
            }
        }

        private static void Problema33()
        {
            int inv = 0, nr;
            bool prim = true;

            Console.WriteLine("Sa se afiseze toate numerele de 3 cifre care, citite inverse, sunt tot numere prime");

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                        prim = false;
                if (prim == true)
                {
                    nr = i;
                    while (nr != 0)
                    {
                        inv = inv * 10 + nr % 10;
                        nr /= 10;
                    }
                    for (int d = 2; d <= inv / 2; d++)
                        if (inv % d == 0)
                            prim = false;
                    if (prim == true)
                        Console.Write(i + " ");
                    inv = 0;
                }
                prim = true;
            }
        }
        #endregion

        #region Programe cu functii si tablouri

        private static void Problema34()
        {
            string degres;
            double pi = 3.1459, val = 0;

            Console.WriteLine("Transformati un unghi exprimat in radian in valoarea sa exprimat in grade, sau invers.");
            Console.Write("Unghiul va fi exprimat in grade sau radian ? ");
            degres = Console.ReadLine();

            if (degres == "grade")
            {
                Console.Write("Valoarea in grade: ");
                val = int.Parse(Console.ReadLine());
                GradeToRadian(val, pi);
            }
            else if (degres == "radian")
            {
                Console.Write("Valoarea in radian: ");
                val = Convert.ToDouble(Console.ReadLine());
                RadianToGrade(val, pi);
            }
            else
                Console.Write("Nu ati scris corect");
        }
        private static void GradeToRadian(double val, double pi)
        {
            double rad;

            rad = val * pi / 180;

            Console.Write("Valoarea in radian este " + Math.Round(rad, 4));
        }
        private static void RadianToGrade(double val, double pi)
        {
            double grad;

            grad = val * 180 / pi;

            Console.Write("Valoarea in radian este " + Math.Round(grad, 4));
        }

        private static void Problema35()
        {
            long n = 2, x = 2, k = 3;

            Console.WriteLine("Se citeste un numar de maxim 9 cifre si sa se afiseze x si k, cu proprietatea ca n = x*k");
            Console.Write("x este minim (dar diferit de 1). n = "); n = Convert.ToInt64(Console.ReadLine());

            if (n < 6)
                Console.Write("x = " + 1 + ", k = " + n);
            else
                Putere(n, x, k);

        }
        private static void Putere(long n, long x, long k)
        {
            bool found = false;
            for(long i = 2; i < n/2; i++)
            {
                for(long j = i + 1; j <= n/2; j++)
                    if(i * j == n)
                    {
                        x = i;
                        k = j;
                        found = true;
                        break;
                    }
                if(found)
                    break;
            }

            Console.Write("x = " + x + " si k = " + k);
        }

        private static void Problema36()
        {
            int x;

            Console.WriteLine("Afisati cifrele unui numar natural x in sens invers, cat si suma cifrelor");
            Console.Write("x = "); x = int.Parse(Console.ReadLine());

            Method1(x);
        }
        private static void Method1(int x)
        {
            int sum = 0, inv = 0;

            Console.Write("Cifrele numarului sunt: ");

            while (x != 0)
            {
                if (x / 10 == 0)
                    Console.Write(x % 10);
                else
                    Console.Write(x % 10 + ",");
                sum += x % 10;
                x /= 10;
            }

            Console.WriteLine();
            Console.Write("Suma cifrelor este: " + sum);
            
        }

        private static void Problema37()
        {
            int prev = 1, prevprev = 0, n, moment = 1;

            Console.WriteLine("Sa se afiseze primele n termeni din sirul fibonacci.");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            if (n == 1)
                Console.Write(prev);
            else
                for(int i = 0; i < n; i++)
                {
                    moment = prev + prevprev;
                    prevprev = prev;
                    prev = moment;
                    Console.Write(moment + " ");
                }
        }

        private static void Problema38()
        {
            int n, tot = 1;

            Console.WriteLine("Sa se calculeze factorialul unui numar intreg n");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            if(n == 0)
                tot = 0;
            for (int i = 2; i <= n; i++)
                tot *= i;

            Console.Write("Factorialul numarului " + n + " este " + tot);
        }

        private static void Problema39()
        {
            int ore1, minute1, secunde1, ore2, minute2, secunde2, difore, difmin, difsec;

            Console.WriteLine("Calculati diferenta dintre doua momente de timp, date prin ore, minute si secunde.");
            Console.Write("ora1: "); ore1=int.Parse(Console.ReadLine());
            Console.Write("minute1: ");minute1 = int.Parse(Console.ReadLine());
            Console.Write("secunde1: ");secunde1 = int.Parse(Console.ReadLine());
            Console.Write("ora2: "); ore2 = int.Parse(Console.ReadLine());
            Console.Write("minute2: "); minute2 = int.Parse(Console.ReadLine());
            Console.Write("secunde2: "); secunde2 = int.Parse(Console.ReadLine());

            if (ore1 < 24 && ore2 <24 && minute1 < 60 && minute2 < 60 && secunde1 < 60 && secunde2 < 60)
            {
                if (ore1 >= ore2)
                {
                    if (secunde1 >= secunde2)
                        difsec = secunde1 - secunde2;
                    else
                    {
                        difsec = 60 - secunde2 + secunde1;
                        minute1--;
                    }
                    
                    if(minute1 >= minute2)
                        difmin = minute1 - minute2;
                    else
                    {
                        difmin = 60 - minute2 + minute1;
                        ore1--;
                    }
                    
                    difore = ore1 - ore2;
                }
                else
                {
                    if (secunde2 >= secunde1)
                        difsec = secunde2 - secunde1;
                    else
                    {
                        difsec = 60 - secunde1 + secunde2;
                        minute2--;
                    }

                    if (minute2 >= minute1)
                        difmin = minute2 - minute1;
                    else
                    {
                        difmin = 60 - minute1 + minute2;
                        ore2--;
                    }

                    difore = ore2 - ore1;
                }
                Console.Write($"Diferenta este de {difore} ore, {difmin} min si {difsec} secunde");
            }
            else
                Console.Write("Datele introduse sunt invalide");
        }

        private static void Problema40()
        {
            double vit;

            Console.WriteLine("Transformati viteza unui automobilist(vit) exprimat in KM/H in M/S.");
            Console.Write("vit = "); vit = Convert.ToDouble(Console.ReadLine());

            vit = vit/3.6;
            Console.Write("Viteza automobistului in m/s este " + Math.Round(vit, 2));
        }

        private static void Problema41()
        {
            int n, m, zile;

            Console.WriteLine("Un muncitor lucreaza n zile pentru a termina o lucrare. Pentru o echipa de m muncitor, cat ar dura ?");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.Write("m = "); m = int.Parse(Console.ReadLine());

            zile = n / m;

            Console.Write($"Pentru o echipa de {m} muncitori, s ar lucra {zile} zile");
        }

        private static void Problema42()
        {
            int n, num = 1;
            bool perfect = false;

            Console.WriteLine("Sa se verifice daca numarul natural n este sau nu cub perfect");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            while(num * num <= n)
            {
                if(num*num == n)
                    perfect = true;
                num++;
            }
            if (perfect == true)
                Console.Write(n + " este cub perfect");
            else
                Console.Write(n + " nu este cub perfect");
        }

        private static void Problema43()
        {
            int n;

            Console.WriteLine("Sa se calculeze patratul elementelor unui tablou de n numere");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele tabloului:");

            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                vector[i] *= vector[i];
            }
            Console.Write("Patratul elementelor tabloului initial este: ");
            foreach(int i in vector)
            {
                Console.Write(i + " ");
            }
        }

        private static void Problema44()
        {
            int n;

            Console.WriteLine("Afisati tabla inmultirii unui numar n");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {n * i}");
            }
        }

        private static void Problema45()
        {
            int n;

            Console.WriteLine("Inversati elementele unui tablou de n elemente");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            
            int [] vector = new int[n];
            for(int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());
            Array.Reverse(vector);
            foreach (var i in vector)
                Console.Write(i + " ");
        }

        private static void Problema46()
        {
            int n, sozi, reverse = 0;

            Console.WriteLine("Sa se verifice daca un numar n este palindrom");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            sozi = n;

            while(n != 0)
            {
                reverse = (reverse + n % 10) * 10;
                n /= 10;
            }
            reverse /= 10;

            if (sozi == reverse)
                Console.Write("Numarul " + sozi + " este palindrom");
            else
                Console.Write("Numarul " + sozi + " nu este palindrom");
        }

        private static void Problema47()
        {
            var rand = new Random();
            int[] vector = new int[100];
            int[] vector2 = new int[100];

            Console.WriteLine("Se memoreaza 100 de numere aleatoare cuprinse intre 0 si 99 intr un tablou si sa se afiseze cele care se repeta");

            for (int i = 0; i < 100; i++)
            {
                vector[i] = rand.Next(0, 100);
                vector2[vector[i]]++;
            }

            for (int i = 0; i < 100; i++)
                if (vector2[i] > 1)
                    Console.Write(i + " ");

        }

        private static void Problema48()
        {
            int n;
            
            Console.WriteLine("Sa se adune doua matrice de dimensiune n*n");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            
            int[,] matrice1 = new int[n, n];
            int[,] matrice2 = new int[n, n];
            int[,] Produs = new int[n, n];

            Console.WriteLine("Introduceti datele primei matrice, linie dupa linie:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrice1[i,j] = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti datele a doua matrice, linie dupa linie:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrice2[i,j] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Produs[i, j] = 0;
                    for(int k = 0; k < n; k++)
                        Produs[i, j] += matrice1[i, k] * matrice2[k,j];
                }

            Console.WriteLine("Produsul a celor doua matrici este:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(Produs[i, j] + " ");
                Console.WriteLine();
            }
        }

        private static void Problema49()
        {
            int n, aritmetica = 0, sum = 0;
            
            Console.WriteLine("Sa se calculeze media aritmetica a elementelor pare dintr un vector de n numere");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            
            int[] vector = new int[n];
            for(int i = 0; i < n; ++i)
            {
                vector[i] = int.Parse(Console.ReadLine());
                if(vector[i] % 2 == 0)
                {
                    aritmetica += vector[i];
                    sum++;
                }
            }

            Console.Write($"Media aritmetica a elementelor pare este egala cu {aritmetica / sum}");

        }

        private static void Problema50()
        {
            int n;
            bool cresc = true;

            Console.WriteLine("Sa se verifice daca un vetor de n numere este ordonat crescator");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            vector[0] = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                if (vector[i] < vector[i - 1])
                    cresc = false;
            }

            if (cresc)
                Console.Write("Vectorul este ordaonat crescator");
            else
                Console.Write("Vectorul nu este oradonat crescator");
        }

        private static void Problema51()
        {
            int n;

            Console.WriteLine("Sa se afiseze minimul unui vector de n numere");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            vector[0] = int.Parse(Console.ReadLine());

            for(int i = 1;i<n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(vector);
            Console.Write("Minimul vectorului este " + vector[0]);
        }

        private static void Problema52()
        {
            int n;
            bool impare = true;

            Console.WriteLine("Sa se determine daca un vector de n numere contine numai elemente impare");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            for(int i = 0; i<n;i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                if (vector[i] % 2 == 0)
                    impare = false;
            }

            if (impare)
                Console.Write("Vectorul are numai elemente impare");
            else
                Console.Write("Vectorul nu are numai elemente impare");
        }

        private static void Problema53()
        {
            int n;
            bool pare = true;

            Console.WriteLine("Sa se determine daca un vector de n numere contine numai elemente pare");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                if (vector[i] % 2 != 0)
                    pare = false;
            }

            if (pare)
                Console.Write("Vectorul are numai elemente pare");
            else
                Console.Write("Vectorul nu are numai elemente pare");
        }

        private static void Problema54()
        {
            int n, sumpare = 0, sumimpare = 0;

            Console.WriteLine("Sa se determine raportul dintre numerele pare si impare dintr un vector de n numere");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            for(int i = 0; i < n;i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                if (vector[i] % 2 == 0)
                    sumpare += vector[i];
                else
                    sumimpare += vector[i];
            }

            Console.Write($"Raportul dintre elementle pare si impare este egal cu {sumpare}/{sumimpare} = {sumpare / sumimpare}");
        }

        private static void Problema55()
        {
            int n, e = 0;

            Console.WriteLine("Se da un vector X de n numere, sa se calculeze e unde e = x1-x2+x3+...+xn (x1 fiind primul element din vector)");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] X = new int[n];
            for(int i = 0; i < n; i++)
            {
                X[i] = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    e += X[i];
                else
                    e -= X[i];
            }

            Console.Write("e = " + e);
        }

        private static void Problema56()
        {
            int n;

            Console.WriteLine("Sa se creeze si sa se afiseze un vector v. Primele doi termeni sunt egale cu 1");
            Console.WriteLine("Fiecare din termenii urmatori este egale cu suma dintre termenul precedent si termenul anteprecedent");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            v[0] = v[1] = 1;
            if (n == 1)
                Console.Write(v[0]);
            else if (n == 2)
                Console.Write(v[0] + " " + v[1]);
            else
            {
                Console.Write(v[0] + " " + v[1] + " ");
                for (int i = 2; i < n; i++)
                {
                    v[i] = v[i - 1] + v[i - 2];
                    Console.Write(v[i] + " ");
                }
            }
        }

        private static void Problema57()
        {
            int n, poz = 0, rez = 0;
            bool exist = false;

            Console.WriteLine("Se citeste un numar n<=100(numar natural) si n numere intregi. Determinati pozitia primului element");
            Console.WriteLine("Primul element are proprietatea ca este media aritmetica dintre succesorul si predecesorul sau");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            for(int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());

            for(int i = 1; i < n - 1; i++)
                if(vector[i] == (vector[i-1]+vector[i+1])/2)
                {
                    rez = vector[i];
                    poz = i;
                    exist = true;
                    break;
                }

            if (exist)
                Console.Write($"primul element este: {rez} si se afla pe pozitia: {poz + 1} (sau {poz} daca incepem numararea de la zero)");
            else
                Console.Write("Nu exista nici un prim element");
        }

        private static void Problema58()
        {
            int n, k, poz = 0, rez = 0;
            bool exist = false;

            Console.WriteLine("Se citeste de la tastatura k(nr natural), n<=1000(nr natural) si n numere intregi. Determinati pozitia ultimului element");
            Console.WriteLine("Ultimul element are proprietatea ca este egal cu k");
            Console.Write("k = "); k = int.Parse(Console.ReadLine());
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());

            for (int i = n - 1; i >= 0; i--)
                if (vector[i] == k)
                {
                    exist = true;
                    rez = vector[i];
                    poz = i;
                    break;
                }

            if (exist)
                Console.Write($"ultimul element este: {rez} si se afla pe pozitia: {poz + 1} (sau {poz} daca incepem numararea de la zero)");
            else
                Console.Write("Nu exista nici un ultim element");
        }

        private static void Problema59()
        {
            int n, poz;

            Console.WriteLine("Se citeste poz<=n<=1000(doua numere naturale) si n numere intregi. Sa se elimine din vector elementul pe pozitia poz");
            Console.Write("poz = "); poz = int.Parse(Console.ReadLine());
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());

            vector = vector.Where(val => val != poz).ToArray();
            
            Console.WriteLine("Vectorul dupa stergerea elementului de pe pozitia poz:");
            for (int i = 0; i < n - 1; i++)
                Console.Write(vector[i] + " ");
        }

        private static void Problema60()
        {
            int n, k;

            Console.WriteLine("Se citeste k(nr intreg) n<=1000(nr natural) si n numere intregi. Sa se elimine din vector elementul egale cu k");
            Console.Write("k = "); k = int.Parse(Console.ReadLine());
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());

            for (int i = n - 1; i >= 0; i--)
                if(vector[i] == k)
                    vector = vector.Where(val => val != i).ToArray();

            Console.WriteLine("Vectorul dupa stergerea elementului de pe pozitia poz:");
            foreach(int value in vector)
                Console.Write(value + " ");
        }

        private static void Problema61()
        {
            int n, x, k;

            Console.WriteLine("Se citeste de la tastatura un numar intreg x, k <= n <= 1000, doua numere naturale si n numere intregi");
            Console.WriteLine("Sa se insereze numarul x pe pozitia k in vector");
            Console.Write("x = "); x = int.Parse(Console.ReadLine());
            Console.Write("k = "); k = int.Parse(Console.ReadLine());
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());

            int[] newvector = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
                if (i < k - 1)
                    newvector[i] = vector[i];
                else if (i == k - 1)
                    newvector[i] = x;
                else
                    newvector[i] = vector[i - 1];

            foreach (int value in newvector)
                Console.Write(value + " ");
        }

        private static void Problema62()
        {
            int n;
            
            Console.WriteLine("Se citeste un numar natural n <= 100 si cele n elemente reale ale unui vector.");
            Console.WriteLine("Sa se insereze intre oricare doua elemente ale vectorului media lor aritmetica");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            double[] vector = new double[n * 2 - 1];
            for (int i = 0; i < n * 2; i+=2)
                vector[i] = double.Parse(Console.ReadLine());

            for (int i = 1; i < n * 2 - 1; i += 2)
                vector[i] = (vector[i - 1] + vector[i + 1]) / 2;

            foreach (var value in vector)
                Console.Write(Math.Round(value, 2) + " ");
        }

        private static void Problema63()
        {
            int n, k, num = 0;

            Console.WriteLine("Sa se extraga dintr un vector de n elemente, cele care au ultima cifra egala cu k. Sa se formeze cu ele un alt vector");
            Console.Write("k = "); k = int.Parse(Console.ReadLine());
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            int[] u = new int[0];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if(v[i]%10==k)
                {
                    Array.Resize(ref u, u.Length + 1);
                    u[num] = v[i];
                    num++;
                }
            }
            Console.WriteLine("vectorul initial:");
            foreach(var value in v)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine("vectorul creat:");
            foreach (var value in u)
            {
                Console.Write(value + " ");
            }
        }

        private static void Problema64()
        {
            int n, sumimp, sumpar = 0;

            Console.WriteLine("Se da un numar natural n si n numere intregi. Folosind un alt vector, sa se aseze numerele pare la inceput");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            sumimp = n-1;
            int[] vector1 = new int[n];
            int[] vector2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector1[i] = int.Parse(Console.ReadLine());
                if (vector1[i] % 2 == 0)
                {
                    vector2[sumpar] = vector1[i];
                    sumpar++;
                }
                else
                {
                    vector2[sumimp] = vector1[i];
                    sumimp--;
                }
            }

            foreach (var value in vector2)
                Console.Write(value + " ");
        }

        #endregion

        #region Probleme cu metode de sortare

        private static void Problema65()
        {
            int n, sum = 0;
            bool exist = false;

            Console.WriteLine("Se da un sir cu n elemente, numere naturale.");
            Console.WriteLine("Sa se afiseze in ordine cresc, toate valorile distincte care se pot obtine ca suma de doua elemente distincte din sir");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] valeur = new int[n*n];
            int[] sir = new int[n];

            for (int i = 0; i < n; i++)
            {
                sir[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    for (int k = 0; k < sum; k++)
                        if (sir[i] + sir[j] == valeur[k])
                        {
                            exist = true;
                        }
                    if (exist == false)
                    {
                        Console.WriteLine(valeur[i]);
                        valeur[sum] = sir[i] + sir[j];
                        sum++;
                    }
                    exist = false;
                }
            }

            Array.Resize(ref valeur, sum);
            Array.Sort(valeur);

            for(int i = 0; i < sum; i++)
                Console.Write(valeur[i] + " ");
        }

        private static void Problema66()
        {
            int n, sum = 0;

            Console.WriteLine("CRB are un sir cu n numere naturale diferite.Nu se stie ce sa faca ce ele si le aranjeaza in ordine descrescatoare");
            Console.WriteLine("Cate elemente din sir sa afla pe aceasi pozitie ca in sirul initial");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele lui CRB:");

            int[] CRB = new int[n];
            int[] sosie = new int[n];

            for(int i = 0; i < n; i++)
                CRB[i] = int.Parse(Console.ReadLine());

            Array.Copy(CRB, sosie, n);
            Array.Sort(CRB);
            Array.Reverse(CRB);

            for (int i = 0; i < n; i++)
                if (CRB[i] == sosie[i])
                    sum++;

            Console.Write($"Sunt/este {sum} elemente care se afla pe aceasi pozitie dupa aranjarea in ordine descrescatoare");
        }

        private static void Problema67()
        {
            int n;

            Console.WriteLine("Sa se ordoneze crescator elementele din prima jumatate a unui vector de n nr, si descrescator cele din a 2-a jumatate");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] vecteur = new int[n];
            for (int i = 0; i < n; i++)
                vecteur[i] = int.Parse(Console.ReadLine());

            Array.Sort(vecteur, 0, n / 2);
            Array.Sort(vecteur, n / 2, n - n / 2);
            Array.Reverse(vecteur, n / 2, n - n / 2);

            for (int i = 0; i < n; i++)
                Console.Write(vecteur[i] + " ");
        }

        private static void Problema68()
        {
            int n, max;
            bool impar = false, doubleimp = false;

            Console.WriteLine("Sa se verifice daca prin rearanjarea elementelor unui sir de n numere naturale, se poate obtine un sir palindrom");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            int[] vecteur = new int[n];
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                vecteur[i] = int.Parse(Console.ReadLine());
                if (vecteur[i] >= n)
                    Array.Resize(ref v, vecteur[i] + 2);
                v[vecteur[i]]++;
            }

            max = vecteur.Max();
            for (int i = 0; i < max; i++)
            {
                if (!impar && v[i] % 2 != 0 && n % 2 != 0)
                {
                    impar = true;
                }
                else if(impar && v[i] % 2 != 0 || !impar && v[i] % 2 != 0 && n % 2 == 0)
                {
                    doubleimp = true;
                    break;
                } 
            }

            if (doubleimp)
                Console.Write("Nu se poate obtine un sir palindrom rearanjand elementele");
            else
                Console.Write("Se poate obtine un sir palindrom rearanjand elementele");
        }

        private static void Problema69()
        {
            int n, x;

            Console.WriteLine("Se da inaltimea a n copii, numerotati de la 1 la n. Afisati numerele de ordine ale copiilor in ordine cresc a inaltimii lor");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.WriteLine("Inaltimea se va scrie in cm");

            int[] copii = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"copil {i + 1}: ");
                copii[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Array.IndexOf(copii, copii.Max()) + 1} ");
                copii[Array.IndexOf(copii, copii.Max())] = 0;
            }
        }

        #endregion
    }
}
