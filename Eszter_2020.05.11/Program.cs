using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._05._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //2; Olvasd be egy derékszögű háromszög befogóit, 
            //és írd ki átfogóját, kerületét, területét, 
            //továbbá beírt és köréírt körének sugarát!
            //1.lépés: a és b változó értékét kérjül be a felhasználótól!
            Console.Write("Kérem adja meg a derékszögű háromszög egyik befogóját: ");
            //2.lépés: le kell tárolni a felh. által megadott értéket!
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a derékszögű háromszög másik befogóját: ");
            int b = int.Parse(Console.ReadLine());
            //c2=a2+b2
            int c2 = a * a + b * b;
            double c3 = Math.Pow(a, 2) + Math.Pow(b, 2);
            int c4 = (int)Math.Sqrt(c3);
            double c5 = Math.Round(Math.Sqrt(c3));
            double c6 = Math.Sqrt(c2);
            Console.WriteLine("c2={0}", c2);
            Console.WriteLine("c={0}", Math.Sqrt(c2));
            Console.WriteLine("c={0}", c3);
            Console.WriteLine("c={0}", c4);
            Console.WriteLine("c={0}", c5);

            //Számoljuk ki derékszögű háromszög területét, kerületét!
            Console.WriteLine("A derékszögű háromszög területe: " + a * b / 2);
            Console.WriteLine("A derékszögű háromszög kerülete: {0}", a + b + c6);

            //Számoljuk ki a beírt kör sugarát!
            //r=a*b/a+b+c
            double r = a * b / a + b + c6;
            Console.WriteLine("A háromszögbe írt kör sugara: {0}", r);
            double r1 = (a * b) / (a + b + c6);
            Console.WriteLine("A háromszögbe írt kör sugara: " + r1);

            //Számoljuk ki a köré írt kör sugarát!
            Console.WriteLine($"A háromszög köré írható kör sugara: {c6 / 2}");

            //ToString() metódussal kerekíteni tudunk!
            Console.WriteLine($"A háromszög köré írható kör sugara: {(c6 / 2).ToString("0.00")}");

            //Math.Round() metódussal kerekíteni tudunk!
            Console.WriteLine($"A háromszög köré írható kör sugara: {Math.Round(c6, 4)}");

            //Egy BKV jegy 270 Ft, egy automatából vett kávé 70 Ft, 
            //egy liter tej 210 Ft és egy üveg bor 700 Ft. 
            //Olvasd be a forint - euro árfolyamot (1 euro hány forint), majd írd ki a fenti termékek árát euroban! 
            int arfolyam = 354;
            double arfolyam1 = 353.55;

            //változó a termékekenek
            const int BKV_jegy = 270;
            double kave = 70.0;
            int tej = 210;
            int bor = 700;
            Console.WriteLine($"A BKV jegy ára euróban: {(double)BKV_jegy / arfolyam}");
            Console.WriteLine($"A kávé ára euróban: {kave / arfolyam}");
            Console.WriteLine($"A tej ára euróban: {((double)tej / arfolyam).ToString("0.00")}");
            Console.WriteLine($"A bor ára euróban: {((double)bor / arfolyam).ToString("0.00")}");
            
            Console.ReadKey();
        }
    }
}
