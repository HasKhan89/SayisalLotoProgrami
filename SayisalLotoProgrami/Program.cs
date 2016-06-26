using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalLotoProgrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // KURALLAR:
            // 1 ve 49 arasında 6 değer üretilecek..
            // 8 tahmin sonucu vermeli..

            // Her satırda mutlaka birlik, 10'luk, 20'lik, 30'luk ve 40'luk ez 1 tane olabilir.
            // Tahminler her satırda küçükten büyüğe sıralanabilir.

            /*
                2   12  45  28  36  17
                4   22  27  31  19  1
                ...
                ...
            */

            Yontem1();

            //Yontem2();

            //Yontem3();

            Console.ReadKey();
        }

        private static void Yontem3()
        {
            Random rnd = new Random();

            Console.WriteLine("Tahminler üretiliyor..");
            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                int[] degerler = new int[6];

                for (int k = 0; k < 5; k++)
                {
                    int min = k * 10 + 1;
                    int max = min + 9;

                    if (max > 49)
                        max = 49;

                    //rnd.Next(1, 10);
                    //rnd.Next(11, 20);
                    //rnd.Next(21, 30);
                    //rnd.Next(31, 40);
                    //rnd.Next(41, 49);

                    int sayi = rnd.Next(min, max);
                    degerler[k] = sayi;
                }

                degerler[5] = rnd.Next(1, 49);

                Array.Sort(degerler);

                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}", degerler[0], degerler[1], degerler[2], degerler[3], degerler[4], degerler[5]);
            }

            Console.WriteLine();
            Console.WriteLine("Tahminler üretilmiştir. İyi şanslar.");
        }

        private static void Yontem2()
        {
            Random rnd = new Random();

            Console.WriteLine("Tahminler üretiliyor..");
            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                int[] degerler = new int[6];

                for (int k = 0; k < 6; k++)
                {
                    int sayi = rnd.Next(1, 49);
                    degerler[k] = sayi;
                }

                Array.Sort(degerler);

                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}", degerler[0], degerler[1], degerler[2], degerler[3], degerler[4], degerler[5]);
            }

            Console.WriteLine();
            Console.WriteLine("Tahminler üretilmiştir. İyi şanslar.");
        }

        private static void Yontem1()
        {
            Random rnd = new Random();

            Console.WriteLine("Tahminler üretiliyor..");
            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {

                for (int k = 0; k < 6; k++)
                {
                    int sayi = rnd.Next(1, 49);
                    Console.Write("\t" + sayi);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Tahminler üretilmiştir. İyi şanslar.");
        }
    }
}
