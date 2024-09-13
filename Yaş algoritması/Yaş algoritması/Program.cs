using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaş_algoritması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            double yas;

            Console.WriteLine("Lütfen Yaşınızı Giriniz");
            yas = double.Parse(Console.ReadLine());

            if (yas >= 0 && yas <= 17)
            {
                Console.WriteLine("Çocuk");
            }
            else if (yas >= 18 && yas <= 33)
            {
                Console.WriteLine("Genç");
            }
            else if (yas >= 34 && yas <= 50)
            {
                Console.WriteLine("Orta Yaşlı");
            }
            else if (yas >= 51)
            {
                Console.WriteLine("Yaşlı");
            }
            Console.ReadLine();
        }
    }

