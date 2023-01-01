using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IdealBoyKilo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cinsiyet;
            int kilo, boy;
            Console.WriteLine("Cinsiyetinizi Yazın=");
            cinsiyet = Console.ReadLine();
            Console.WriteLine("Kilonuzu giriniz = ");
            kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu giriniz = ");
            boy = Convert.ToInt32(Console.ReadLine());

            boy = boy % 100;
            if (cinsiyet == "kadın" && kilo > 45.5 + 2.3 * boy) ;
            {

                Console.WriteLine("Kilo vermeniz gerek");
            }
            Console.ReadKey();
            if (cinsiyet == "kadın" && kilo == 45.5 + 2.3 * boy) ;
            { 

                Console.WriteLine("Kilonuz ideal");
            }
            Console.ReadKey();
            if (cinsiyet == "kadın" && kilo < 45.5 + 2.3 * boy) ;
            { 
            Console.WriteLine("Kilo almanız gerek.");

                } Console.ReadKey();
            if (cinsiyet == "erkek" && kilo > 50 + 2.3 * boy) ;
            {

                Console.WriteLine("Kilo vermeniz gerek");
            }
            Console.ReadKey();

            if (cinsiyet == "erkek" && kilo == 50 + 2.3 * boy) ;
            {

                Console.WriteLine("Kilonuz ideal");
            }
            Console.ReadKey();
            if (cinsiyet == "erkek" && kilo < 50 + 2.3 * boy) ;
            {
                Console.WriteLine("Kilo almanız gerek.");
            }

            Console.ReadKey();
        }
    }
}
